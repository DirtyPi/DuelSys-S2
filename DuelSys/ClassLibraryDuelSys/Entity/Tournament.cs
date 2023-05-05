using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Tournament
    {
		private IParticipatingMediator participatingMediator = new ParticipatingMediator();
		private IMatchMediator matchMediator =new MatchMediator();
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
		
		public List<Participating> playrs 
		{
			get; set;
		}

		public List<Match> matches
		{
			get; set;
		}

		public Tournament()
		{
			this.playrs = new List<Participating>();
			this.matches = new List<Match>();
		}

		public Tournament( string stratTime,string end, string location, string description,int maxPlayers, int minPlayers,TypeOfSportEnum typeOfSport)
		{
			this.StartTime = stratTime;
			this.EndGame = end;
			this.Location = location;
			this.Description = description;
			this.MaxPlayers = maxPlayers;
			this.MinPlayers = minPlayers;
			this.SportType = typeOfSport;
			
			this.playrs = new List<Participating>();
			this.matches = new List<Match>();

		}

		//	public Tournament(IParticipatingMediator pm ,IMatchMediator mm, string stratTime,string end, string location, string description,int maxPlayers, int minPlayers,TypeOfSportEnum typeOfSport)
		//{
		//	this.participatingMediator = pm;
		//	this.matchMediator = mm;
		//	this.StartTime = stratTime;
		//	this.EndGame = end;
		//	this.Location = location;
		//	this.Description = description;
		//	this.MaxPlayers = maxPlayers;
		//	this.MinPlayers = minPlayers;
		//	this.SportType = typeOfSport;
			
		//	this.playrs = new List<Participating>();
		//	this.matches = new List<Match>();

		//}
		
		public string ToString()
		{
			return $"{this.id} / Type:{this.SportType}/ Begins:{this.StartTime}/ Location:{this.Location}/ ";
		}
		//public bool isTournamentActive()
  //      {
		//	return (DateTime.Now > Convert.ToDateTime(StartTime) || DateTime.Now < Convert.ToDateTime(EndGame));
           
  //      }
		public bool isTournamentStarted()
		{
			return (DateTime.Now > Convert.ToDateTime(StartTime) );

		}
		public bool TournamentEnded()
        {
			return DateTime.Now > Convert.ToDateTime(EndGame);
		}
		public bool TournamentAvailability()
        {
			return (MaxPlayers > GetAllByTournament().Count);
				
        }
		public bool CheckPlayrsToStart()
        {
			return (MinPlayers < GetAllByTournament().Count);
        }

        public bool isOpen()
        {
           // DateTime dt = start.ToDate(dateFmt);
           // DateTime date = DateTime.ParseExact(this.StartTime, "dd/MM/yyyy ", System.Globalization.CultureInfo.InvariantCulture);
			DateTime date = DateTime.ParseExact(this.StartTime, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
			//Console.WriteLine(date);
			date = date.AddDays(-7);
			//Console.WriteLine(date);
            return DateTime.Now < date;
        }

        public void Add(Participating p)
		{
			participatingMediator.Add(p);
		}

		public void Delete(Participating p)
		{
			participatingMediator.Delete(p);
		}
		public void Update(Participating p)
        {
			participatingMediator.Update(p);
        }
		
		private bool Load()
		{
			if (participatingMediator.GetAll() != null)
			{
				return true;
			}
			else { return false; }
		}
		public List<Participating> GetAllByTournament()
        {
			Load();
			List<Participating> participatings = new List<Participating>();
			foreach(Participating p in participatingMediator.GetAll())
            {
				if(p.tournament.id == this.id)
                {
					participatings.Add(p);
                }
            }
			return participatings;
        }
		public Participating GetByPlayer(int id)
		{
			foreach (Participating t in GetAllByTournament())
			{
				if (t.player.Id == id)
				{
					return t;
				}
			}
			return null;
		}

		public void Add(Match m)
        {
			//matches.Add(m);
			matchMediator.Add(m, id);
        }
		public void Update(Match m)
		{
			matchMediator.Update(m);
		}

		public List<Match> GetAll()
		{
			return matchMediator.GetAllById(this.id);
		}
	}
}
