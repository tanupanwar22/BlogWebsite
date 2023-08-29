using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Model
{
	public class User
	{
        [Key, Required]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsAuthor { get; set; }
        public DateTime JoinedOn { get; set; }
    }
}
