using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStore;
using DataStore.Plugins;
using Domain;
using System;
using DataStore.Exceptions;

namespace DataStoreTest;

[TestClass]
public class InMemRepositoryTest
{
    [TestMethod]
    public void TestInstatiation()
    {
        //Arrange
        InMemRepository inMemRepository = new InMemRepository();

        //Act

        //Assert
        Assert.IsInstanceOfType(inMemRepository, typeof(InMemRepository));
    }

    [TestMethod]
    public void TestAdd()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        Blab blab = new Blab("Test", user);
        InMemRepository inMemRepository = new InMemRepository();

        // Act
        inMemRepository.Add(blab);

        //Assert
        Assert.IsNotNull(inMemRepository.Get(blab));
    }

    [TestMethod]
    public void TestBlabEdit()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        Blab blab = new Blab("Test", user);
        InMemRepository inMemRepository = new InMemRepository();
        inMemRepository.Add(blab);

        // Act
        blab.Content = "Test2";
        inMemRepository.Edit(blab);
        Blab returnedBlab = (Blab)inMemRepository.Get(blab);
        string? actualResult = returnedBlab.Content;

        // Assert
        Assert.AreEqual(blab.Content, actualResult);
    }

    [TestMethod]
    public void TestUserEdit()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        InMemRepository inMemRepository = new InMemRepository();
        inMemRepository.Add(user);

        // Act
        user.Email = "fooBar@abc.com";
        User returnedUser = (User)inMemRepository.Get(user);
        string? actualResult = returnedUser.Email;

        // Assert
        Assert.AreEqual(user.Email, actualResult);
    }

    [TestMethod]
    public void TestDelete()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        Blab blab = new Blab("Test", user);
        InMemRepository inMemRepository = new InMemRepository();
        inMemRepository.Add(blab);

        // Act
        inMemRepository.Delete(blab);

        //Assert
        try
        {
            inMemRepository.Get(blab);
            Assert.Fail();
        }

        catch (NotFoundException)
        {

        }
    }

    [TestMethod]
    public void TestGetSuccess()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        Blab blab = new Blab("Test", user);
        InMemRepository inMemRepository = new InMemRepository();
        inMemRepository.Add(blab);

        // Act
        Blab actualResult = (Blab)inMemRepository.Get(blab);

        //Assert
        Assert.AreEqual(blab, actualResult);
    }

    [TestMethod]
    public void TestGetFail()
    {
        // Arrange
        User user = new User("Foo", "Bar", "fbar@abc.com");
        Blab blab = new Blab("Test", user);
        InMemRepository inMemRepository = new InMemRepository();

        // Act
        
        //Assert
        try
        {
            inMemRepository.Get(blab);
            Assert.Fail();
        }

        catch (NotFoundException)
        {

        }
    }


}