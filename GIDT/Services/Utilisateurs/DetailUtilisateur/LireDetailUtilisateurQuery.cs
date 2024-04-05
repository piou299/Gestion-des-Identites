using GIDT.DTO.Utilisateur;
using GIDT.Models;
using MediatR;

namespace GIDT.Services.Utilisateurs.DetailUtilisateur
{
    public class LireDetailUtilisateurQuery : IRequest<LireDetailUtilisateurDto>
    {
        public Guid id;
        public LireDetailUtilisateurQuery(Guid id)
        {
            this.id = id;
        }
    }
}
