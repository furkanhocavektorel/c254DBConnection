
namespace generic.util
{
    
    public class ServiceManager<ENTITYCLASS, IDTYPE> : IService<ENTITYCLASS, IDTYPE>
    {

        List<ENTITYCLASS> entities;

        public void delete(ENTITYCLASS entity)
        {
            Console.WriteLine("silindi");

        }

        public ENTITYCLASS getById(IDTYPE id)
        {
            Console.WriteLine("id ye gore getirildi");
            return default;
        }

        public void save(ENTITYCLASS entity)
        {
            entity.deleted = false;
            entity.updateDate = DateTime.Now;
            entities.Add(entity);
            
        }
    }
}
