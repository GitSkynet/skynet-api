using AutoMapper;
using DtoService.OpenBoooks;
using Entities.OpenBooks;

namespace Dto.Mappings.OpenBooks
{
    public class SubCategoriesDBtoSubCategoriesDTO : Profile
    {
        public SubCategoriesDBtoSubCategoriesDTO()
        {
            CreateMap<SubCategory, SubCategoriesDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.niceName, opts => opts.MapFrom(src => src.NiceName))
                .ForMember(dest => dest.icon, opts => opts.MapFrom(src => src.Icon))
                .ForMember(dest => dest.background, opts => opts.MapFrom(src => src.Background))
                .ForMember(dest => dest.createdAt, opts => opts.MapFrom(src => src.createdAt))
                .ForMember(dest => dest.updatedAt, opts => opts.MapFrom(src => src.updatedAt))
                .ForMember(dest => dest.category_ID, opts => opts.MapFrom(src => src.CategoryId));
        }
    }
}
