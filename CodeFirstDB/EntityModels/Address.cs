using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB.EntityModels
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Zip { get; set; }

        public ICollection<Customer> Customers { get; set; }  // Andra halvan av kopplingen från Kundtabellen
    }
}
