using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary { 
	public class UserManager
	{
		private IUserMediator _userMediator;
		private UserMediator um = new UserMediator();
		public UserManager(IUserMediator mediator)
		{
			_userMediator=mediator;
		}
		public void Add(User u)
		{
			_userMediator.Add(u);
		}

		
		public List<User> GetAll()
		{
			
			return _userMediator.GetAll();
			//return um.GetAll();
		}



        public User GetUserID(int id)
        {
            foreach (User u in GetAll())
            {
                if (u.Id == id)
                {
                    return u;
                }
            }
            return null;
        }

        public User GetUserEmail(string email)
		{
			foreach (User u in GetAll())
			{
				if (u.Email == email)
				{
					return u;
				}
			}
			return null;
		}

		public bool CheckIfUserExists(User user)
		{
			foreach (User u in GetAll())
			{
				if (user.Email == u.Email && user.Password == u.Password)
				{
						return true;
				}
			}
			return false;
		}
		public bool CheckIfUserCredentials(string email ,string password)
		{
			foreach (User u in GetAll())
			{
				if (u.Email == email && u.Password == password)
				{
					return true;
				}
			}
			return false;
		}
		//private bool Load()
		//{
		//	if (GetAll() != null)
		//	{
		//		return true;
		//	}
		//	else { return false; }
		//}
	}
}
