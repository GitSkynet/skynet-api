using AutoMapper;
using DomainService.Contracts;
using DtoService.GoogleBooks;
using Repository.Contracts.GoogleBooks;

namespace DomainService.Services.GoogleBooks
{
    public class GoogleBooksService : IGoogleBooksContract
    {
        private readonly IGoogleBooksAssociationRepo googleBooksAssociationRepo;
        IMapper mapper;

        public GoogleBooksService(IGoogleBooksAssociationRepo GoogleBooksAssociationRepo, IMapper mapper)
        {
            googleBooksAssociationRepo = GoogleBooksAssociationRepo;
            this.mapper = mapper;
        }

        public async Task<List<VolumeDTO>> GetVolumeByID(string bookID)
        {
            List<VolumeDTO> volumeList = new List<VolumeDTO>();
            try
            {
                var booksRepo = await googleBooksAssociationRepo.GetVolumeByID(bookID);
                foreach(var book in booksRepo)
                {
                    volumeList.Add(mapper.Map<VolumeDTO>(book));
                }
                return volumeList;
            }
            catch(Exception ex)
            {
                throw new Exception($"Message: {ex.Message} InnerException:{ex.InnerException}");
            }
        }
        
        public async Task<VolumeListDTO> GetVolumesByKeyword(string keywordToSearch)
        {
            // GoogleBooksVolumeList > VolumeListDTO
            List<VolumeDTO> volumeList = new List<VolumeDTO>();
            try
            {
                var booksRepo = await googleBooksAssociationRepo.GetVolumesByKeyword(keywordToSearch);
                var listDTO = mapper.Map<VolumeListDTO>(booksRepo);
                return listDTO;
            }
            catch(Exception ex)
            {
                throw new Exception($"Message: {ex.Message} InnerException:{ex.InnerException}");
            }
        }
    }
}
