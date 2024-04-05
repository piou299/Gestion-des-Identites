using GIDT.DTO.Utilisateur;
using MediatR;

namespace GIDT.Services.Utilisateurs.SupprimerUtilisateur
{
    public class SupprimmerUtilisateurCommand : IRequest
    {
        public Guid id;
        public SupprimmerUtilisateurCommand(Guid id)
        {
            this.id = id;
        }
    }
}
