namespace MvcGiris.entity
{
    public class BaseEntity
    {
      
        public long code { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
