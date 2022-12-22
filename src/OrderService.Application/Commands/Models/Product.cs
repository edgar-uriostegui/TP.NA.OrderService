using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Commands.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }
    }
}