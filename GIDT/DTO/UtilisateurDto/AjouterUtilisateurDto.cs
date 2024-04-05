namespace GIDT.DTO.Utilisateur
{
    public class AjouterUtilisateurDto
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public string MotdePass { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public DateTime DateDeCreation { get; set; }
        public DateTime DateDeModification { get; set; }
        public string Role { get; set; }
    }
}
