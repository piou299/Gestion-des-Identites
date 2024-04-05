using AutoMapper;
using GIDT.DTO.Adresse;
using GIDT.DTO.Image;
using GIDT.DTO.Message;
using GIDT.DTO.Utilisateur;
using GIDT.Models;

namespace GIDT.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Utilisateur, AjouterUtilisateurDto>().ReverseMap();

            CreateMap<Utilisateur, LireTousLesUtilisateurDto>().ReverseMap();

            CreateMap<Utilisateur, LireDetailUtilisateurDto>().ReverseMap();

            CreateMap<Utilisateur, ModifierUtilisateurDto>().ReverseMap();

            CreateMap<Utilisateur, SupprimerUtilisateurDto>().ReverseMap();

            CreateMap<Message, MessageDto>().ReverseMap();

            CreateMap<Image, ImageDto>().ReverseMap();

            CreateMap<Adresse, AdresseDto>().ReverseMap();

        }
    }
}
