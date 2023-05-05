using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassLibrary;

namespace ClassLibrary
{
	public class MatchMediator : DataAccess, IMatchMediator
	{
		private DataAccess dataAccessLayer;
        private TournamentMediator tournamentMediator = new TournamentMediator();
        private UserMediator userMediator = new UserMediator();
        public void Add(Match match,int tournamentID)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO match_syn(player1,player2,resultOfPlayer1,resultOfPlayer2,tournament, status)" +
                   "VALUE (@player1,@player2,@resultOfPlayer1,@resultOfPlayer2,@tournament, @status)";
                    SqlQuery(query);

                    AddWithValue("@player1", match.Player1.Id);
                    AddWithValue("@player2", match.Player2.Id);
                    AddWithValue("@resultOfPlayer1", match.ResultPlayer1);
                    AddWithValue("@resultOfPlayer2", match.ResultPlayer2);
                    AddWithValue("@tournament", tournamentID);
                    AddWithValue("@status", GameStatusEnum.PENDING);

                    NonQueryEx();

                    match.ID = Convert.ToInt32(command.LastInsertedId);
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

        public List<Match> GetAll()
        {
            try
            {
                List<Match> matchs = new List<Match>();
                List<Tournament> tournaments = tournamentMediator.GetAll();
                List<User> users = userMediator.GetAll();
                if (ConnOpen())
                {
                    query = "SELECT * FROM match_syn";
                    SqlQuery(query);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        foreach(Tournament t in tournaments)
                        {
                            if (t.id == Convert.ToInt32(dataReader["tournament"])) tournament = t;
                        }
                        User user1 = new User();
                        foreach (User u1 in users)
                        {
                            if (u1.Id == Convert.ToInt32(dataReader["player1"])) user1 = u1;
                        }
                        User user2 = new User();
                        foreach (User u2 in users)
                        {
                            if (u2.Id == Convert.ToInt32(dataReader["player2"])) user2 = u2;
                        }
                        Match match = new Match(user1, user2, Convert.ToInt32(dataReader["resultOfPlayer1"]), Convert.ToInt32(dataReader["resultOfPlayer2"]), (GameStatusEnum)Enum.Parse(typeof(GameStatusEnum), dataReader["status"].ToString()));
                        
                        match.ID = Convert.ToInt32(dataReader["id"]);

                        matchs.Add(match);
                    }
                    Close();
                    return matchs;
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
            return null;
        }
        public bool Update(Match match)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "UPDATE match_syn SET resultOfPlayer1 = @resultOfPlayer1 ,resultOfPlayer2 = @resultOfPlayer2, status = @status WHERE id = @id";
                    SqlQuery(query);
                    AddWithValue("@resultOfPlayer1", match.ResultPlayer1);
                    AddWithValue("@resultOfPlayer2", match.ResultPlayer2);
                    AddWithValue("@status", match.matchStatus);
                    AddWithValue("@id", match.ID);

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
        public List<Match> GetAllById(int tournamentId)
        {
            try
            {
                List<Match> matchs = new List<Match>();
                List<Tournament> tournaments = tournamentMediator.GetAll();
                List<User> users = userMediator.GetAll();
                if (ConnOpen())
                {
                    query = "SELECT * FROM match_syn WHERE tournament = "+ tournamentId;
                    SqlQuery(query);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Tournament tournament = new Tournament();
                        foreach (Tournament t in tournaments)
                        {
                            if (t.id == Convert.ToInt32(dataReader["tournament"])) tournament = t;
                        }
                        User user1 = new User();
                        foreach (User u1 in users)
                        {
                            if (u1.Id == Convert.ToInt32(dataReader["player1"])) user1 = u1;
                        }
                        User user2 = new User();
                        foreach (User u2 in users)
                        {
                            if (u2.Id == Convert.ToInt32(dataReader["player2"])) user2 = u2;
                        }
                        Match match = new Match(user1, user2, Convert.ToInt32(dataReader["resultOfPlayer1"]), Convert.ToInt32(dataReader["resultOfPlayer2"]), (GameStatusEnum)Enum.Parse(typeof(GameStatusEnum), dataReader["status"].ToString()));

                        match.ID = Convert.ToInt32(dataReader["id"]);

                        matchs.Add(match);
                    }
                    Close();
                    return matchs;
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
            return null;
        }    

    }
}
	

