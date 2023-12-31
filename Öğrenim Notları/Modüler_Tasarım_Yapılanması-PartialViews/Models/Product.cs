﻿using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models.ModelMetadataTypes;
using System.ComponentModel.DataAnnotations;

namespace OrnekProje.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
