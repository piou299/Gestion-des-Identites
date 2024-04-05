using AutoMapper;
using GIDT.DTO.Utilisateur;
using GIDT.Models;
using GIDT.Repository.UtilisateurRepo;
using MediatR;

namespace GIDT.Services.Utilisateurs.AjouterUtlisateur
{
    public class AjouterUtilisateurCommandHandler : IRequestHandler<AjouterUtilisateurCommand, AjouterUtilisateurDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;
        public AjouterUtilisateurCommandHandler (IMapper mmapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mmapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<AjouterUtilisateurDto> Handle(AjouterUtilisateurCommand request, CancellationToken cancellationToken)
        {
           var user = _mapper.Map<Utilisateur>(request.Dto);
           await _utilisateurRepository.CreateUtilisateurAsync(user);
           var result =  _mapper.Map<AjouterUtilisateurDto>(user);
           return await Task.FromResult(result);

        }
    }
}
