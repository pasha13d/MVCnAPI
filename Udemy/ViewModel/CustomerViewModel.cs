﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy.Models;

namespace Udemy.ViewModel
{
    public class CustomerViewModel
    {
        public List<Customer> Customer { get; set; }
        public Movie Movie { get; set; }
    }
}