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
    public class ParticipatingEntityUnitTests
    {
        [Fact]
        public void Constructor_CreateAndCompare_AssertTrue()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("ASD", "ASD", "ASD", UserRoleEnum.BaseUser);

            // Act
            Participating p = new Participating(t, u);
            
            // Assert
            Assert.Equal(p, p);

        }
        [Fact]
        public void Constructor_CreateAndCompareDifferentObjects_AssertFalse()
        {
            // Arrange
            Tournament t = new Tournament("12/08/2022", "14/08/2022", "Eindhoven", "Description test", 12, 2, TypeOfSportEnum.Badminton);
            User u = new User("ASD", "ASD", "ASD", UserRoleEnum.BaseUser);

            // Act
            Participating p = new Participating(t, u);

            // Assert
            Assert.NotEqual(new Participating(), p);

        }
    }
}
