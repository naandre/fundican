using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string Genre1 { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
