using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest;

[TestClass]
public class BlabTest
{
    [TestMethod]
    public void TestGetId()
    {
        //Arrange
        var expectedResult = "123abc";
        var blab = new Blab();
        blab.Id = "123abc";

        //Act
        var actualResult = blab.Id;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetMessage()
    {
        //Arrange
        var expectedResult = "This is a message.";
        var blab = new Blab();
        blab.Message = "This is a message.";

        //Act
        var actualResult = blab.Message;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetMediaReference()
    {
        //Arrange
        var expectedResult = "123abc";
        var blab = new Blab();
        blab.MediaReference = "123abc";

        //Act
        var actualResult = blab.MediaReference;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetUserReference()
    {
        //Arrange
        var expectedResult = "123abc";
        var blab = new Blab();
        blab.UserReference = "123abc";

        //Act
        var actualResult = blab.UserReference;

        //Assert
        Assert.AreEqual(expectedResult,actualResult);
    }

    [TestMethod]
    public void TestGetHashtagReference()
    {
        //Arrange
        var expectedResult = "123abc";
        var blab = new Blab();
        blab.HashtagReference = "123abc";

        //Act
        var actualResult = blab.HashtagReference;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}