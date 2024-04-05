using AutoMapper;
using GIDT.DTO.Utilisateur;
using GIDT.Repository.UtilisateurRepo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GIDT.Services.Utilisateurs.SupprimerUtilisateur
{
    public class SupprimmerUtilisateurCommandHandler : IRequestHandler<SupprimmerUtilisateurCommand>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;
        public SupprimmerUtilisateurCommandHandler(IMapper mmapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mmapper;
            _utilisateurRepository = utilisateurRepository;
        }
        public async Task<Unit> Handle(SupprimmerUtilisateurCommand request, CancellationToken cancellationToken)
        {
             await _utilisateurRepository.DeleteUtilisateurAsync(request.id);
            return Unit.Value;
        }
    }
}
