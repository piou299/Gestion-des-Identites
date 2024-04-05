
using GIDT.DTO.Adresse;
using GIDT.DTO.Image;
using GIDT.DTO.Message;

namespace GIDT.DTO.Utilisateur
{
    public class LireDetailUtilisateurDto
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public ICollection<MessageDto> Messages { get; set; }
        public ICollection<ImageDto> Images { get; set; }
        public ICollection<AdresseDto> Adresses { get; set; }
    }
}
