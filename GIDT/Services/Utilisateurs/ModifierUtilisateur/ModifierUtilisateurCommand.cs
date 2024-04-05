using GIDT.DTO.Utilisateur;
using MediatR;

namespace GIDT.Services.Utilisateurs.ModifierUtilisateur
{
    public class ModifierUtilisateurCommand : IRequest<ModifierUtilisateurDto>
    {
        public Guid id { get; }
        public AjouterUtilisateurDto Dto { get; set; }
        public ModifierUtilisateurCommand(Guid id, AjouterUtilisateurDto dto)
        {
            this.id = id;
            Dto = dto;
        }

    }
}
