﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ODataWithoutEntityFrameworkQueryTest.Models
{
    public enum Category
    {
        Book,
        Magazine,
        EBook
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class Press
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Category Category { get; set; }
        public IDictionary<string, object> DynamicProperties { get; set; }
    }

    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Press Press { get; set; }
        public BookType BookType { get; set; }
        public IDictionary<string, object> Properties { get; set; }
    }

    public abstract class BookType
    {
        
    }

    public class Programming : BookType
    {
        public string Language { get; set; }
    }

}