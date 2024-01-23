using AutoMapper;
using DtoService.OpenBoooks;
using Entities.OpenBooks;

namespace Dto.Mappings.OpenBooks
{
    public class BooksMigrationMapping : Profile
    {
        public BooksMigrationMapping()
        {
            CreateMap<Book, BooksDTO>()
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.IdOpenlibra))
                .ForMember(dest => dest.CategoryID, opts => opts.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.SubcategoryID, opts => opts.MapFrom(src => src.SubCategoryId))
                .ForMember(dest => dest.Authors, opts => opts.MapFrom(src => src.Authors))
                .ForMember(dest => dest.Content, opts => opts.MapFrom(src => src.Content))
                .ForMember(dest => dest.ContentShort, opts => opts.MapFrom(src => src.Content_short))
                .ForMember(dest => dest.Publisher, opts => opts.MapFrom(src => src.Publisher))
                .ForMember(dest => dest.PublisherDate, opts => opts.MapFrom(src => src.PublisherDate))
                .ForMember(dest => dest.Pages, opts => opts.MapFrom(src => src.Pages))
                .ForMember(dest => dest.Language, opts => opts.MapFrom(src => src.Language))
                .ForMember(dest => dest.URLDetails, opts => opts.MapFrom(src => src.UrlDetails))
                .ForMember(dest => dest.URLDownload, opts => opts.MapFrom(src => src.UrlDownload))
                .ForMember(dest => dest.Cover, opts => opts.MapFrom(src => src.Cover))
                .ForMember(dest => dest.Thumbnail, opts => opts.MapFrom(src => src.Thumbnail))
                .ForMember(dest => dest.NumComments, opts => opts.MapFrom(src => src.NumComments))
                .ForMember(dest => dest.Tags, opts => opts.MapFrom(src => src.Tags))
                .ForMember(dest => dest.Categories, opts => opts.MapFrom(src => src.Categories))
                .ForMember(dest => dest.SubCategories, opts => opts.MapFrom(src => src.SubCategories));
        }
    }
}
