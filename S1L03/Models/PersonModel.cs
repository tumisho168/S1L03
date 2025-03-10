﻿using System.ComponentModel.DataAnnotations; // Add to project
//Ensure that CodeLens is activated
//Select >> Tools >> Options >> Text Editor >> All Languages >> CodeLens
namespace S1L03.Models
{
    public class PersonModel
    {
        //Quick property - type "prop" press tab x2
        //Complete the property details
        //This is the "Model" of "data source"
        [Display(Name = "Link to personal page")] //Add as decorator
        public string MyLink { get; set; }

        [Display(Name = "Student Number")] //Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "First Name")] //Add as decorator
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")] //Add as decorator
        public string LastName { get; set; } 

        [Display(Name = "Email Address")] //Add as decorator
        
        public string StudentEmail { get; set; }
    }
}