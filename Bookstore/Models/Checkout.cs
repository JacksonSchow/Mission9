using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// Checkout model created for the checkout table in the database. Set up to store the information from the customer to the database

namespace Bookstore.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int CheckoutId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Enter Your First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Your Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter a Valid Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter Your Address")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Enter the City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Enter the Zip Code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Enter the Country")]
        public string Country { get; set; }
    }
}
