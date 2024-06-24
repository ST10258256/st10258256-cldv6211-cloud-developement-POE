using static KhumaloCraft.Models.Product;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    [Table("Category")]
    public class Category
    {

            public int Id { get; set; }

            [Required]
            [MaxLength(40)]
            public string CategoryName { get; set; }
            public List<Product> Product { get; set; }
        
    }
}
