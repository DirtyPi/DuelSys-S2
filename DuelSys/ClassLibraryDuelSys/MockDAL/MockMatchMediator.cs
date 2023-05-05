using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MockMatchMediator : IMatchMediator
    {
        List<Match> _matchList = new List<Match>();
        Dictionary< Match, int> _matchDictionary = new Dictionary<Match, int>();
        public void Add(Match m, int id)
        {
            _matchDictionary.Add(m, id);
            _matchList.Add(m);
        }

        public List<Match> GetAll()
        {
            return _matchList;
        }

        public List<Match> GetAllById(int id)
        {
            return _matchList;
        }

        public bool Update(Match m)
        {
            throw new NotImplementedException();
        }
    }
}
