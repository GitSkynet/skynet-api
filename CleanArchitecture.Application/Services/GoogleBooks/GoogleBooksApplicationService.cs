using AutoMapper;
using CleanArchitecture.Application.Contracts.GoogleBooksContracts;
using CleanArchitecture.Application.ViewModels;
using DomainService.Contracts;

namespace CleanArchitecture.Application.Services.GoogleBooks
{
    public class GoogleBooksApplicationService : IGoogleBooksApplicationService
    {
        private readonly IGoogleBooksContract googleAssociationContract;
        IMapper mapper;

        public GoogleBooksApplicationService(IGoogleBooksContract GoogleAssociationContract, IMapper mapper)
        {
            googleAssociationContract = GoogleAssociationContract;
            this.mapper = mapper;
        }

        public async Task<List<GoogleBooksVolumeViewModel>> GetVolumeByID(string bookID)
        {
            List<GoogleBooksVolumeViewModel> listViewModel = new List<GoogleBooksVolumeViewModel>();

            var googleBookList = await googleAssociationContract.GetVolumeByID(bookID);
            foreach (var book in googleBookList)
            {
                listViewModel.Add(mapper.Map<GoogleBooksVolumeViewModel>(book));
            }
            return listViewModel;
        }
        
        public async Task<List<GoogleBooksVolumeViewModel>> GetVolumesByKeyword(string keywordToSearch)
        {
            List<GoogleBooksVolumeViewModel> listViewModel = new List<GoogleBooksVolumeViewModel>();

            var googleBookList = await googleAssociationContract.GetVolumesByKeyword(keywordToSearch);
            try
            {
                foreach (var volume in googleBookList.Items)
                {
                    listViewModel.Add(mapper.Map<GoogleBooksVolumeViewModel>(volume));
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Exception:", ex);
            }

            return listViewModel;
        }
    }
}
