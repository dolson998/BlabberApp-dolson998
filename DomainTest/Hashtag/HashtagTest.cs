using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest;

[TestClass]
public class HashtagTest
{
    [TestMethod]
    public void TestGetId()
    {
        //Arrange
        var expectedResult = "123abc";
        var hashtag = new Hashtag();
        hashtag.Id = "123abc";

        //Act
        var actualResult = hashtag.Id;

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestGetTagName()
    {
        //Arrange
        var expectedResult = "123abc";
        var hashtag = new Hashtag();
        hashtag.TagName = "123abc";

        //Act
        var acutalResult = hashtag.TagName;

        //Assert
        Assert.AreEqual(acutalResult, expectedResult);
    }
}
