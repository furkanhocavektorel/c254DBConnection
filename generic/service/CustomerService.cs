using generic.entity;

namespace generic.service
{
    internal class CustomerService : ICustomerService
    {

        public void save(Customer entity)
        {
            Console.WriteLine("save edildi");
        }
        public void delete(Customer entity)
        {
            Console.WriteLine("silindi ");
        }

        public Customer getById(long id)
        {
            Console.WriteLine("bilgi");
            return new Customer();
        }


    }
}
