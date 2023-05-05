using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class Participating
    {
       
        public int id {get;set;}
        public Tournament tournament {get;set;}
        public User player {get;set;}
        public int Won {get;set;}
        public int Los {get;set;}
        public int Rank {get;set;}
        public Participating() { }
        public Participating(Tournament tournament,User player,int won,int los,int rank) 
        {
            this.tournament = tournament;
            this.player = player;
            this.Rank = rank;
            this.Won = won;
            this.Los = los;
        }
        public Participating(Tournament tournament, User player)
        {
            this.tournament = tournament;
            this.player = player;
        }
        public string ToString()
        {
            return $"{this.id} Player:{player.FullName} Wins:{this.Won} Losses:{this.Los}|| Rank: {this.Rank}";
        }
       

    }
}
