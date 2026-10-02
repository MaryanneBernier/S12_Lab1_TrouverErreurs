using Microsoft.AspNetCore.Mvc.Rendering;
using Mission.Models;
using System.ComponentModel.DataAnnotations;

namespace Mission.ViewModels
{
    public class Produit_VM
    {

        public int Id { get; set; }

        public Produit? Produit { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; } = DateTime.Now;

        [Range(0, 1000, ErrorMessage = "Le {0} doit être entre {1} et {2}")]
        [DataType(DataType.Currency)]
        public decimal? PrixVente { get; set; }

        public int CategorieId { get; set; }

        public IEnumerable<SelectListItem>? CategorieList { get; set; }


    }
}
