﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static KhumaloCraft.Models.Product;

namespace KhumaloCraft.Models
{
    [Table("OrderDetail")]

    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
