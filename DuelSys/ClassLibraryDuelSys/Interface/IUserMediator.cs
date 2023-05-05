using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
	public interface IUserMediator
	{
		public void Add(User u);
		public List<User> GetAll();
	}
}
