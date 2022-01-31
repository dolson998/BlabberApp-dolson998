using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain; 

namespace DomainTest;

[TestClass]
public class UserTest
{
    [TestMethod]
    public void TestUserCreation()
    {
        //Arrange
        var expectedResult = new User();

        //Act
        var actualResult = new User();

        //Assert
        Assert.IsInstanceOfType(actualResult, expectedResult.GetType());
    }

    [TestMethod]
    public void TestGetFirstName()
    {
        //Arrange
        var expectedResult = "Foo";
        var user = new User();
        user.FirstName = "Foo";

        //Act
        var actualResult = user.FirstName;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetLastName()
    {
        //Arrange
        var expectedResult = "Bar";
        var user = new User();
        user.LastName = "Bar";

        //Act
        var actualResult = user.LastName;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetFullName()
    {
        //Arrange
        var expectedResult = "Foo Bar";
        var user = new User();
        user.FirstName = "Foo";
        user.LastName = "Bar";

        //Act
        var actualResult = user.FullName;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetId()
    {
        //Arrange
        var expectedResult = "123abc";
        var user = new User();
        user.Id = "123abc";

        //Act
        var actualResult = user.Id;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetEmail()
    {
        //Arrange
        var expectedResult = "jdoe@abc.com";
        var user = new User();
        user.Email = "jdoe@abc.com";

        //Act
        var acutalResult = user.Email;

        //Assert
        Assert.AreEqual(expectedResult, acutalResult);
    }

    [TestMethod]
    public void TestGetPassword()
    {
        //Arrange
        var expectedResult = "123abc!@#ABC";
        var user = new User();
        user.Password = "123abc!@#ABC";

        //Act
        var actualResult = user.Password;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}