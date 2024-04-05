using AutoMapper;
using GIDT.DTO.Utilisateur;
using GIDT.Models;
using GIDT.Repository.UtilisateurRepo;
using MediatR;

namespace GIDT.Services.Utilisateurs.ModifierUtilisateur
{
    public class ModifierUtilisateurCommandHandler : IRequestHandler<ModifierUtilisateurCommand, ModifierUtilisateurDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;
        public ModifierUtilisateurCommandHandler(IMapper mmapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mmapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<ModifierUtilisateurDto> Handle(ModifierUtilisateurCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Utilisateur>(request.Dto);
            var result = await _utilisateurRepository.UpdateUtilisateurAsync(request.id, user);
            var userMap = _mapper.Map<ModifierUtilisateurDto>(result);
            return userMap;
        }
    }
}
