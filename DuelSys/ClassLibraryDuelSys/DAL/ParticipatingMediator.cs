using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassLibrary;
namespace ClassLibrary
{
    public class ParticipatingMediator : DataAccess, IParticipatingMediator
    {
        private DataAccess dataAccessLayer;
        private UserMediator userMediator = new UserMediator();
        private TournamentMediator tournamentMediator = new TournamentMediator();
        public void Add(Participating p)
        {
           
                List<Participating> participatings = new List<Participating>();
                if (ConnOpen())
                {
                    try
                    {
                        query = "INSERT INTO participating_syn(player,tournament,won,lost,rank)" +
                       "VALUE (@player,@tournament,@won,@lost,@rank)";
                        SqlQuery(query);

                        AddWithValue("@player", p.player.Id);
                        AddWithValue("@tournament", p.tournament.id);
                        AddWithValue("@won", p.Won);
                        AddWithValue("@lost", p.Los);
                        AddWithValue("@rank", p.Rank);

                        NonQueryEx();

                        p.id = Convert.ToInt32(command.LastInsertedId);
                        Close();
                        participatings.Add(p);
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

        public List<Participating> GetAll()
        {
            List<Participating> participatings = new List<Participating>();
            List<User> users = userMediator.GetAll();
            List<Tournament> tournaments = tournamentMediator.GetAll();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM participating_syn";


                    SqlQuery(query);

                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        User u = new User();
                        foreach (User user in users)
                        {
                            if (user.Id == Convert.ToInt32(dataReader["player"])) u = user;
                        }
                        Tournament t = new Tournament();
                        foreach (Tournament tournament in tournaments)
                        {
                            if (tournament.id == Convert.ToInt32(dataReader["tournament"]))
                            {
                                t = tournament;
                                tournament.playrs.Add(new Participating(t,u));
                            }
                        }
                        Participating p = new Participating(t, u,
                        Convert.ToInt32(dataReader["won"]), Convert.ToInt32(dataReader["lost"]), Convert.ToInt32(dataReader["rank"]));

                        p.id = Convert.ToInt32(dataReader["id"]);

                        participatings.Add(p);
                    }
                    Close();
                    return participatings;
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
            }return participatings;
            
        }
        
        public void Delete(Participating p)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "DELETE FROM participating_syn WHERE id = @id";
                    SqlQuery(query);
                    AddWithValue("@id", p.id);
                    NonQueryEx();
                    Close();

                }
                catch (Exception ex)
                {
                    Close();
                }
                finally
                {
                    Close();
                }
            }
        }
        public bool Update(Participating p)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "UPDATE participating_syn SET won = @won,lost = @lost, rank = @rank WHERE id = @id";
                    SqlQuery(query);
                    AddWithValue("@won", p.Won);
                    AddWithValue("@lost", p.Los);
                    AddWithValue("@rank", p.Rank);
                    AddWithValue("@id", p.id);

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


    } 
}
