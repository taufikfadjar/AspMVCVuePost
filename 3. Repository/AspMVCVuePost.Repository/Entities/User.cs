using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVCVuePost.Repository.Entities
{
    public class User : IdentityUser
    {
        [StringLength(100)]
        public string Fullname { get; set; }
        public DateTime? Birthdate { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
