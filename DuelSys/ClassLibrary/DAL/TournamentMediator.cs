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
                        query = "INSERT INTO tournaments_syn (id,start,location,minPlayers,maxPlayers,Description,type)" +
                        " VALUE (@id,@start,@location,@minPlayers,@maxPlayers,@Description,@type)";
                        SqlQuery(query);
                        AddWithValue("@id", t.id);
                        AddWithValue("@start", t.StartTime);
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
                        query = "SELECT * FROM tournaments_syn";


                        SqlQuery(query);

                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {

                            Tournament t = new Tournament(
                            dataReader["start"].ToString(),
                            dataReader["location"].ToString(),
                            dataReader["Description"].ToString(),
                            Convert.ToInt32(dataReader["minPlayers"]),
                            Convert.ToInt32(dataReader["maxPlayers"]),
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
    }
}
