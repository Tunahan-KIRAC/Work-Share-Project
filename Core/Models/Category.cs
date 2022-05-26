using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedOn { get; set; }=DateTime.Now;
        public DateTime? ModifiedOn { get; set; }= DateTime.Now;
        public string ModifiedUserName { get; set; } = string.Empty;

        public virtual ICollection<Work> Works { get; set; } 

    }
}
