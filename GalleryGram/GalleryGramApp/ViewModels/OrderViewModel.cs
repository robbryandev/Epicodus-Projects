using System.ComponentModel.DataAnnotations;
using System.Globalization;
using GalleryGram.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace GalleryGram.ViewModels
{
  public class OrderViewModel
  {
        [Required]
        public string line1 { get; set; }
        public string line2 { get; set; }
        [Required]
        [RegularExpression("[0-9]{5}")]
        public string postalOrZipCode { get; set; }
        [Required]
        [StringLength(2)]
        [CountryCodeType]
        public string countryCode { get; set; }
        [Required]
        public string townOrCity { get; set; }
        [Required]
        public string stateOrCounty { get; set; }
  }

  public class CountryCodeType : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      try {
        RegionInfo testCode = new RegionInfo(value.ToString());
        return null;
      } catch {
        return new ValidationResult($"{value.ToString()} is not a valid country code");
      }
    }
  }
}