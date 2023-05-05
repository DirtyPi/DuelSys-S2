using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ClassLibrary;
using System.Collections.Generic;
using ClassLibrary.MockDAL;

namespace ClassLibTest.EntityUnitTesting
{
    public class MatchEntityUnitTests
    {
        [Fact]
        public void Constructor_CreateAndCompare_AssertTrue()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);

            // Act
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);

            // Assert
            Assert.Equal(m, m);

        }
        [Fact]
        public void Constructor_CreateAndCompareDifferentObjects_AssertFalse()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);

            // Act
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);

            // Assert
            Assert.NotEqual(new Match(), m);

        }
        [Fact]
        public void GetAllRounds_CreateAndCompareWithExistingRound_AssertTrue()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);

            // Act
            List<Round> testRound = m.GetAllById();

            // Assert
            Assert.Equal(new List<Round>(), testRound);

        }
        [Fact]
        public void GetAllRounds_CreateAndCompareWithNonExistingRound_AssertFalse()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            User u2 = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            Match m = new Match(u, u2, 0, 0, GameStatusEnum.PENDING);

            // Act
            List<Round> testRound = m.GetAllById();
            List<Round> test = new List<Round>();
            test.Add(new Round(21, 24, GameStatusEnum.PENDING));

            // Assert
            Assert.NotEqual(test, testRound);

        }
    }
}
