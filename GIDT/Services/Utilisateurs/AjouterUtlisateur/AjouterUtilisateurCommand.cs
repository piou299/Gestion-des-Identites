using GIDT.DTO.Utilisateur;
using MediatR;

namespace GIDT.Services.Utilisateurs.AjouterUtlisateur
{
    public class AjouterUtilisateurCommand : IRequest<AjouterUtilisateurDto>
    {
        public AjouterUtilisateurDto Dto { get; set; }
    }
}
