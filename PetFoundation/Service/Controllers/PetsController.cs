﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetsController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        // GET: api/Pets
        [HttpGet]
        public ActionResult<List<Pet>> GetPets()
        {
            var result = _petRepository.GetPets();
            if (result.Any())
                return Ok(result);

            else
                return NotFound();
        }

        //// GET: api/Pets/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Pet>> GetPet(int id)
        //{
        //    var pet = await _context.Pets.FindAsync(id);

        //    if (pet == null)
        //    {
        //        return NotFound();
        //    }

        //    return pet;
        //}

        //// PUT: api/Pets/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPet(int id, Pet pet)
        //{
        //    if (id != pet.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(pet).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PetExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Pets
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Pet>> PostPet(Pet pet)
        //{
        //    _context.Pets.Add(pet);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPet", new { id = pet.Id }, pet);
        //}

        //// DELETE: api/Pets/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePet(int id)
        //{
        //    var pet = await _context.Pets.FindAsync(id);
        //    if (pet == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Pets.Remove(pet);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool PetExists(int id)
        //{
        //    return _context.Pets.Any(e => e.Id == id);
        //}
    }
}
