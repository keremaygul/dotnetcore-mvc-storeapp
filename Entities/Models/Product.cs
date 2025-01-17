﻿using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductID { get; set; }
    public String? ProductName { get; set; } = String.Empty;
    public decimal Price { get; set; }
    public string? Summary { get; set; } = String.Empty;
    public string? ImageUrl { get; set; }
    public int? CategoryId { get; set; }    // Foreign Key

    public Category? Category { get; set; } // Navigation Property

    public bool ShowCase { get; set; }
}
