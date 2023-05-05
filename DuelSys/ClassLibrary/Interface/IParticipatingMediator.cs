using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IParticipatingMediator
    {
        public void Add(Participating p);
        public List<Participating> GetAll();
    }
}
