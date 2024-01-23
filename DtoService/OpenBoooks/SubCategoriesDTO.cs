using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoService.OpenBoooks
{
    public class SubCategoriesDTO
    {
        public int ID { get; set; }

        public int id_openlibra { get; set; }

        public string name { get; set; }

        public string niceName { get; set; }

        public string icon { get; set; }

        public string background { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public string category_ID { get; set; }
    }
}
