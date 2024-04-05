using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace GIDT.Models
{
    public class Image
    {
        [Key]
        public Guid ImageID { get; set; }
        [Column(TypeName = "varbinary(MAX)")]
        public byte[] imageBlob { get; set; }
        public bool EstProfil { get; set; }
        public bool EstPrincipal { get; set; }
        public Guid UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public Utilisateur Utilisateur { get; set; }
    }
}
