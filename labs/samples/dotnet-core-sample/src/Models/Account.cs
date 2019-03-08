
using System;
using System.ComponentModel.DataAnnotations;

namespace account_api
{

    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string First { get; set; }
        [Required]
        [MaxLength(20)]
        public string Last { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
   
}