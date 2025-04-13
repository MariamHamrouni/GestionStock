using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GestionStock.Data.Entities
{
    public class Produit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public decimal Prix { get; set; }

        [ForeignKey("Categories")]
        public int CategorieId { get; set; }
        public Categories Categorie { get; set; }

        public List<MouvementStock> MouvementsStock { get; set; }
    }
}
