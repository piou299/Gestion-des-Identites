using AutoMapper;
using GIDT.DTO.Utilisateur;
using GIDT.Repository.UtilisateurRepo;
using MediatR;
using SimpleSoft.Mediator;

namespace GIDT.Services.Utilisateurs.ListerUtilisateur
{
    public class LireTousLesUtilisateurQueryHandler : IRequestHandler<LireTousLesUtilisateurQuery, IEnumerable<LireTousLesUtilisateurDto>>
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IMapper _mapper;
        public LireTousLesUtilisateurQueryHandler(IMapper mmapper, IUtilisateurRepository utilisateurRepository)
        {
            _mapper = mmapper;
            _utilisateurRepository = utilisateurRepository;
        }

        public async Task<IEnumerable<LireTousLesUtilisateurDto>> Handle(LireTousLesUtilisateurQuery request, CancellationToken cancellationToken)
        {
            var ListUser = await _utilisateurRepository.GetAllUtilisateursAsync();
            var userMap = _mapper.Map<IEnumerable<LireTousLesUtilisateurDto>>(ListUser);
            return userMap;
        }

        //public async Task<IEnumerable<LireTousLesUtilisateurDto>> HandleAsync(LireTousLesUtilisateurQuery query, CancellationToken ct)
        //{
        //    var ListUser = await _utilisateurRepository.GetAllUtilisateursAsync();
        //    var userMap = _mapper.Map<IEnumerable<LireTousLesUtilisateurDto>>(ListUser);
        //    return userMap;
        //}
    }
}
