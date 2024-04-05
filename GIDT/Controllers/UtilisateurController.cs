using GIDT.DTO.Utilisateur;
using GIDT.Services.Utilisateurs.AjouterUtlisateur;
using GIDT.Services.Utilisateurs.DetailUtilisateur;
using GIDT.Services.Utilisateurs.ListerUtilisateur;
using GIDT.Services.Utilisateurs.ModifierUtilisateur;
using GIDT.Services.Utilisateurs.SupprimerUtilisateur;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GIDT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
       private readonly IMediator _mediator;
        public UtilisateurController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<AjouterUtilisateurDto>> AjouterUnUtilisateur (AjouterUtilisateurDto request)
        {
            AjouterUtilisateurCommand command = new AjouterUtilisateurCommand()
            {
                Dto = request
            };
           await _mediator.Send(command);
            return Ok(command);
        } 

        [HttpGet]
        public async Task <ActionResult­<IEnumerable<LireTousLesUtilisateurDto>>> LireTousLesUtilisateur ()
        {
           var result = await _mediator.Send(new LireTousLesUtilisateurQuery());
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("detail/id")]
        public async Task<ActionResult<LireDetailUtilisateurDto>> LireDetailUtilisateur(Guid id)
        {
           var result = await _mediator.Send(new LireDetailUtilisateurQuery(id));
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ModifierUtilisateurDto>> ModifierUnUtilisateur(Guid id, AjouterUtilisateurDto userDto)
        {
            var user = await _mediator.Send(new ModifierUtilisateurCommand(id, userDto) { Dto = userDto});
            return user != null ? Ok(user) : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimmerUnUtilisateur(Guid id)
        {
            await _mediator.Send(new SupprimmerUtilisateurCommand(id));
            Redirect(nameof(LireTousLesUtilisateur));
            return Ok(new { message = "Utlisateur supprimer" });

        }
    }
}
