using AutoMapper;
using DtoService.GoogleBooks;
using Entities.GoogleBooks;

namespace Dto.Mappings.GoogleBooks
{
    public class VolumeGoogleBooksMapping : Profile
    {
        public VolumeGoogleBooksMapping()
        {
            CreateMap<GoogleBooksEntityVolume, VolumeDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.VolumeInfo.Title))
                .ForMember(dest => dest.Author, opts => opts.MapFrom(src => src.VolumeInfo.Authors[0] != null ? src.VolumeInfo.Authors[0] : "No author added yet"))
                .ForMember(dest => dest.Publisher, opts => opts.MapFrom(src => src.VolumeInfo.Publisher))
                .ForMember(dest => dest.PublishedDate, opts => opts.MapFrom(src => src.VolumeInfo.PublishedDate))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.VolumeInfo.Description))
                .ForMember(dest => dest.Country, opts => opts.MapFrom(src => src.AccessInfo.Country))
                .ForMember(dest => dest.Viewability, opts => opts.MapFrom(src => src.AccessInfo.Viewability))
                .ForMember(dest => dest.WebReaderLink, opts => opts.MapFrom(src => src.AccessInfo.WebReaderLink))
                .ForMember(dest => dest.AccessViewStatus, opts => opts.MapFrom(src => src.AccessInfo.AccessViewStatus))
                .ForMember(dest => dest.IsAvailableEPUB, opts => opts.MapFrom(src => src.AccessInfo.Epub.IsAvailable))
                .ForMember(dest => dest.EPUBDownloadLink, opts => opts.MapFrom(src => src.AccessInfo.Epub))
                .ForMember(dest => dest.IsAvailablePDF, opts => opts.MapFrom(src => src.AccessInfo.Pdf.IsAvailable))
                .ForMember(dest => dest.PDFDownloadLink, opts => opts.MapFrom(src => src.AccessInfo.Pdf.DownloadLink))
                .ForMember(dest => dest.PageCount, opts => opts.MapFrom(src => src.VolumeInfo.PageCount))
                .ForMember(dest => dest.Language, opts => opts.MapFrom(src => src.VolumeInfo.Language))
                .ForMember(dest => dest.PreviewLink, opts => opts.MapFrom(src => src.VolumeInfo.PreviewLink))
                .ForMember(dest => dest.InfoLink, opts => opts.MapFrom(src => src.VolumeInfo.InfoLink))
                .ForMember(dest => dest.CanonicalVolumeLink, opts => opts.MapFrom(src => src.VolumeInfo.CanonicalVolumeLink))
                .ForMember(dest => dest.Image, opts => opts.MapFrom(src => src.VolumeInfo.ImageLinks.Medium))
                .ForMember(dest => dest.Thumbnail, opts => opts.MapFrom(src => src.VolumeInfo.ImageLinks.Thumbnail))
                .ForMember(dest => dest.BuyLink, opts => opts.MapFrom(src => src.SaleInfo.BuyLink));
            CreateMap<VolumeDTO, GoogleBooksEntityVolume>();
        }
    }
}
