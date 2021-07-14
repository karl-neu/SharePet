using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasData
            (
                new Owner
                {
                    Id = "c9d4c053-49b6-410c-bc78-2d54a9991870",
                    Name = "John Keen",
                    Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                    DateOfBirth = new DateTime(1990, 12, 12)
                },
                new Owner
                {
                    Id = "3d490a70-94ce-4d15-9494-5248280c2ce3",
                    Name = "Martin Miller",
                    Address = "3 Edgar Buildings",
                    DateOfBirth = new DateTime(1985, 10, 2)
                },
                new Owner
                {
                    Id = "a3c1880c-674c-4d18-8f91-5d3608a2c937",
                    Name = "Sam Query",
                    Address = "91 Western Roads",
                    DateOfBirth = new DateTime(1999, 4, 7)
                }
            );
        }
    }
}
