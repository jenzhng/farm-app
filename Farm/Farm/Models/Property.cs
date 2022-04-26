using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farm.Models
{
    public class Property
    {
        public int PropertyId { get; set; } 

        public string Title { get; set; }

       [DisplayFormat(DataFormatString = "{0:N2}")]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Cost { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Acre { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; } 

        public int ZipCode { get; set; }
        public ICollection<Register> Registers { get; set; } 
    }
}
