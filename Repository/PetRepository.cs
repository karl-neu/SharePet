using Contracts;
using Entities;
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

        public IEnumerable<Pet> PetsByOwner(string ownerId)
        {
            return FindByCondition(p => p.OwnerId.Equals(ownerId)).ToList();
        }
    }
}
