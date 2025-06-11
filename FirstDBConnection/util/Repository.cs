

using FirstDBConnection.context;

namespace FirstDBConnection.util
{
    public class Repository<T, ID> : IRepository<T, ID>
    {
        HepsiSuradaContext context;
        public Repository()
        {
            context = new HepsiSuradaContext();
        }
        public List<T> GetAll()
        {
            return default;
        }

        public T GetById(ID id)
        {
            return default;
        }

        public T Save(T entity)
        {
            var a=context.Add(entity).Entity;
            context.SaveChanges();
            return (T)a;
        }



    }
}
