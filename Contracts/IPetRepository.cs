﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPetRepository : IRepositoryBase<Pet>
    {
        IEnumerable<Pet> PetsByOwner(string ownerId);
    }
}
