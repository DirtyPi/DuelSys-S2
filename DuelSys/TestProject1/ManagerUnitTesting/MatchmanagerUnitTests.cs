using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ClassLibrary;
using System.Collections.Generic;
using ClassLibrary.MockDAL;

namespace ClassLibTest.ManagerUnitTesting
{
    public class MatchmanagerUnitTests
    {
        [Fact]
        public void AddMatch_CreateMatchAndCompare_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            int TournamentID = 2;
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<Match> mListTest = new List<Match>();
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            mListTest.Add(m);
            // Act
            MockMatchMediator mockMatchMediator = new MockMatchMediator();
            mockMatchMediator.Add(m, TournamentID);
            MatchManager manager = new MatchManager(mockMatchMediator);


            // Assert
            Assert.Equal(mListTest, manager.GetAll());
        }
        [Fact]
        public void AddMatch_CreateMatchAndCompareWithNonExistantmatch_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            int TournamentID = 2;
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<Match> mListTest = new List<Match>();
            // Act
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            MockMatchMediator mockMatchMediator = new MockMatchMediator();
            mockMatchMediator.Add(m, TournamentID);
            MatchManager manager = new MatchManager(mockMatchMediator);


            // Assert
            Assert.NotEqual(mListTest, manager.GetAll());
        }
        [Fact]
        public void GetAllMatches_CreateAndCompareMatchesCount_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            int TournamentID = 2;
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<Match> mListTest = new List<Match>();
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            mListTest.Add(m);
            // Act
            MockMatchMediator mockMatchMediator = new MockMatchMediator();
            mockMatchMediator.Add(m, TournamentID);
            MatchManager manager = new MatchManager(mockMatchMediator);


            // Assert
            Assert.Equal(1, manager.GetAll().Count);
        }
        [Fact]
        public void GetAllMatches_CreateAndCompareMatchesCount_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            int TournamentID = 2;
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<Match> mListTest = new List<Match>();
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            // Act
            MockMatchMediator mockMatchMediator = new MockMatchMediator();
            mockMatchMediator.Add(m, TournamentID);
            MatchManager manager = new MatchManager(mockMatchMediator);


            // Assert
            Assert.NotEqual(0, manager.GetAll().Count);
        }
        [Fact]//NeedsToChange
        public void GetMatch_CreateMatchAndSearch_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            int TournamentID = 2;
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<Match> mListTest = new List<Match>();
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            mListTest.Add(m);
            // Act
            MockMatchMediator mockMatchMediator = new MockMatchMediator();
            mockMatchMediator.Add(m, TournamentID);
            MatchManager manager = new MatchManager(mockMatchMediator);


            // Assert
            Assert.NotEqual(m, manager.Get(TournamentID));
        }
        [Fact]
        public void GetMatch_CreateMatchAndSearch_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            int TournamentID = 2;
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<Match> mListTest = new List<Match>();
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            mListTest.Add(m);
            // Act
            MockMatchMediator mockMatchMediator = new MockMatchMediator();
            MatchManager manager = new MatchManager(mockMatchMediator);


            // Assert
            Assert.NotEqual(m, manager.Get(TournamentID));
        }
    }
}
