using AutoMapper;
using PaciApplication.PaciAppInterface;
using PACIModel.Models;

namespace PaciApplication;

public class PaciApplicationApplicationAutoMapperProfile : Profile
{
    public PaciApplicationApplicationAutoMapperProfile()
    {
        CreateMap<PaciSettings, PacciSettingDTO>();
        CreateMap<PacciSettingDTO, PaciSettings>();
        CreateMap<PaciAplication, PaciiAPPlicationDTO>();
        CreateMap<PaciiAPPlicationDTO, PaciAplication>();
    }
}
