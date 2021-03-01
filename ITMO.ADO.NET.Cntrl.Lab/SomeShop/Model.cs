using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SomeShop
{
    public class Model
    {
        public class Client
        {

            public int ClientId { get; set; }

            [Required]
            [MaxLength(30)]
            public string FirstName { get; set; }
            public string LastName { get; set; }

            [Required]
            public DateTime BirthDay { get; set; }

            [Required]
            [MaxLength(200)]
            public string Address { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [MaxLength(12)]
            public string Phone { get; set; }
            public override string ToString()
            {
                string s = FirstName + " " + LastName + ", " + BirthDay.ToString("d") + ", тел.: " + Phone;
                return s;
            }
            // Ссылка на заказы
            public virtual List<Order> Orders { get; set; }
            public Client()
            {
                Orders = new List<Order>();
            }
        }
        public class Order
        {
            public int OrderId { get; set; }

            [Required]
            public string ProductName { get; set; }

            [Required]
            [Range(1, 10000)]
            public int Quantity { get; set; }

            [Required]
            public DateTime OrderDate { get; set; }

            [Required]
            public string Delivery { get; set; }

            [Required]
            public string Payment { get; set; }

            public Client Client { get; set; }
            public override string ToString()
            {
                string s = ProductName + " " + Quantity + "шт., дата: " + OrderDate;
                return s;
            }

        }
    }
}
