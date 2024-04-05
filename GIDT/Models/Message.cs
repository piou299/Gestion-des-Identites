using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace GIDT.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Contenu { get; set; }
        public DateTime DateDeCreation { get; set; }
        public DateTime DateDeModification { get; set; }
        public bool EstLu { get; set; }
        public Guid UtilisateurId { get; set; }
        [ForeignKey(nameof(UtilisateurId))]
        public Utilisateur Utilisateur { get; set; }
    }
}
