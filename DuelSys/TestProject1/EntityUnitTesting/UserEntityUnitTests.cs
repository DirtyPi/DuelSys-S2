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
    public class UserEntityUnitTests
    {
        [Fact]
        public void Constructor_CreateAndCompare_AssertTrue()
        {
            // Arrange

            // Act
            User u = new User("ASD", "ASD", "ASD", UserRoleEnum.BaseUser);
            // Assert
            Assert.Equal(u, u);

        }
        [Fact]
        public void Constructor_CreateAndCompareDifferentObjects_AssertFalse()
        {
            // Arrange

            // Act
            User u = new User("ASD", "ASD", "ASD", UserRoleEnum.BaseUser);
            // Assert
            Assert.NotEqual(new User("AD", "SD", "SD", UserRoleEnum.BaseUser), u);

        }
    }
}
