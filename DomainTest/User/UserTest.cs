using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Domain.Exceptions;
using System;

namespace DomainTest;

[TestClass]
public class UserTest
{
    [TestMethod]
    public void TestUserCreation()
    {
        //Arrange
        var expectedResult = new User("Foo", "Bar", "fbar@abc.com");

        //Act
        var actualResult = new User("Foo", "Bar", "fbar@abc.com");

        //Assert
        Assert.IsInstanceOfType(actualResult, expectedResult.GetType());
    }

    [TestMethod]
    public void TestGetId()
    {

        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        var expectedResult = typeof(User);

        // Act
        Guid? actualResult = user.GetId();

        // Assert
        Assert.AreNotEqual(actualResult, Guid.Empty);
    }

    [TestMethod]
    public void TestFirstName()
    {
        // Arrange
        var expectedResult = "Foo";
        var user = new User("Foo", "Bar","fbar@abc.com");

        // Act
        var actualResult = user.FirstName;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestLastName()
    {
        // Arrange
        var expectedResult = "Bar";
        var user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        var actualResult = user.LastName;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestFullName()
    {
        // Arrange
        var expectedResult = "Foo Bar";
        var user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        var actualResult = user.FullName;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestFullNameLastFirst()
    {
        // Arrange
        var expectedResult = "Bar, Foo";
        var user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        var actualResult = user.FullNameLastFirst;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetFullNameFirstLast()
    {
        // Arrange
        var expectedResult = "Foo Bar";
        var user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        var actualResult = user.GetFullNameFirstLast();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetFullNameLastFirst()
    {
        // Arrange
        var expectedResult = "Bar, Foo";
        var user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        var actualResult = user.GetFullNameLastFirst();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestUserValidationSuccess()
    {
        // Arrange & Act
        User actualResult = new User("Foo", "Bar", "fbar@abc.com");

        // Assert
        try
        {
            actualResult.Validate();
        }
        catch (NotFoundException)
        {
            Assert.Fail();
        }
    }

    [TestMethod]
    public void TestUserValidationFirstNameNull()
    {
        // Arrange
        User actualResult = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        actualResult.FirstName = null;

        // Assert
        try
        {
            actualResult.Validate();
            Assert.Fail();
        }
        catch (NotFoundException)
        {
            
        }
    }

    [TestMethod]
    public void TestUserValidationLastNameNull()
    {
        // Arrange
        User actualResult = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        actualResult.LastName = null;

        // Assert
        try
        {
            actualResult.Validate();
            Assert.Fail();
        }
        catch (NotFoundException)
        {

        }
    }

    [TestMethod]
    public void TestUserValidationEmailNull()
    {
        // Arrange
        User actualResult = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        actualResult.Email = null;

        // Assert
        try
        {
            actualResult.Validate();
            Assert.Fail();
        }
        catch (NotFoundException)
        {

        }
    }
}