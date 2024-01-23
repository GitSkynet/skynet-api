using AutoMapper;
using DtoService.OpenBoooks;
using Entities.OpenBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Mappings.OpenBooks
{
	public class AuthorsMigrationMapping : Profile 
	{
		public AuthorsMigrationMapping()
		{
			CreateMap<Author, AuthorDTO>()
				.ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
				.ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
				.ForMember(dest => dest.Birthday, opts => opts.MapFrom(src => src.Birthday))
				.ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
				.ForMember(dest => dest.ShortDescription, opts => opts.MapFrom(src => src.ShortDescription))
				.ForMember(dest => dest.Photo, opts => opts.MapFrom(src => src.Photo))
				.ForMember(dest => dest.Books, opts => opts.MapFrom(src => src.Books));
		}
	}
}
