
using BookMe.BLL.Test.Interface;
using BookMe.DAL;

namespace BookMe.BLL.Interface
{
  public interface IUserService<T>: ICrudService<T> where T:class 
  {

  }
}
