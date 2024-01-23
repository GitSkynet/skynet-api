using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DtoService.GoogleBooks
{
    public class VolumeListDTO
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonProperty("totalItems", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }

    public class AccessInfoDTO
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("viewability", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("viewability")]
        public string Viewability { get; set; }

        [JsonProperty("embeddable", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("embeddable")]
        public bool Embeddable { get; set; }

        [JsonProperty("publicDomain", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("publicDomain")]
        public bool PublicDomain { get; set; }

        [JsonProperty("textToSpeechPermission", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("textToSpeechPermission")]
        public string TextToSpeechPermission { get; set; }

        [JsonProperty("epub", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("epub")]
        public EpubDTO Epub { get; set; }

        [JsonProperty("pdf", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pdf")]
        public PdfDTO Pdf { get; set; }

        [JsonProperty("webReaderLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("webReaderLink")]
        public string WebReaderLink { get; set; }

        [JsonProperty("accessViewStatus", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("accessViewStatus")]
        public string AccessViewStatus { get; set; }

        [JsonProperty("quoteSharingAllowed", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("quoteSharingAllowed")]
        public bool QuoteSharingAllowed { get; set; }
    }

    public class EpubDTO
    {
        [JsonProperty("isAvailable", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("acsTokenLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("acsTokenLink")]
        public string AcsTokenLink { get; set; }
    }

    public class ImageLinksDTO
    {
        [JsonProperty("smallThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("smallThumbnail")]
        public string SmallThumbnail { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class IndustryIdentifierDTO
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }

    public class Item
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonProperty("selfLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("selfLink")]
        public string SelfLink { get; set; }

        [JsonProperty("volumeInfo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("volumeInfo")]
        public VolumeInfoDTO VolumeInfo { get; set; }

        [JsonProperty("saleInfo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("saleInfo")]
        public SaleInfoDTO SaleInfo { get; set; }

        [JsonProperty("accessInfo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("accessInfo")]
        public AccessInfoDTO AccessInfo { get; set; }

        [JsonProperty("searchInfo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("searchInfo")]
        public SearchInfoDTO SearchInfo { get; set; }
    }

    public class ListPriceDTO
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("amountInMicros", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("amountInMicros")]
        public int AmountInMicros { get; set; }
    }

    public class OfferDTO
    {
        [JsonProperty("finskyOfferType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("finskyOfferType")]
        public int FinskyOfferType { get; set; }

        [JsonProperty("listPrice", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("listPrice")]
        public ListPriceDTO ListPrice { get; set; }

        [JsonProperty("retailPrice", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("retailPrice")]
        public RetailPriceDTO RetailPrice { get; set; }

        [JsonProperty("giftable", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("giftable")]
        public bool Giftable { get; set; }
    }

    public class PanelizationSummaryDTO
    {
        [JsonProperty("containsEpubBubbles", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonProperty("containsImageBubbles", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }

    public class PdfDTO
    {
        [JsonProperty("isAvailable", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("acsTokenLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("acsTokenLink")]
        public string AcsTokenLink { get; set; }
    }

    public class ReadingModesDTO
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("text")]
        public bool Text { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("image")]
        public bool Image { get; set; }
    }

    public class RetailPriceDTO
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("amountInMicros", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("amountInMicros")]
        public int? AmountInMicros { get; set; }
    }

    public class SaleInfoDTO
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonProperty("saleability", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("saleability")]
        public string? Saleability { get; set; }

        [JsonProperty("isEbook", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("isEbook")]
        public bool? IsEbook { get; set; }

        [JsonProperty("listPrice", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("listPrice")]
        public ListPriceDTO? ListPrice { get; set; }

        [JsonProperty("retailPrice", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("retailPrice")]
        public RetailPriceDTO? RetailPrice { get; set; }

        [JsonProperty("buyLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("buyLink")]
        public string? BuyLink { get; set; }

        [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("offers")]
        public List<OfferDTO>? Offers { get; set; }
    }

    public class SearchInfoDTO
    {
        [JsonProperty("textSnippet", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("textSnippet")]
        public string? TextSnippet { get; set; }
    }

    public class VolumeInfoDTO
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonProperty("authors", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("authors")]
        public string? Authors { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        [JsonProperty("publishedDate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("publishedDate")]
        public string? PublishedDate { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonProperty("industryIdentifiers", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("industryIdentifiers")]
        public List<IndustryIdentifierDTO>? IndustryIdentifiers { get; set; }

        [JsonProperty("readingModes", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("readingModes")]
        public ReadingModesDTO? ReadingModes { get; set; }

        [JsonProperty("pageCount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("pageCount")]
        public int? PageCount { get; set; }

        [JsonProperty("printType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("printType")]
        public string? PrintType { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("categories")]
        public List<string>? Categories { get; set; }

        [JsonProperty("maturityRating", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("maturityRating")]
        public string? MaturityRating { get; set; }

        [JsonProperty("allowAnonLogging", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("allowAnonLogging")]
        public bool? AllowAnonLogging { get; set; }

        [JsonProperty("contentVersion", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("contentVersion")]
        public string? ContentVersion { get; set; }

        [JsonProperty("panelizationSummary", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("panelizationSummary")]
        public PanelizationSummaryDTO? PanelizationSummary { get; set; }

        [JsonProperty("imageLinks", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("imageLinks")]
        public ImageLinksDTO? ImageLinks { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonProperty("previewLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("previewLink")]
        public string? PreviewLink { get; set; }

        [JsonProperty("infoLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("infoLink")]
        public string? InfoLink { get; set; }

        [JsonProperty("canonicalVolumeLink", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("canonicalVolumeLink")]
        public string? CanonicalVolumeLink { get; set; }
    }


}
