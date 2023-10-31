using System.ComponentModel.DataAnnotations;

namespace SimpleCommerce.Domain.SeedWorks
{
    public abstract class BaseEntity
    {
        [Key]
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
    }
}
