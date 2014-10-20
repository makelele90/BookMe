namespace BookMe.BLL.Test.Interface
{
  public interface ICrudService<T> where T:class 
  {
    int Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    T Find(int id);
    T[] FindAll();

  }
}
