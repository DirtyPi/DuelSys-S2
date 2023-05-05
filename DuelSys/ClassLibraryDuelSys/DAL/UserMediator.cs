using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassLibrary;


namespace ClassLibrary
{
	public class UserMediator : DataAccess,IUserMediator
	{
        private DataAccess dataAccessLayer;
       


        public void Add(User users)
        {
           
               
                List<User> listusers = new List<User>();
              if (ConnOpen())
              {
                try
                {
                    query = "INSERT INTO user_syn(email,password,fullname,role)" +
                       "VALUE (@email,@password,@fullname,@role)";
                    SqlQuery(query);

                    AddWithValue("@email", users.Email);
                    AddWithValue("@password", users.Password);
                    AddWithValue("@fullname", users.FullName);
                    AddWithValue("@role", users.Role);


                    NonQueryEx();

                    users.Id = Convert.ToInt32(command.LastInsertedId);
                    Close();

                    // listusers.Remove(users);
                    listusers.Add(users);
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
        

		public List<User> GetAll()
		{
           
                List<User> users = new List<User>();
                if (ConnOpen())
                {
                    try
                    {

                        query = "SELECT * FROM user_syn";


                        SqlQuery(query);

                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            User user = new User(
                            dataReader["email"].ToString(),
                            dataReader["password"].ToString(),
                            dataReader["fullname"].ToString(),
                          (UserRoleEnum)Enum.Parse(typeof(UserRoleEnum), dataReader["role"].ToString()));
                            user.Id = Convert.ToInt32(dataReader["id"]);

                            users.Add(user);
                        }
                        Close();
                        return users;
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
                else
                {
                    Close();
                    return null;
                }
          
        }

		
	}
}
