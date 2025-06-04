namespace FirstDBConnection.util
{
    public interface IRepository<T, ID>
    {
        T Save(T entity);

        List<T> GetAll();

        T GetById(ID id);

    }
}
