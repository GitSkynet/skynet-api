using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TMDB.Movies
{
	public class MovieSpokenLanguage : EntityBase
	{
		public long MovieID { get; set; }
		public Movie Movies { get; set; }

		public long SpokenLanguageID { get; set; }
		public SpokenLanguage SpokenLanguages { get; set; }
	}
}
