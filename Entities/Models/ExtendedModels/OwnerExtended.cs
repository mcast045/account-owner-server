using System;
using System.Collections.Generic;
using Entities.Models;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.ExtendedModels
{
    public class OwnerExtended : IEntity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be longer then 100 characters")]
        public string Address { get; set; }

        public IEnumerable<Account> Account { get; set; }

        public OwnerExtended()
        {

        }

        public OwnerExtended(Owner owner)
        {
            Id = owner.Id;
            Name = owner.Name;
            DateOfBirth = owner.DateOfBirth;
            Address = owner.Address;
        }
    }
}
