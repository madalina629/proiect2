using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proiect2.Models
{
    public class Food
    {
        public int ID { get; set; }

        [Display(Name = "Marca Produs")]
        public string Denumire { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        public DateTime PublishingDate { get; set; }

    }
}
