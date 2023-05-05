using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class RoundRobin
    {


        public void MakeMatchups(List<User> users, Tournament tournament)
        {
            //make sure there are no reapeted matches
            List<int[]> m = new List<int[]>();
            foreach (User item1 in users)
            {
                foreach (User item2 in users)
                {
                    if (item1 != item2)
                    {
                        bool allow = true;
                        foreach (var item in m)
                        {
                            if (item[0] == item1.Id && item[1] == item2.Id || item[0] == item2.Id && item[1] == item1.Id)
                            {
                                allow = false;
                            }
                        }
                        if (allow)
                        {

                            m.Add(new int[] { item1.Id, item2.Id }); m.Add(new int[] { item2.Id, item1.Id });
                            Match match = new Match(item1, item2,0,0,GameStatusEnum.PENDING);
                            tournament.Add(match);
                            for (int i = 1; i <= 3; i++)
                            {
                                Round r = new Round();
                                match.GenerateRounds(r);
                                //Console.WriteLine($"{item1} vs {item2} : Round: {i}");
                            }
                        }
                    }
                }
            }
        }
    }
}
