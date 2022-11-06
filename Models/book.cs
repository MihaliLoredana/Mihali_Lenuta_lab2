using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Mihali_Lenuta_lab2.Models
{
    public class book
    {
        public int ID { get; set; }
        [Display(Name = "book Title")]

        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public System.Security.Policy.Publisher Publisher { get; set; }
    } //navigation property
}
