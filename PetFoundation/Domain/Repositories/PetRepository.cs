using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class PetRepository: IPetRepository
    {
        private readonly fundicanContext _context;

        public PetRepository(fundicanContext context)
        {
            _context = context;
        }

        public List<Pet> GetPets()
        {
            return _context.Pets.Where(x => x.Id > 0).ToList();
        }
    }
}
