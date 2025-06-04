using FirstDBConnection.entity.enums;

namespace FirstDBConnection.entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // ACTIVE,DELETED,PENDING
        public StatusEnam? Status { get; set; } 

    }

}
