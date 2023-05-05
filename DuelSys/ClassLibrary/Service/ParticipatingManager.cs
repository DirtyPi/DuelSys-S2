using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class ParticipatingManager
    {
        private IParticipatingMediator mediator;
        public ParticipatingManager(IParticipatingMediator participatingMediator)
        {
            this.mediator= participatingMediator;
        }
        public void Add(Participating p)
        {
            mediator.Add(p);
        }
        public List<Participating> GetAll()
        {
            return mediator.GetAll();
        }
        public Participating Get(int id)
        {
            foreach (Participating t in GetAll())
            {
                if (t.id == id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
