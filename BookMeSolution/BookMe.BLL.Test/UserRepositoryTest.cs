using BookMe.BLL.Test.Fake.Repository;
using BookMe.DAL;
using BookMe.DAL.Repository;
using NUnit.Framework;

namespace BookMe.BLL.Test
{
  [TestFixture]
  public class UserRepositoryTest
  {
    private IRepository<User> _repository;
    [SetUp]
    public void Init()
    {
      _repository = new FakeUserRepository();
    }
    [Test]
    public void FindAllShouldReturnListOfUsers()
    {
      var users = _repository.FindAll();

      Assert.IsTrue(users.Length>0);
      
    }
  }
}
