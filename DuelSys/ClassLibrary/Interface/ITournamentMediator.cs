using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace ClassLibrary
{
	public interface ITournamentMediator
	{
		public void Add(Tournament t);
		public List<Tournament> GetAll();
	}
}
