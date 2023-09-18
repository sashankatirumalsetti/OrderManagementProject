using System.ComponentModel.DataAnnotations;

namespace OrderManagementAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty; 

        [Required]
        public string LastName { get; set; } = string.Empty; 

        [Required]
        public string Email { get; set; } = string.Empty; 

    }
}
