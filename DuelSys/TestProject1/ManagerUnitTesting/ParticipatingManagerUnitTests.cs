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
    public class ParticipatingManagerUnitTests
    {
        [Fact]
        public void GetAllParticipating_CreateAndCompareListsOfParticipating_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            Participating p = new Participating(t, u, 0, 0, 0);
            List<Participating> parts = new List<Participating>();
            parts.Add(p);
            MockParticiplatingMediator mockParticiplatingMediator = new MockParticiplatingMediator();
            mockParticiplatingMediator.Add(p);
            ParticipatingManager manager = new ParticipatingManager(mockParticiplatingMediator);

            // Act
            List<Participating> testPart = manager.GetAll();


            // Assert
            Assert.Equal(parts, testPart);
        }
        [Fact]
        public void GetAllParticipating_CompareListsOfParticipating_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            Participating p = new Participating(t, u, 0, 0, 0);
            List<Participating> parts = new List<Participating>();
            MockParticiplatingMediator mockParticiplatingMediator = new MockParticiplatingMediator();
            mockParticiplatingMediator.Add(p);
            ParticipatingManager manager = new ParticipatingManager(mockParticiplatingMediator);

            // Act
            List<Participating> testPart = manager.GetAll();


            // Assert
            Assert.NotEqual(parts, testPart);
        }
        [Fact]
        public void GetAllParticipatingByPlayerID_CreateAndSearchListsOfParticipating_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            u.Id = 1;
            Participating p = new Participating(t, u, 0, 0, 0);
            List<Participating> parts = new List<Participating>();
            parts.Add(p);
            MockParticiplatingMediator mockParticiplatingMediator = new MockParticiplatingMediator();
            mockParticiplatingMediator.Add(p);
            ParticipatingManager manager = new ParticipatingManager(mockParticiplatingMediator);

            // Act
            List<Participating> testPart = manager.GetAllByPlayerID(1);


            // Assert
            Assert.Equal(parts, testPart);
        }
        [Fact]
        public void GetAllParticipatingByPlayerID_SearchListsOfParticipatingForNonExistantPlayer_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            u.Id = 2;
            Participating p = new Participating(t, u, 0, 0, 0);
            List<Participating> parts = new List<Participating>();
            parts.Add(p);
            MockParticiplatingMediator mockParticiplatingMediator = new MockParticiplatingMediator();
            mockParticiplatingMediator.Add(p);
            ParticipatingManager manager = new ParticipatingManager(mockParticiplatingMediator);

            // Act
            List<Participating> testPart = manager.GetAllByPlayerID(1);


            // Assert
            Assert.NotEqual(parts, testPart);
        }
    }
}
