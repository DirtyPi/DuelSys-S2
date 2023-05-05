using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary 
{ 
	public class TournamentManager
	{
		private ITournamentMediator _mediator;
		public TournamentManager(ITournamentMediator tournamentMediator)
        {
			this._mediator = tournamentMediator;
        }
		
		public void Add(Tournament t)
		{
			_mediator.Add(t);
		}

		public List<Tournament> GetAll()
		{
			return _mediator.GetAll();
		}

		
		private bool Load()
		{
			if (GetAll() != null)
			{
				return true;
			}
			else { return false; }
		}
		public Tournament Get(int id)
        {
			foreach(Tournament t in GetAll())
            {
				if(t.id == id)
                {
					return t;
                }
            }return null;
        }
	}
}
