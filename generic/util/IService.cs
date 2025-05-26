namespace generic.util
{
    public interface IService<ENTITYCLASS, IDTYPE>
    {

        void save(ENTITYCLASS entity);

        void delete(ENTITYCLASS entity);

        ENTITYCLASS getById(IDTYPE id);

    }
}
