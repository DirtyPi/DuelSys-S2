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
    public class RountEntityUnitTests
    {
        [Fact]
        public void Constructor_CreateAndCompare_AssertTrue()
        {
            // Arrange

            // Act
            Round r = new Round(24,28, GameStatusEnum.PENDING);

            // Assert
            Assert.Equal(/*new Round(24, 28, GameStatusEnum.PENDING)*/r, r);

        }
        [Fact]
        public void Constructor_CreateAndCompareDifferentObjects_AssertFalse()
        {
            // Arrange

            // Act
            Round r = new Round(24, 28, GameStatusEnum.PENDING);

            // Assert
            Assert.NotEqual(new Round(), r);

        }
        [Fact]
        public void FindWinner_Compare_AssertTrue()
        {
            // Arrange
            Round r = new Round();

            // Act
            int test = r.FindWinner(21, 16);

            // Assert
            Assert.Equal(1, test);

        }
        [Fact]
        public void FindWinner_Compare_AssertEquals()
        {
            // Arrange
            Round r = new Round();

            // Act
            int test = r.FindWinner(21, 21);

            // Assert
            Assert.Equal(0, test);

        }
        [Fact]
        public void FindWinner_Compare_AssertFalse()
        {
            // Arrange
            Round r = new Round();

            // Act
            int test = r.FindWinner(16, 21);

            // Assert
            Assert.Equal(2, test);

        }

    }
}
