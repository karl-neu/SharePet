using Contracts;
using Entities;
using Entities.Helpers;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class PetRepository : RepositoryBase<Pet>, IPetRepository
    {
        public PetRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Pet> GetPets()
        {
            return FindAll()
                .OrderBy(ow => ow.Name)
                .ToList();
        }

        public PagedList<Pet> GetPetsByOwner(Guid ownerId, PetParameters parameters)
        {
            var pets = FindByCondition(a => a.OwnerId.Equals(ownerId));

            return PagedList<Pet>.ToPagedList(pets,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public IEnumerable<Pet> PetsByOwner(string ownerId)
        {
            return FindByCondition(p => p.OwnerId.Equals(ownerId)).ToList();
        }
    }
}
