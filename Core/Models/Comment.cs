using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Comment
    {

        public int Id { get; set; }
        public string Text { get; set; }
        public string ModifiedUserName { get; set; } 
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public int OwnerId { get; set; }
        public int WorkId { get; set; }



        public virtual Work Work { get; set; }
        public virtual User Owner { get; set; }







    }
}
