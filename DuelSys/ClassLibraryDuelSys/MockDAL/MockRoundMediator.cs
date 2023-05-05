using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MockDAL
{
    public class MockRoundMediator : IRoundMediator
    {
        List<Round> rounds = new List<Round>();
        Dictionary<Round, int> roundsDict = new Dictionary<Round, int>();
        public void Add(Round r, int matchid)
        {
            roundsDict.Add(r, matchid);
            rounds.Add(r);
        }

        public List<Round> GetAll()
        {
            return rounds;
        }

        public List<Round> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public int[] GetWinnerlById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Round r)
        {
            throw new NotImplementedException();
        }
    }
}
