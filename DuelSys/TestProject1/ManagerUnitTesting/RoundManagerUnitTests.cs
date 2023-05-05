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
    public class RoundManagerUnitTests
    {
        [Fact]
        public void AddRound_CreateRoundAndCompare_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "passw1ord", "testfFirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("te2st@mail.nl", "pass4word", "testfSirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            Round round = new Round(2, 1);
            MockRoundMediator mockRound = new MockRoundMediator();
            mockRound.Add(round, 1);
            RoundManager manager = new RoundManager(mockRound);
            // Act
            List<Round> testList = new List<Round>();
            testList.Add(round);


            // Assert
            Assert.Equal(testList, manager.GetAll());
        }
        [Fact]
        public void AddRound_CompareListWithNonExistentList_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "passw1ord", "testfFirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("te2st@mail.nl", "pass4word", "testfSirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            Round round = new Round(2, 1);
            MockRoundMediator mockRound = new MockRoundMediator();
            RoundManager manager = new RoundManager(mockRound);
            // Act
            List<Round> testList = new List<Round>();
            testList.Add(round);


            // Assert
            Assert.NotEqual(testList, manager.GetAll());
        }
        [Fact]
        public void GetAllRounds_CreateRoundsAndCompare_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "passw1ord", "testfFirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("te2st@mail.nl", "pass4word", "testfSirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            Round round = new Round(2, 1);
            MockRoundMediator mockRound = new MockRoundMediator();
            mockRound.Add(round, 1);
            RoundManager manager = new RoundManager(mockRound);
            // Act
            List<Round> testList = new List<Round>();
            testList.Add(round);


            // Assert
            Assert.Equal(testList, manager.GetAll());
        }
        [Fact]
        public void GetAllRounds_CompareWithEmptylist_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "passw1ord", "testfFirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("te2st@mail.nl", "pass4word", "testfSirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            Round round = new Round(2, 1);
            MockRoundMediator mockRound = new MockRoundMediator();
            RoundManager manager = new RoundManager(mockRound);
            // Act
            List<Round> testList = new List<Round>();
            testList.Add(round);


            // Assert
            Assert.NotEqual(testList, manager.GetAll());
        }
        [Fact]
        public void GetRound_CreateRoundAndSearch_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "passw1ord", "testfFirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("te2st@mail.nl", "pass4word", "testfSirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            Round round = new Round(2, 1);
            MockRoundMediator mockRound = new MockRoundMediator();
            round.ID = 1;
            mockRound.Add(round, 1);
            RoundManager manager = new RoundManager(mockRound);
            // Act
            List<Round> testList = new List<Round>();
            testList.Add(round);

            Round testRound = manager.Get(1);

            // Assert
            Assert.Equal(round, testRound);
        }
        [Fact]
        public void GetRound_SearchForNonExistantRound_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "passw1ord", "testfFirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("te2st@mail.nl", "pass4word", "testfSirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);
            Round round = new Round(2, 1);
            MockRoundMediator mockRound = new MockRoundMediator();
            RoundManager manager = new RoundManager(mockRound);
            // Act
            List<Round> testList = new List<Round>();
            Round testRound = manager.Get(1);

            // Assert
            Assert.NotEqual(round, testRound);
        }
    }
}
