
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassLibrary;

namespace ClassLibrary
{
	public class TournamentMediator : DataAccess,ITournamentMediator
	{
		private DataAccess dataAccessLayer;
        public void Add(Tournament t)
        {   
                if (ConnOpen())
                {
                    try
                    {
                        query = "INSERT INTO tournaments_syn (id,start,end,location,minPlayers,maxPlayers,Description,type)" +
                        " VALUE (@id,@start,@end,@location,@minPlayers,@maxPlayers,@Description,@type)";
                        SqlQuery(query);
                        AddWithValue("@id", t.id);
                        AddWithValue("@start", t.StartTime);
                        AddWithValue("@end", t.StartTime);
                        AddWithValue("@location", t.Location);
                        AddWithValue("@minPlayers", t.MinPlayers);
                        AddWithValue("@maxPlayers", t.MaxPlayers);
                        AddWithValue("@Description", t.Description);
                        AddWithValue("@type", t.SportType);
                    

                    NonQueryEx();
                        t.id = Convert.ToInt32(command.LastInsertedId);
                        Close();
                    }
                    catch (FormatException)
                    {
                        Close();
                    }
                    finally
                    {
                        Close();
                    }

                }
                else
                {
                    Close();
                }
        }
       
        
        public List<Tournament> GetAll()
        {
            List<Tournament> tournaments = new List<Tournament>();
           
                if (ConnOpen())
                {
                    try
                    {
                        query = "SELECT * FROM tournaments_syn ORDER BY id DESC";


                        SqlQuery(query);

                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {

                            Tournament t = new Tournament(
                            dataReader["start"].ToString(),
                            dataReader["end"].ToString(),
                            dataReader["location"].ToString(),
                            dataReader["Description"].ToString(),
                            Convert.ToInt32(dataReader["maxPlayers"]),
                            Convert.ToInt32(dataReader["minPlayers"]),
                           (TypeOfSportEnum)Enum.Parse(typeof(TypeOfSportEnum), dataReader["type"].ToString()));
                            t.id = Convert.ToInt32(dataReader["id"]);
                            tournaments.Add(t);
                        }
                        Close();
                        return tournaments;
                    }
                    catch (FormatException)
                    {
                        Close();
                        return null;
                    }
                    finally
                    {
                        Close();
                    }


                }
               return tournaments;

        }


        public List<int[]> GetMatchWins(List<int> players, int tournamentID)
        {
            List<int[]> result = new List<int[]>();
            try
            {
                foreach (var player in players)
                {
                    if (ConnOpen())
                    {
                        query = "select sum(pt.res) as res from (select distinct IFNULL(count(resultOfPlayer1 > resultOfPlayer2), 0) as res from match_syn " +
                            "WHERE match_syn.player1 = @player and match_syn.tournament = @tournament and resultOfPlayer1 > resultOfPlayer2 " +
                            "UNION " +
                            "all select distinct  IFNULL(count(resultOfPlayer2 > resultOfPlayer1), 0) as res from match_syn " +
                            "WHERE match_syn.player2 = @player and match_syn.tournament = @tournament and resultOfPlayer2 > resultOfPlayer1) pt";
                        SqlQuery(query);
                        AddWithValue("@tournament", tournamentID);
                        AddWithValue("@player", player);
                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            int[] temp = { player, Convert.ToInt32(dataReader["res"]) };
                            result.Add(temp);
                        }
                    }
                    Close();
                }
                
            }
            catch (FormatException)
            {
                Close();
                return null;
            }
            finally
            {
                Close();
            }
            return result;
        }
    }
}
