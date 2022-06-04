using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public bool IsAdmin { get; set; }=false;
        public string? ProfileImageFileName { get; set; }
        public int Score { get; set; }


        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedUserName { get; set; }


        public virtual ICollection<Work> Works { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        


    }
}
