using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GIDT.Models
{
    public class Adresse
    {
        [Key]
        public Guid AdresseId { get; set; }
        public string Pays { get; set; }
        public string Region { get; set; }
        public string Ville { get; set; }
        public string AdresseComplete { get; set; }
        public string CodePostal { get; set; }
        public string Telephone { get; set; }
        public string Cellulaire { get; set; }
        public Guid UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public Utilisateur Utilisateur { get; set; }

    }
}
