using AutoMapper;
using PRN231.Dto;
using PRN231.Models;

namespace PRN231.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Symptom, SymptonDto>();
            CreateMap<SymptonDto, Symptom>();
           /* CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();*/
            /*CreateMap<Fertilizer, FertilizerDto>();
            CreateMap<FertilizerDto, Fertilizer>();
            CreateMap<MedicineDto, Medicine>();
            CreateMap<Medicine, MedicineDto>();
            CreateMap<TreatmentDto, Treatment>();
            CreateMap<Treatment, TreatmentDto>();
            CreateMap<Preventative, PreventativeDto>();
            CreateMap<PreventativeDto, Preventative>();*/
        }
    }
}
