using System;
using Rhino.Mocks;
using NUnit.Framework;

namespace BookMe.BLL.Test
{
  [TestFixture]
  public class UserServiceTest
  {
   // private IUserService<User> _service;
    [SetUp]
    public void Initialise()
    {
      
    }

    public void CreateUserShouldReturnAnIntegerRepresentingTheUserId()
    {
      //int userId = _service.Create(User);

      //Assert.IsTrue(userId>0);
    }
  }
}
