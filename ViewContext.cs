﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidly.Models;


namespace Vidly
{
    public class ViewContext: DbContext
    {
        public ViewContext()
        {

        }
         public DbSet<Customer> Customers { get; set; }

         public DbSet<Movie> Movies { get; set; }
    
    }
}





   

   

        //Entities

       
    

