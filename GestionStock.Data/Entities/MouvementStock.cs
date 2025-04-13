using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace GestionStock.Data.Entities
{
    public class MouvementStock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Produit")]
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }
        [Required]
        public int Quantite { get; set; }
        public DateTime DateMouvement { get; set; }
        public string TypeMouvement { get; set; } = "Entrée";
    }
}
