using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CleanArchitecture.Application.ViewModels
{
    [DataContract]
    public class GoogleBooksVolumeViewModel
    {
        public string ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string PublishedDate { get; set; }

        public string Description { get; set; }

        public string Country { get; set; }

        public string Viewability { get; set; }

        public string WebReaderLink { get; set; }

        public string AccessViewStatus { get; set; }

        public bool IsAvailableEPUB { get; set; }

        public bool IsAvailablePDF { get; set; }

        public int PageCount { get; set; }

        public string Language { get; set; }

        public string PreviewLink { get; set; }

        public string InfoLink { get; set; }

        public string CanonicalVolumeLink { get; set; }

        public string? Image { get; set; }

        public string? Thumbnail { get; set; }

        public string BuyLink { get; set; }

        public string EPUBDownloadLink { get; set; }

        public string PDFDownloadLink { get; set; }
    }
}
