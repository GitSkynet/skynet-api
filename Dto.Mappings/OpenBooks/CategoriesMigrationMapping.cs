using AutoMapper;
using DtoService.OpenBoooks;
using Entities.OpenBooks;

namespace Dto.Mappings.OpenBooks
{
    public class CategoriesMigrationMapping : Profile
    {
        public CategoriesMigrationMapping()
        {
            CreateMap<Category, CategoriesDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.niceName, opts => opts.MapFrom(src => src.NiceName))
                .ForMember(dest => dest.description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.SubCategoryId, opts => opts.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.short_desc, opts => opts.MapFrom(src => src.Short_desc))
                .ForMember(dest => dest.icon, opts => opts.MapFrom(src => src.Icon))
                .ForMember(dest => dest.background, opts => opts.MapFrom(src => src.Background))
                .ForMember(dest => dest.createdAt, opts => opts.MapFrom(src => src.createdAt))
                .ForMember(dest => dest.updatedAt, opts => opts.MapFrom(src => src.updatedAt));
        }
    }
}
