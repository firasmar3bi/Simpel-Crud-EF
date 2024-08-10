using System;
using System.ComponentModel.DataAnnotations;

namespace CrudTaskTwo.Models
{
	public class Order
	{
        public int Id { get; set; }

        public string Adress { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}

