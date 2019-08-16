using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefnDishes.Models{
    public class Chef{
        [Key]
        public int user_id{get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Chef's first name must be at least 2 characters.")]
        public string first_name{get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Chef's last name must be at least 2 characters.")]
        public string last_name{get;set;}
        [Required]
        public  List<Dish> Dishes{get;set;}

        [Required]
        [AgeCheck]
        public DateTime DOB{get;set;}
    }
    public class AgeCheckAttribute : ValidationAttribute{
        
        protected override ValidationResult IsValid(object date, ValidationContext validationContext){
            DateTime DOB = Convert.ToDateTime(date);
            DateTime today  =  DateTime.Now;
            var age = today.Year - DOB.Year;
            if(DOB.Date > today.AddYears(-age)) age--;
            if(age <18){
                return new ValidationResult("Invalid date, Chef must be at least 18 years old.");
            }else{
                return ValidationResult.Success;
            }
        }
    }
    public class Dish{
        [Key]
        public int dish_id{get;set;}
        [Required]
        [MinLength(2,ErrorMessage="Dish name must be at least 2 characters.")]
        public string name{get;set;}
        [Required]
        [Range(0,10000)]
        public int calories{get;set;}
        [Required]
        [MinLength(10,ErrorMessage="Description should be at least 10 characters.")]
        public string description{get;set;}
        [Required]
        [Range(1,6,ErrorMessage="Please select a value between 1 and 5")]
        public int tastiness{get;set;}
        [Required(ErrorMessage="Please select the Chef that made this dish.")]
        public Chef chef{get;set;}


    }
}