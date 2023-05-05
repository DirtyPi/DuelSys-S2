using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Tournament
    {
		public int id
		{
			get;set;
		}

		public string StartTime
		{
			get; set;
		}
		public string EndGame
		{
			get; set;
		}
		public string Location
		{
			get; set;
		}

		public int MinPlayers
		{
			get; set;
		}

		public int MaxPlayers
		{
			get; set;
		}

		public string Description
		{
			get; set;
		}
		public TypeOfSportEnum SportType
        {
			get;set;
        }

		public List<User> playrs
		{
			get; set;
		}

		public List<Match> matches
		{
			get; set;
		}

		public Tournament()
		{
			throw new NotImplementedException();
		}

		public Tournament( string stratTime, string location, string description,int maxPlayers, int minPlayers,TypeOfSportEnum typeOfSport)
		{
			this.StartTime = stratTime;
			this.Location = location;
			this.Description = description;
			this.MaxPlayers = maxPlayers;
			this.MinPlayers = minPlayers;
			this.MaxPlayers=maxPlayers;
		}
        public bool isTournamentActive()
        {
            if (DateTime.Now > Convert.ToDateTime(StartTime) || DateTime.Now < Convert.ToDateTime(EndGame))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		public string ToString()
		{
			return $"{this.id}/ Type:{this.SportType}/ Begins:{this.StartTime}/ Location:{this.Location}/ ";
		}

		public void Add(User u)
		{
			throw new NotImplementedException();
		}

		public void Delete(User u)
		{
			throw new NotImplementedException();
		}

		public List<User> GetAllPlayersID(int id)
		{
			throw new NotImplementedException();
		}
		
	}
}
