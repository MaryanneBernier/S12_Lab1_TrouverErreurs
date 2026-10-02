using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La {0} doit contenir entre {1} et {2} caractères.")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; } = DateTime.Now;
        [Range(0, 1000, ErrorMessage = "Le {0} doit être entre {1} et {2}")]
        [DataType(DataType.Currency)]
        public decimal? PrixVente { get; set; }
        [ForeignKey("Categorie")]
        public int CategorieId { get; set; }


        public Categorie? Categorie { get; set; }


    }
}
