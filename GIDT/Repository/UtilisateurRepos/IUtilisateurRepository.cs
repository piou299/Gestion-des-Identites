using GIDT.Models;

namespace GIDT.Repository.UtilisateurRepo
{
    public interface IUtilisateurRepository
    {
        public Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur);
        public Task<Utilisateur> UpdateUtilisateurAsync(Guid id, Utilisateur utilisateur);
        public Task<Utilisateur> GetDetailUtilisateurAsync(Guid id);
        public Task DeleteUtilisateurAsync(Guid id);
        public Task<Utilisateur> GetUtilisateurByIdAsync(Guid id);
        public Task<ICollection<Utilisateur>> GetAllUtilisateursAsync();
    }
}
