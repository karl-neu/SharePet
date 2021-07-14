using Entities.Helpers;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPetRepository : IRepositoryBase<Pet>
    {
        PagedList<Pet> GetPetsByOwner(Guid ownerId, PetParameters parameters);
        IEnumerable<Pet> PetsByOwner(string ownerId);
        IEnumerable<Pet> GetPets();
    }
}
