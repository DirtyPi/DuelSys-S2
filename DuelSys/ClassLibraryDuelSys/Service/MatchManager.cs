using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
	public class MatchManager
	{
		private IMatchMediator matchMediator;
		public MatchManager(IMatchMediator mediator)
        {
			this.matchMediator = mediator;
        }
		//public List<Match> GetAllById(int id)
  //      {
		//	return this.matchMediator.GetAllById(id);
  //      }
		public List<Match> GetAll()
        {
			return matchMediator.GetAll();
        }
		public Match Get(int id)
        {
			foreach (Match m in GetAll())
			{
				if (m.ID == id)
				{
					return m;
				}
			}
			return null;
		}
		public void CompleteMatch(Tournament tournament)
		{
			foreach (Match m in tournament.GetAll())
			{
				foreach (Round r in m.GetAllById())
				{
					bool allSame = m.GetAllById().All(r => r.roundStatus == GameStatusEnum.COMPLETE);
					if (allSame)
					{
						m.matchStatus = GameStatusEnum.COMPLETE;
						m.GetScore();
						tournament.Update(m);
					}
				}
				
				//tournament.Update(m);
			}
		}

		

	}
}
