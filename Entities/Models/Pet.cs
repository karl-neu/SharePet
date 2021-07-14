using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("pet")]
    public class Pet
    {
        [Column("PetId")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Account type is required")]
        public string PetType { get; set; }
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Owner Id is required")]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
