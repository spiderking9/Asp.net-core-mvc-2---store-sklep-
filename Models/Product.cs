﻿using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage="Proszę podać nazwę produktu.")]
        [Display(Name="Nazwa")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać opis.")]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Proszę podać cenę.")]
        [Range(0.01, double.MaxValue, ErrorMessage ="Proszę podać dodatnią cenę.")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Proszę określić kategorię.")]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
    }
}