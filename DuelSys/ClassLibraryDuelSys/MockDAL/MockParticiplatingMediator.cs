using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MockParticiplatingMediator : IParticipatingMediator
    {
        List<Participating> participatings = new List<Participating>();
        public void Add(Participating p)
        {
            participatings.Add(p);
        }

        public void Delete(Participating p)
        {
            participatings.Remove(p);
        }

        public List<Participating> GetAll()
        {
            return participatings;
        }

        public bool Update(Participating p)
        {
            throw new NotImplementedException();
        }
    }
}
