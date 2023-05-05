using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Xunit;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibTest.ManagerUnitTesting
{
    public class UserManagerUnitTests
    {
        [Fact]
        public void AddUser_CreateUserAndSearch_AssertTrue()
        {
            // Arrange
                User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
                List<User> users = new List<User>();
                users.Add(u);

                MockUserMediator mockUserMediator = new MockUserMediator();
                UserManager userManager = new UserManager(mockUserMediator);
            // Act
                userManager.Add(u);
            // Assert
                //Assert.Equal(1, users.Count, userManager.GetAll().Count);
                Assert.Equal(users, userManager.GetAll());
        }

        [Fact]
        public void AddUser_SearchForNonExistentUser_AssertFalse()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<User> users = new List<User>();
            users.Add(u);

            // Act
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Assert
            //Assert.Equal(1, users.Count, userManager.GetAll().Count);
            Assert.NotEqual(users, userManager.GetAll());
        }

        [Fact]
        public void AddUser_CreateFillAndCompareCount_AssertTrue()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<User> users = new List<User>();
            users.Add(u);

            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Act
            userManager.Add(u);
            // Assert
            //Assert.Equal(1, users.Count, userManager.GetAll().Count);
            Assert.Equal(1, userManager.GetAll().Count);
        }

        [Fact]
        public void AddUser_EmtyListCompareCount_AssertFalse()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<User> users = new List<User>();
            users.Add(u);

            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Act
            userManager.Add(u);
            // Assert
            //Assert.Equal(1, users.Count, userManager.GetAll().Count);
            Assert.NotEqual(0, userManager.GetAll().Count);
        }

        [Fact]
        public void GetAll_CreateFillAndCompare_AssertTrue()
        {
            // Arrange
            List<User> users = new List<User>();

            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Act
            List<User> testListUsers = userManager.GetAll();
            // Assert
            Assert.Equal(users, testListUsers);
        }

        [Fact]
        public void GetAll_CreateEmptyAndCompare_AssertFalse()
        {
            // Arrange
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            List<User> users = new List<User>();
            users.Add(u);

            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Act
            List<User> testListUsers = userManager.GetAll();
            // Assert
            Assert.NotEqual(users, testListUsers);
        }

        [Fact]
        public void GetUserByUsername_CreateAndSearchForUser_AssertTrue()
        {
            // Arrange
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            userManager.Add(u);
            // Act
            User testUser = userManager.GetUserEmail("test@mail.nl");
            // Assert
            Assert.Equal(u, testUser);
        }
        [Fact]
        public void GetUserByUsername_SearchForNonExistingUser_AssertFalse()
        {
            // Arrange
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            // Act
            User testUser = userManager.GetUserEmail("test@mail.nl");
            // Assert
            Assert.NotEqual(u, testUser);
        }
        [Fact]
        public void CheckIfUserExists_CreateAndSearchForUser_AssertTrue()
        {
            // Arrange
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            userManager.Add(u);
            // Act
            bool test = userManager.CheckIfUserExists(u);
            // Assert
            Assert.True(test);
        }
        [Fact]
        public void CheckIfUserExists_SearchForNonExistantUser_AssertFalse()
        {
            // Arrange
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Act
            bool test = userManager.CheckIfUserExists(new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser));
            // Assert
            Assert.False(test);
        }
        [Fact]
        public void CheckIfUserCridentials_CreateAndCheckForUser_AssertTrue()
        {
            // Arrange
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            User u = new User("test@mail.nl", "password", "testfirstandLastname", UserRoleEnum.BaseUser);
            userManager.Add(u);
            // Act
            bool test = userManager.CheckIfUserCredentials("test@mail.nl", "password");
            // Assert
            Assert.True(test);
        }
        [Fact]
        public void CheckIfUserCridentials_CheckForNonexistingUser_AssertTrue()
        {
            // Arrange
            MockUserMediator mockUserMediator = new MockUserMediator();
            UserManager userManager = new UserManager(mockUserMediator);
            // Act
            bool test = userManager.CheckIfUserCredentials("test@neemail.nl", "parola");
            // Assert
            Assert.False(test);
        }

    }
}
