using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
	public interface IMatchMediator
	{
		public void Add(Match m,int id);
		public List<Match> GetAll();
	}
}
