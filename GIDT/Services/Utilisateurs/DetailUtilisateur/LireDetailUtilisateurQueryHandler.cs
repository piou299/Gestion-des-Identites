using AutoMapper;
using GIDT.DTO.Utilisateur;
using GIDT.Repository.UtilisateurRepo;
using MediatR;
using MediatR.Pipeline;

namespace GIDT.Services.Utilisateurs.DetailUtilisateur
{
    public class LireDetailUtilisateurQueryHandler : IRequestHandler<LireDetailUtilisateurQuery, LireDetailUtilisateurDto>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;
        public LireDetailUtilisateurQueryHandler(IMapper mmapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mmapper;
            _utilisateurRepository = utilisateurRepository;
        }

        public async Task<LireDetailUtilisateurDto> Handle(LireDetailUtilisateurQuery request, CancellationToken cancellationToken)
        {
            var detailUser = await _utilisateurRepository.GetDetailUtilisateurAsync(request.id);
            var detailMap = _mapper.Map<LireDetailUtilisateurDto>(detailUser);
            return detailMap;
        }
    }
}
