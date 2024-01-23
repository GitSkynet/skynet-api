using AutoMapper;
using DomainService.Services.OpenBooks;
using Entities.OpenBooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.Contracts.OpenBooks;

namespace Domain.Layer.Tests
{
	[TestClass]
	public class DomainServiceTests
	{
		private Mock<IMapper> mapper;
		private Mock<IAuthorsAssociationRepo> authorsRepo;
		private AuthorService authorService;
		public List<Author> listAuthor;

		[TestInitialize]
		public void Setup()
		{
			mapper = new();
			authorsRepo = new();
			authorService = new(authorsRepo.Object, mapper.Object);
			listAuthor = new List<Author>()
			{
				new Author { Id=1, Name="John Mc Cornick", AuthorsBooks = new List<AuthorsBooks>(), Books = new List<Book>()},
				new Author { Id=2, Name="Jezú", AuthorsBooks = new List<AuthorsBooks>(), Books = new List<Book>()},
				new Author { Id=3, Name="Zehhio", AuthorsBooks = new List < AuthorsBooks >(), Books = new List < Book >()},
				new Author { Id=4, Name="Jhamerl", AuthorsBooks = new List < AuthorsBooks >(), Books = new List < Book >()},
			};
		}

		[TestMethod]
		public void Test_GetTheZoneID()
		{
			var idAuthor = 1;
			var expectedResult = listAuthor.Where(x => x.Id == idAuthor).ToList();

			authorsRepo.Setup(x => x.GetAuthorByID(idAuthor)).ReturnsAsync(expectedResult);

			var result = authorService.GetAuthorByID(idAuthor);

			Assert.IsNotNull(result);
			Assert.AreEqual(result.Result.Count(), expectedResult.Count());
		}

		[TestMethod]
		public void Test_GetTheZoneID2()
		{
			var idAuthor = 1;
			var expectedResult = listAuthor.Where(x => x.Id == idAuthor).ToList();

			authorsRepo.Setup(x => x.GetAuthorByID(idAuthor)).ReturnsAsync(expectedResult);

			var result = authorService.GetAuthorByID(idAuthor);

			Assert.IsNotNull(result);
			Assert.AreEqual(result.Result.Count(), expectedResult.Count());
		}

		[TestMethod]
		public void Test_GetTheZoneID3()
		{
			var idAuthor = 1;
			var expectedResult = listAuthor.Where(x => x.Id == idAuthor).ToList();

			authorsRepo.Setup(x => x.GetAuthorByID(idAuthor)).ReturnsAsync(expectedResult);

			var result = authorService.GetAuthorByID(idAuthor);

			Assert.IsNotNull(result);
			Assert.AreEqual(result.Result.Count(), expectedResult.Count());
		}
	}
}