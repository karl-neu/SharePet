using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasData
            (
                new Pet
                {
                    Id = "03e91478-5608-4132-a753-d489dafce00b",
                    Name = "Zoe",
                    Image = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/dog_cool_summer_slideshow/1800x1200_dog_cool_summer_other.jpg",
                    PetType = "Dog",
                    DateCreated = new DateTime(2020, 12, 2),
                    OwnerId = "c9d4c053-49b6-410c-bc78-2d54a9991870"
                },
                new Pet
                {
                    Id = "356a5a9b-64bf-4de0-bc84-5389a1fdc9c4",
                    Name = "Zoe",
                    Image = "https://icatcare.org/app/uploads/2018/07/Thinking-of-getting-a-cat.png",
                    PetType = "Cat",
                    DateCreated = new DateTime(2020, 12, 2),
                    OwnerId = "3d490a70-94ce-4d15-9494-5248280c2ce3"
                },
                new Pet
                {
                    Id = "371b93f2-f8c5-4a32-894a-fc892741aa5b",
                    Name = "Bibi",
                    Image = "https://assets.rebelmouse.io/eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpbWFnZSI6Imh0dHBzOi8vYXNzZXRzLnJibC5tcy8yNjEyMjQyMy9vcmlnaW4uanBnIiwiZXhwaXJlc19hdCI6MTY2NDY5ODE2M30.bZ6t9aON5E-QhKzSvnv8DhKleBGUwfejLQ8jOUJp5xE/img.jpg",
                    PetType = "Bird",
                    DateCreated = new DateTime(2021, 9, 12),
                    OwnerId = "a3c1880c-674c-4d18-8f91-5d3608a2c937"
                }

            );
        }
    }
}
