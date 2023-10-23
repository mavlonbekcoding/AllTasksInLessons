using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMapster.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserName { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
    }
}
