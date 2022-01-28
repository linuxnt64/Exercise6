using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB.EntityModels
{
  public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string? Mail { get; set; }

        public string? Phone { get; set; }

        public int? AddressId { get; set; }

        public Address Address { get; set; }  // En halvan av kopplingen till Adresstabellen
    }
}
