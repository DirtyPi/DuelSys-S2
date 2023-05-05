using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace ClassLibrary
{
	public class Match

	{
		private IRoundMediator mediator = new RoundMediator();
		public int ID
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
		public GameStatusEnum matchStatus
			{get;set; }

		public List<Round> rounds
		{
			get; set;
		}
		public Match() { }
		public Match(User player1,User player2,int resultPlayer1,int resultPlayer2, GameStatusEnum gameStatusEnum)
        {
			this.Player1 = player1;
			this.Player2 = player2;
			this.ResultPlayer1 = resultPlayer1;
			this.ResultPlayer2 = resultPlayer2;
			this.matchStatus = gameStatusEnum;
        }
		public Match(User player1, User player2)
		{
			this.Player1 = player1;
			this.Player2 = player2;
			
		}
		public string ToString()
		{
			//return $"{this.ID} / Player 1 :{this.Player1.FullName}| result:{this.ResultPlayer1} | Player 2 :{this.Player2.FullName} result: {this.ResultPlayer2} // Match Status:{this.matchStatus}";
			return $"{this.ID} / {this.Player1.FullName} {this.ResultPlayer1}|vs|{this.ResultPlayer2} {this.Player2.FullName}  // Match Status:{this.matchStatus}";
		}

		public void GenerateRounds(Round r)
		{
			//rounds.Add(r);
			mediator.Add(r,ID);
		}
		public List<Round> GetAllById()
		{
			return mediator.GetAllById(this.ID);
		}

		public void UpdateRoundScore(Round r)
		{
			mediator.Update(r);
		}
        public void GetScore()
        {
            int[] sc = mediator.GetWinnerlById(ID);

            this.ResultPlayer1 = sc[0];
            this.ResultPlayer2 = sc[1];
        }
		

		//public int GetWinner()
  //      {
		//	if(ResultPlayer1 > ResultPlayer2)
  //          {
		//		return 1;
  //          }
  //          else
  //          {
		//		return 2;
  //          }
  //      }

    }
}
