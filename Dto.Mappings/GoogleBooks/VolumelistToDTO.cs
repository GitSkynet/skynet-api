using AutoMapper;
using DtoService.GoogleBooks;
using Entities.GoogleBooks;

namespace Dto.Mappings.GoogleBooks
{
    public class VolumelistToDTOMapping : Profile
    {
        public VolumelistToDTOMapping()
        {

            CreateMap<VolumeList, Item>()
                .ForMember(dest => dest.Kind, opts => opts.MapFrom(src => src.Kind))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Etag, opts => opts.MapFrom(src => src.Etag))
                .ForMember(dest => dest.SelfLink, opts => opts.MapFrom(src => src.SelfLink));
                CreateMap<VolumeInfoVolumeList, VolumeInfoDTO>()
                    .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                    .ForMember(dest => dest.Authors, opts => opts.MapFrom(src => src.Authors != null ? src.Authors[0] : "No author added"))
                    .ForMember(dest => dest.Publisher, opts => opts.MapFrom(src => src.Publisher))
                    .ForMember(dest => dest.PublishedDate, opts => opts.MapFrom(src => src.PublishedDate))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.PageCount, opts => opts.MapFrom(src => src.PageCount))
                    .ForMember(dest => dest.PrintType, opts => opts.MapFrom(src => src.PrintType))
                    .ForMember(dest => dest.Categories, opts => opts.MapFrom(src => src.Categories))
                    .ForMember(dest => dest.MaturityRating, opts => opts.MapFrom(src => src.MaturityRating))
                    .ForMember(dest => dest.AllowAnonLogging, opts => opts.MapFrom(src => src.AllowAnonLogging))
                    .ForMember(dest => dest.ContentVersion, opts => opts.MapFrom(src => src.ContentVersion))
                    .ForMember(dest => dest.Language, opts => opts.MapFrom(src => src.Language))
                    .ForMember(dest => dest.PreviewLink, opts => opts.MapFrom(src => src.PreviewLink))
                    .ForMember(dest => dest.InfoLink, opts => opts.MapFrom(src => src.InfoLink))
                    .ForMember(dest => dest.CanonicalVolumeLink, opts => opts.MapFrom(src => src.CanonicalVolumeLink));
                    CreateMap<IndustryIdentifier, IndustryIdentifierDTO>()
                        .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
                        .ForMember(dest => dest.Identifier, opts => opts.MapFrom(src => src.Identifier));
                    CreateMap<PanelizationSummaryVolumeList, PanelizationSummaryDTO>()
                        .ForMember(dest => dest.ContainsEpubBubbles, opts => opts.MapFrom(src => src.ContainsEpubBubbles))
                        .ForMember(dest => dest.ContainsImageBubbles, opts => opts.MapFrom(src => src.ContainsImageBubbles));
                    CreateMap<ImageLinksVolumeList, ImageLinksDTO>()
                        .ForMember(dest => dest.SmallThumbnail, opts => opts.MapFrom(src => src.SmallThumbnail))
                        .ForMember(dest => dest.Thumbnail, opts => opts.MapFrom(src => src.Thumbnail));
                    CreateMap<ReadingModesVolumeList, ReadingModesDTO>()
                        .ForMember(dest => dest.Text, opts => opts.MapFrom(src => src.Text))
                        .ForMember(dest => dest.Image, opts => opts.MapFrom(src => src.Image));
            CreateMap<SaleInfoVolumeList, SaleInfoDTO>()
                    .ForMember(dest => dest.Country, opts => opts.MapFrom(src => src.Country))
                    .ForMember(dest => dest.Saleability, opts => opts.MapFrom(src => src.Saleability))
                    .ForMember(dest => dest.IsEbook, opts => opts.MapFrom(src => src.IsEbook))
                    .ForMember(dest => dest.BuyLink, opts => opts.MapFrom(src => src.BuyLink));
                    CreateMap<ListPriceVolumeList, ListPriceDTO>()
                        .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                        .ForMember(dest => dest.CurrencyCode, opts => opts.MapFrom(src => src.CurrencyCode))
                        .ForMember(dest => dest.AmountInMicros, opts => opts.MapFrom(src => src.AmountInMicros));
                    CreateMap<RetailPriceVolumeList, RetailPriceDTO>()
                        .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                        .ForMember(dest => dest.CurrencyCode, opts => opts.MapFrom(src => src.CurrencyCode))
                        .ForMember(dest => dest.AmountInMicros, opts => opts.MapFrom(src => src.AmountInMicros));
                    CreateMap<OfferVolumeList, OfferDTO>()
                        .ForMember(dest => dest.FinskyOfferType, opts => opts.MapFrom(src => src.FinskyOfferType))
                        .ForMember(dest => dest.ListPrice, opts => opts.MapFrom(src => src.ListPrice))
                        .ForMember(dest => dest.RetailPrice, opts => opts.MapFrom(src => src.RetailPrice))
                        .ForMember(dest => dest.Giftable, opts => opts.MapFrom(src => src.Giftable));
            CreateMap<AccessInfoVolumeList, AccessInfoDTO>()
                .ForMember(dest => dest.Country, opts => opts.MapFrom(src => src.Country))
                .ForMember(dest => dest.Viewability, opts => opts.MapFrom(src => src.Viewability))
                .ForMember(dest => dest.Embeddable, opts => opts.MapFrom(src => src.Embeddable))
                .ForMember(dest => dest.PublicDomain, opts => opts.MapFrom(src => src.PublicDomain))
                .ForMember(dest => dest.TextToSpeechPermission, opts => opts.MapFrom(src => src.TextToSpeechPermission))
                .ForMember(dest => dest.Epub, opts => opts.MapFrom(src => src.Epub))
                .ForMember(dest => dest.Pdf, opts => opts.MapFrom(src => src.Pdf))
                .ForMember(dest => dest.WebReaderLink, opts => opts.MapFrom(src => src.WebReaderLink))
                .ForMember(dest => dest.AccessViewStatus, opts => opts.MapFrom(src => src.AccessViewStatus))
                .ForMember(dest => dest.QuoteSharingAllowed, opts => opts.MapFrom(src => src.QuoteSharingAllowed));
                CreateMap<EpubVolumeList, EpubDTO>()
                    .ForMember(dest => dest.IsAvailable, opts => opts.MapFrom(src => src.IsAvailable))
                    .ForMember(dest => dest.AcsTokenLink, opts => opts.MapFrom(src => src.AcsTokenLink));
                CreateMap<PdfVolumeList, PdfDTO>()
                    .ForMember(dest => dest.IsAvailable, opts => opts.MapFrom(src => src.IsAvailable))
                    .ForMember(dest => dest.AcsTokenLink, opts => opts.MapFrom(src => src.AcsTokenLink));
            CreateMap<SearchInfoVolumeList, SearchInfoDTO>()
                .ForMember(dest => dest.TextSnippet, opts => opts.MapFrom(src => src.TextSnippet));
            CreateMap<GoogleBooksVolumeList, VolumeListDTO>()
                .ForMember(dest => dest.Kind, opts => opts.MapFrom(src => src.Kind))
                .ForMember(dest => dest.TotalItems, opts => opts.MapFrom(src => src.TotalItems))
                .ForMember(dest => dest.Items, opts => opts.MapFrom(src => src.Items));
            CreateMap<VolumeListDTO, GoogleBooksVolumeList>();
        }
    }
}
