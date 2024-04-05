using GIDT.DTO.Utilisateur;
using GIDT.Models;
using MediatR;
using SimpleSoft.Mediator;

namespace GIDT.Services.Utilisateurs.ListerUtilisateur
{
    public class LireTousLesUtilisateurQuery : IRequest<IEnumerable<LireTousLesUtilisateurDto>>
    {
    }
}
