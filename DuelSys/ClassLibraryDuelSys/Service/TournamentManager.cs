using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
	public class TournamentManager
	{
		private ITournamentMediator _mediator;
		//private IParticipatingMediator participatingMediator = new ParticipatingMediator();
		public TournamentManager(ITournamentMediator tournamentMediator)
		{
			this._mediator = tournamentMediator;
		}

		public void Add(Tournament t)
		{
			_mediator.Add(t);
		}

		
		public List<Tournament> GetAll()
		{
			return _mediator.GetAll();
		}


		//private bool Load()
		//{
		//	if (GetAll() != null)
		//	{
		//		return true;
		//	}
		//	else { return false; }
		//}
		public Tournament Get(int id)
		{
			//Load();
			foreach (Tournament t in GetAll())
			{
				if (t.id == id)
				{
					return t;
				}
			}
			return null;
		}
		public List<int[]> GetRanking(Tournament tournament)
		{
			List<int> participants = new List<int>();
			foreach (var item in tournament.GetAllByTournament())
			{
				participants.Add(item.player.Id);
			}
			List<int[]> ranking = new List<int[]>();
			List<int[]> wins = _mediator.GetMatchWins(participants, tournament.id);
			int total_games_a_player_plays = wins.Count - 1;
			foreach (var item in wins)
			{                                                                   // - the games that he has won to get the result of lost matches
				int[] player_stats = { item[0], item[1], total_games_a_player_plays - item[1] };
				ranking.Add(player_stats);
			}
			ranking.OrderBy(item => item[1]);
			return ranking;
		}


		
        public bool CompleteTournament(Tournament tournament)
        {
			
			foreach (Match m in tournament.GetAll())
            {
				foreach(Participating p in tournament.GetAllByTournament())
                {
					bool allSame = tournament.GetAll().All(m => m.matchStatus == GameStatusEnum.COMPLETE);
					if (allSame)
					{
						
						return true;

					}
				
				}
			}
			return false;

		}


    }
}
