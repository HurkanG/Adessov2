using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class User
	{
        [Key]
        public int UserId { get; set; }
        public string NameSurname { get; set; }
        public string EPosta { get; set; }
        public string Password { get; set; }

    }
}

