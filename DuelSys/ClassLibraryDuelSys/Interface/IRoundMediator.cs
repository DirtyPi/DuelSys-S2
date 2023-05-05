using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
	public interface IRoundMediator
	{
		public void Add(Round r ,int matchid);
		public List<Round> GetAll();
		public List<Round> GetAllById(int id);
		public bool Update(Round r);
		public int[] GetWinnerlById(int id);
	}
}
