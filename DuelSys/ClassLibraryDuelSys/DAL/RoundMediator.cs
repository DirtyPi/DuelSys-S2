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
                    query = "INSERT INTO round_syn(resultOfPlayer1,resultOfPlayer2,matchID,status) VALUES (@resultOfPlayer1,@resultOfPlayer2,@matchID,@status)"; 
                    SqlQuery(query);

                    AddWithValue("@resultOfPlayer1", 0);
                    AddWithValue("@resultOfPlayer2", 0);
                    AddWithValue("@matchID", matchID);
                    AddWithValue("@status", GameStatusEnum.PENDING);

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
                            if (m.ID == Convert.ToInt32(dataReader["matchID"])) match = m;
                        }
                       
                       
                        Round round = new Round( Convert.ToInt32(dataReader["resultOfPlayer1"]), Convert.ToInt32(dataReader["resultOfPlayer2"]), (GameStatusEnum)Enum.Parse(typeof(GameStatusEnum), dataReader["status"].ToString()));

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
       public bool Update(Round r)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "UPDATE round_syn SET resultOfPlayer1 = @resultOfPlayer1 ,resultOfPlayer2 = @resultOfPlayer2, status = @status WHERE id = @id";
                    SqlQuery(query);
                    AddWithValue("@resultOfPlayer1", r.ResultPlayer1);
                    AddWithValue("@resultOfPlayer2", r.ResultPlayer2);
                    AddWithValue("@status", GameStatusEnum.COMPLETE);
                    AddWithValue("@id", r.ID);
                    NonQueryEx();
                    Close();
                    return true;
                }
                catch
                {
                    Close();
                    return false;
                }
                finally
                {
                    Close();
                }
            }
            else
            {
                Close();
                return false;
            }
       }
        public List<Round> GetAllById(int matchId)
        {
            try
            {
                List<Round> rounds = new List<Round>();
                List<Match> matches = matchMediator.GetAll();
                if (ConnOpen())
                {
                    query = "SELECT * FROM round_syn WHERE matchID = "+ matchId;
                    SqlQuery(query);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Match match = new Match();
                        foreach (Match m in matches)
                        {
                            if (m.ID == Convert.ToInt32(dataReader["matchID"])) match = m;
                        }
                        Round round = new Round(Convert.ToInt32(dataReader["resultOfPlayer1"]), Convert.ToInt32(dataReader["resultOfPlayer2"]), (GameStatusEnum)Enum.Parse(typeof(GameStatusEnum), dataReader["status"].ToString()));

                        round.ID = Convert.ToInt32(dataReader["id"]);

                        rounds.Add(round);
                    }
                    Close();
                    return rounds;
                }
                else{ Close(); return null; }
            }
            catch (FormatException) { Close();return null; }
            finally
            {    Close(); }
        }
        public int[] GetWinnerlById(int matchId)
        {
            try
            {
                int[] re1 = { 0, 0 };
                if (ConnOpen())
                {
                    query = "SELECT * FROM round_syn WHERE matchID = " + matchId;
                    SqlQuery(query);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (Convert.ToInt32(dataReader["resultOfPlayer1"]) > Convert.ToInt32(dataReader["resultOfPlayer2"]))
                        {
                            re1[0] = re1[0] + 1;
                        }
                        else
                        {
                            re1[1] = re1[1] + 1;
                        } 
                    }
                    Close();
                    return re1;
                }
                else { Close(); return null; }
            }
            catch (FormatException) { Close(); return null; }
            finally
            { Close(); }
        }

    }
}
