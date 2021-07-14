using Entities.Helpers;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        PagedList<Owner> GetOwners(OwnerParameters ownerParameters);
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(string ownerId);
        Owner GetOwnerWithDetails(string ownerId);
        void CreateOwner(Owner owner);
        void UpdateOwner(Owner owner);
        void DeleteOwner(Owner owner);
    }
}
