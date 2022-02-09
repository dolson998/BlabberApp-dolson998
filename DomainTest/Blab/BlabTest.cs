using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Domain.Exceptions;
using System;

namespace DomainTest;

[TestClass]
public class BlabTest
{ 
   [TestMethod]
   public void TestInstatiation()
    {

        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        Blab expectedResult = new Blab("string", user);

        // Assert
        Assert.IsInstanceOfType(expectedResult, typeof(Blab), "Hold the Phone");
    }

    [TestMethod]
    public void TestGetId()
    {
        User user = new User("Foo", "Bar", "fbar@abc.com");
        // Arrange
        Blab harness = new Blab("Test", user);
        var expectedResult = typeof(Blab);

        // Act
        Guid? actualResult = harness.GetId();

        // Assert
        Assert.AreNotEqual(actualResult, Guid.Empty);
    }

    [TestMethod]
    public void TestBlabValidationSuccess()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        string content = "Test";

        // Act
        Blab actualResult = new Blab(content, user);

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
    //[ExpectedException(typeof(NotFoundException), "Content is null.")]
    public void TestBlabValidationContentIsNull()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        string content = "Test";

        // Act
        Blab actualResult = new Blab(content, user);
        actualResult.Content = null;

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
    //[ExpectedException(typeof(NotFoundException), "User is null.")]
    public void TestBlabValidationUserIsNull()
    {
        // Arrange
        String content = "Test";
        User user = new User("Foo", "Bar", "fbar@abc.com");

        // Act
        Blab actualResult = new Blab(content ,user);
        actualResult.User = null;

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