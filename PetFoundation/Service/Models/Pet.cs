using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Pet
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public int? CodPetType { get; set; }
        public int? CodGenre { get; set; }
        public int? Age { get; set; }
        public string Observations { get; set; }
        public string Image { get; set; }

        public virtual Genre CodGenreNavigation { get; set; }
        public virtual PetType CodPetTypeNavigation { get; set; }
    }
}
