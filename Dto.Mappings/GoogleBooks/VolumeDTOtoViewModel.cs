// VolumeDTOtoViewModel
using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using DtoService.GoogleBooks;

namespace Dto.Mappings.GoogleBooks
{
    public class VolumeDTOtoViewModel : Profile
    {
        public VolumeDTOtoViewModel()
        {
            CreateMap<VolumeDTO, GoogleBooksVolumeViewModel>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.Author, opts => opts.MapFrom(src => src.Author))
                .ForMember(dest => dest.Publisher, opts => opts.MapFrom(src => src.Publisher))
                .ForMember(dest => dest.PublishedDate, opts => opts.MapFrom(src => src.PublishedDate))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.Country, opts => opts.MapFrom(src => src.Country))
                .ForMember(dest => dest.Viewability, opts => opts.MapFrom(src => src.Viewability))
                .ForMember(dest => dest.WebReaderLink, opts => opts.MapFrom(src => src.WebReaderLink))
                .ForMember(dest => dest.AccessViewStatus, opts => opts.MapFrom(src => src.AccessViewStatus))
                .ForMember(dest => dest.IsAvailableEPUB, opts => opts.MapFrom(src => src.IsAvailableEPUB))
                .ForMember(dest => dest.EPUBDownloadLink, opts => opts.MapFrom(src => src.EPUBDownloadLink))
                .ForMember(dest => dest.IsAvailablePDF, opts => opts.MapFrom(src => src.IsAvailablePDF))
                .ForMember(dest => dest.PDFDownloadLink, opts => opts.MapFrom(src => src.PDFDownloadLink))
                .ForMember(dest => dest.PageCount, opts => opts.MapFrom(src => src.PageCount))
                .ForMember(dest => dest.Language, opts => opts.MapFrom(src => src.Language))
                .ForMember(dest => dest.PreviewLink, opts => opts.MapFrom(src => src.PreviewLink))
                .ForMember(dest => dest.InfoLink, opts => opts.MapFrom(src => src.InfoLink))
                .ForMember(dest => dest.CanonicalVolumeLink, opts => opts.MapFrom(src => src.CanonicalVolumeLink))
                .ForMember(dest => dest.Image, opts => opts.MapFrom(src => src.Image))
                .ForMember(dest => dest.Thumbnail, opts => opts.MapFrom(src => src.Thumbnail))
                .ForMember(dest => dest.BuyLink, opts => opts.MapFrom(src => src.BuyLink));
            CreateMap<GoogleBooksVolumeViewModel, VolumeDTO>();
        }
    }
}


