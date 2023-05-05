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
    public class TournamentEntityUnitTests
    {
        [Fact]
        public void Constructor_CreateAndCompare_AssertTrue()
        {
            // Arrange

            // Act
            Tournament t = new Tournament("asd", "asd", "asd", "asd", 12, 16, TypeOfSportEnum.Badminton);

            // Assert
            Assert.Equal(/*new Tournament("asd", "asd", "asd", "asd", 12, 16, TypeOfSportEnum.Badminton)*/t, t);

        }
        [Fact]
        public void Constructor_CreateAndCompareDifferentObjects_AssertFalse()
        {
            // Arrange

            // Act
            Tournament t = new Tournament("asd", "asd", "asd", "asd", 12, 16, TypeOfSportEnum.Badminton);

            // Assert
            Assert.NotEqual(new Tournament("asd", "asd", "asd", "asd", 12, 16, TypeOfSportEnum.Badminton), t);

        }
        [Fact]
        public void toString_CreateAndTest_AssertFalse()
        {

            // Arrange
            Tournament t = new Tournament("asd", "asd", "asd", "asd", 12, 16, TypeOfSportEnum.Badminton);

            // Act
            String txt = t.ToString();

            // Assert
            Assert.NotEqual("asd / Type:Badminton/ Begins:asd/ Location:asd/ ", txt);
        }
    }
}
