using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibTest.ManagerUnitTesting
{
    public class TournamentManagerUnitTests
    {
        [Fact]
        public void AddTournament_CreateAndCompareWithCreatedTournament_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            List<Tournament> tors = new List<Tournament>();
            tors.Add(t);

            MockTournamentMediator mockTournament = new MockTournamentMediator();
            TournamentManager tournamentManager = new TournamentManager(mockTournament);

            // Act
            tournamentManager.Add(t);
            // Assert
            Assert.Equal(tors, tournamentManager.GetAll());
        }
        [Fact]
        public void AddTournament_CreateAndCompareWithNonExistantTournament_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            List<Tournament> tors = new List<Tournament>();

            MockTournamentMediator mockTournament = new MockTournamentMediator();
            TournamentManager tournamentManager = new TournamentManager(mockTournament);

            // Act
            tournamentManager.Add(t);
            // Assert
            Assert.NotEqual(tors, tournamentManager.GetAll());
        }
        [Fact]
        public void GetAllTournaments_CreateAndCompareWithCreatedTournament_AssertTrue()
        {
            // Arrange
            MockTournamentMediator mockTournament = new MockTournamentMediator();
            TournamentManager tournamentManager = new TournamentManager(mockTournament);

            // Act
            tournamentManager.Add(new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton));
            // Assert
            Assert.Equal(1, tournamentManager.GetAll().Count);
        }
        [Fact]
        public void GetAllTournaments_CompareWithTournament_AssertFalse()
        {
            // Arrange
            MockTournamentMediator mockTournament = new MockTournamentMediator();
            TournamentManager tournamentManager = new TournamentManager(mockTournament);

            // Act
            tournamentManager.Add(new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton));
            // Assert
            Assert.NotEqual(0, tournamentManager.GetAll().Count);
        }
        [Fact]
        public void GetTournamentByID_CreateAndCompareWithCreatedTournament_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            t.id = 1;
            List<Tournament> tors = new List<Tournament>();
            tors.Add(t);

            MockTournamentMediator mockTournament = new MockTournamentMediator();
            TournamentManager tournamentManager = new TournamentManager(mockTournament);
            tournamentManager.Add(t);

            // Act
            Tournament testTournament = tournamentManager.Get(1);
            // Assert
            Assert.Equal(t, testTournament);
        }
        [Fact]
        public void GetTournamentByID_GetNonExistantTournament_AssertFalse()
        {
            // Arrange
            MockTournamentMediator mockTournament = new MockTournamentMediator();
            TournamentManager tournamentManager = new TournamentManager(mockTournament);

            // Act
            Tournament testTournament = tournamentManager.Get(1);
            // Assert
            Assert.NotEqual(new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton), testTournament);
        }
        //[Fact]
        //public void CompleteTournament_CreateNonCompletedTournamentAndTestCreatedTournament_AssertTrue()
        //{
        //    // Arrange
        //    Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
        //    t.id = 1;

        //    MockTournamentMediator mockTournament = new MockTournamentMediator();
        //    TournamentManager tournamentManager = new TournamentManager(mockTournament);
        //    tournamentManager.Add(t);

        //    
        //    bool test = tournamentManager.CompleteTournament(t);
        //    
        //    Assert.False(test);
        // Arrange
        // Act
        //}// Assert
    }
}
