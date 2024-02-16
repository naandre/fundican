using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
    }
}
