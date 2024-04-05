using System.ComponentModel.DataAnnotations;

namespace GIDT.Models
{
    public class Utilisateur
    {
        [Key]
        public Guid UtilisateurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public string MotdePass { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public DateTime DateDeCreation { get; set; }
        public DateTime DateDeModification { get; set; }
        public DateTime DateDerniereConnexion { get; set; }
        public string Role { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Adresse> Adresses { get; set; }
    }
}
