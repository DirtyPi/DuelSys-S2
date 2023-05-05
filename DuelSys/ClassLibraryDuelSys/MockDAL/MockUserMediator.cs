using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MockUserMediator : IUserMediator
    {
        List<User> users = new List<User>();
        public void Add(User u)
        {

            users.Add(u);
        }
        public List<User> GetAll()
        {
            return users;
        }
    }
}
