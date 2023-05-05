using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Match
    {public int ID
		{
			get; set;
		}

		public User Player1
		{
			get; set;
		}

		public User Player2
		{
			get; set;
		}

		public int ResultPlayer1
		{
			get; set;
		}

		public int ResultPlayer2
		{
			get; set;
		}
		

		public List<Round> rounds
		{
			get; set;
		}
		public Match() { }
		public Match(User player1,User player2,int resultPlayer1,int resultPlayer2)
        {
			this.Player1 = player1;
			this.Player2 = player2;
			this.ResultPlayer1 = resultPlayer1;
			this.ResultPlayer2 = resultPlayer2;
        }

		public void GenerateRounds(Round r)
		{
			throw new NotImplementedException();
		}

		public bool SaveScore(Round r)
		{
			throw new NotImplementedException();
		}
    }
}
