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
		public Round() { }
		public Round(int resultPlayer1,int resultPlayer2)
        {
			this.ResultPlayer1 = resultPlayer1;
			this.ResultPlayer2 = resultPlayer2;
        }
	}
}
