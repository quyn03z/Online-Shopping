﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace OnlineShopping.Models.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public int Price { get; set; }

    public string Description { get; set; }

    public int CategoryId { get; set; }

    public double? StarRating { get; set; }

    public bool Status { get; set; }

    public int Size { get; set; }

    public int SupplierId { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Supplier Supplier { get; set; }
}