using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace RealEstate.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Adresss { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public string? MobileNumber { get; set; }
        public string? Discription { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

    } 
}
