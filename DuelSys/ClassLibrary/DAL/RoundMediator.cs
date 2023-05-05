using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassLibrary;

namespace ClassLibrary
{
    public class RoundMediator : DataAccess, IRoundMediator
    {
        private DataAccess dataAccessLayer;
        private MatchMediator matchMediator = new MatchMediator();
        public void Add(Round round, int matchID)
        {

            List<Round> rounds = new List<Round>();
            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO round_syn(resultOfPlayer1,resultOfPlayer2,Match)" +
                   "VALUE (@resultOfPlayer1,@resultOfPlayer2,@Match)";
                    SqlQuery(query);

                    AddWithValue("@resultOfPlayer1", round.ResultPlayer1);
                    AddWithValue("@resultOfPlayer2", round.ResultPlayer2);
                    AddWithValue("@Match", matchID);

                    NonQueryEx();

                    round.ID = Convert.ToInt32(command.LastInsertedId);
                    Close();
                    rounds.Add(round);
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
        public List<Round> GetAll()
        {
            try
            {
                List<Round> rounds = new List<Round>();
                List<Match> matches = matchMediator.GetAll();
                
                if (ConnOpen())
                {
                    query = "SELECT * FROM round_syn";
                    SqlQuery(query);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Match match = new Match();
                        foreach (Match m in matches)
                        {
                            if (m.ID == Convert.ToInt32(dataReader["Match"])) match = m;
                        }
                       
                       
                        Round round = new Round( Convert.ToInt32(dataReader["resultOfPlayer1"]), Convert.ToInt32(dataReader["resultOfPlayer2"]));

                        round.ID = Convert.ToInt32(dataReader["id"]);

                        rounds.Add(round);
                    }
                    Close();
                    return rounds;
                }
                else
                {
                    Close();
                    return null;
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
            
        }
        //public List<Round> GetAllByTournamentID(int matchID)
        //{
        //    List<Round> rounds = new List<Round>();
        //    try
        //    {
        //        if (ConnOpen())
        //        {
        //            query = "SELECT * FROM round_syn WHERE Match = @match";
        //            SqlQuery(query);
        //            MySqlDataReader dataReader = command.ExecuteReader();
        //            while (dataReader.Read())
        //            {

        //            }
        //        }
        //    catch (FormatException)
        //    {

        //    }
        //    finally
        //    {

        //    }
        //}

    }
}
