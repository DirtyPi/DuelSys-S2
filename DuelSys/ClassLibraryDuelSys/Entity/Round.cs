using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Round
    {
		public int ID
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
        public GameStatusEnum roundStatus
        { get; set; }
        public Round() { }
		public Round(int resultPlayer1,int resultPlayer2, GameStatusEnum gameStatusEnum)
        {
			this.ResultPlayer1 = resultPlayer1;
			this.ResultPlayer2 = resultPlayer2;
            this.roundStatus = gameStatusEnum;
        }
        public Round(int resultPlayer1, int resultPlayer2)
        {
            this.ResultPlayer1 = resultPlayer1;
            this.ResultPlayer2 = resultPlayer2;
           
        }
        public string ToString()
        {
            return $"{this.ID} / Game Result of Player 1: {this.ResultPlayer1} || Game Result of Player 2: {this.ResultPlayer2} // Game Status:{this.roundStatus}";
        }

        public int FindWinner(int resultPlayer1, int resultPlayer2)
        {
            bool conditionP1MoreP2 = resultPlayer1 > resultPlayer2 && resultPlayer1 == 21 && resultPlayer2 < 20;
            bool conditionP2MoreP1 = resultPlayer1 < resultPlayer2 && resultPlayer2 == 21 && resultPlayer1 < 20;
            bool conditionP1MoreP22Pts = resultPlayer1 > resultPlayer2 && (resultPlayer1 >= 20 && resultPlayer2 >= 20) && ((resultPlayer1 - resultPlayer2) >= 2) && (resultPlayer1 < 30 && resultPlayer2 < 30);
            bool conditionP2MoreP12Pts = resultPlayer2 > resultPlayer1 && (resultPlayer2 >= 20 && resultPlayer1 >= 20) && ((resultPlayer2 - resultPlayer1) >= 2) && (resultPlayer1 < 30 && resultPlayer2 < 30);
            bool conditionP1Final = resultPlayer1 == 30 && resultPlayer2 == 29;
            bool conditionP2Final = resultPlayer2 == 30 && resultPlayer1 == 29;

            if (conditionP1MoreP2 || conditionP1MoreP22Pts || conditionP1Final)
            {
                return 1;
            }
            else if (conditionP2MoreP1 || conditionP2MoreP12Pts || conditionP2Final)
            {
                return 2;
            }
            return 0;
        }


	}
}
