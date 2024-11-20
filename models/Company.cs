using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace CompanyEditor.Models
{
    public class Company
    {
        [Key]
        public int Id    { get; set; }
        public string? OrgNumber { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? AreaCode { get; set; }
        public string? City { get; set; }
        public string? EmailAdress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
