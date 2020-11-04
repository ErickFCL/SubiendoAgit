using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practicando.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        
        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        public string Name { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string ImagePath { get; set; }
        public int UserId { get; set; }
        public Type Type { get; set; }
    }
}
