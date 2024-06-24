using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models.Display
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string STerm { get; set; } = "";
        public int CategpryId { get; set; } = 0;
    }

}
