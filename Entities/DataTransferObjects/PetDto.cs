using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class PetDto
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string PetType { get; set; }
    }
}
