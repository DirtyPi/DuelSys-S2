using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RoundManager
    {
        private IRoundMediator roundMediator;
        public RoundManager(IRoundMediator mediator) 
        {
            this.roundMediator = mediator;
        }
        //public List<Round> GetAllById(int id)
        //{
        //    return roundMediator.GetAllById(id);
        //}
        public List<Round> GetAll()
        {
            return roundMediator.GetAll();
        }
        public Round Get(int id)
        {
            foreach (Round r in GetAll())
            {
                if (r.ID == id)
                {
                    return r;
                }
            }
            return null;
        }

       
    }
}
