using GIDT.Datas;
using GIDT.Models;
using GIDT.Repository.UtilisateurRepo;
using Microsoft.EntityFrameworkCore;

namespace GIDT.Repository.UtilisateurRepos
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly ApplicationContext _context;
        public UtilisateurRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
            return utilisateur;
        }

        public async Task<Utilisateur> UpdateUtilisateurAsync(Guid id, Utilisateur utilisateur)
        {
            var existingUtilisateur = await GetUtilisateurByIdAsync(id);

            existingUtilisateur = utilisateur;
            _context.Update(existingUtilisateur);
            await _context.SaveChangesAsync();
            return existingUtilisateur;
        }

        public async Task DeleteUtilisateurAsync(Guid id)
        {
            var utilisateur = await GetUtilisateurByIdAsync(id);
            _context.Remove(utilisateur);
            await _context.SaveChangesAsync();
        }

        public async Task<Utilisateur> GetDetailUtilisateurAsync(Guid id)
        {
            var result = await _context.Utilisateurs
                .Include(u => u.Messages)
                .Include(u => u.Adresses)
                .Include(u => u.Images)
                .SingleOrDefaultAsync(u => u.UtilisateurId == id);
            return result;
        }

        public async Task<ICollection<Utilisateur>> GetAllUtilisateursAsync()
        {
            return await _context.Utilisateurs.ToListAsync();
        }

        public async Task<Utilisateur> GetUtilisateurByIdAsync(Guid id)
        {
            var result = await _context.Utilisateurs
                .SingleOrDefaultAsync(u => u.UtilisateurId == id);
            return result;
        }
    }
}
