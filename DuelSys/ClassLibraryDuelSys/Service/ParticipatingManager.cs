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
       
        public List<Participating> GetAll()
        {
            return mediator.GetAll();
        }
        public List<Participating> GetAllByPlayerID(int id)
        {
            List<Participating> participatings = new List<Participating>();
            foreach(Participating p in GetAll())
            {
                if(p.player.Id == id)
                {
                    participatings.Add(p);
                }
            }return participatings;
        }
        //public Participating Get(int id)
        //{
        //    foreach (Participating t in GetAll())
        //    {
        //        if (t.id == id)
        //        {
        //            return t;
        //        }
        //    }
        //    return null;
        //}
        public Participating GetByPlayer(int id)
        {
            foreach (Participating t in GetAll())
            {
                if (t.player.Id == id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
