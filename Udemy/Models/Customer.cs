﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Udemy.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
        
        public bool IsSubscribedToNewsLetter { get; set; }
        
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        
        public byte MembershipTypeId { get; set; }
    }
}