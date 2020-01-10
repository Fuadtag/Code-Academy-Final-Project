using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{   
     public enum Transmissions
    {
        AT,MT,CVT,DSG
    }

    public enum FuelType
    {
        Gasoline, Hybrid, Diesel, Electric, NaturalGas
    }

    public enum Facilities
    {
        AudioInput,Bluetooth,HeatedSeat,AWD,UsbInput,FmRadio,AC,Navigation,ParkingSensors,Wifi, Sunroof
    }
         
    public class Car
    {
        public int Id { get; set; }
        public int CarBrandId { get; set; }
        public CarBrand Brand{ get; set; }

        public Transmissions Transmission { get; set; }

        public FuelType Fuel { get; set; }
        [Required(ErrorMessage = "Required")]
        public byte Passsenger { get; set; }
        [Required(ErrorMessage = "Required")]
        public byte Luggage { get; set; }
        [Required(ErrorMessage = "Required")]
        public byte Door { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(70)]
        public string Title { get; set; }
        [Column(TypeName = "Money")]
        public decimal DailyPrice { get; set; }

        public byte Discount { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        public string Description { get; set; }

        public ICollection<CustomerReview> CustomerReviews { get; set; }
        [NotMapped]
        public ICollection<Facilities> Facilities { get; set; }

        public bool Status { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile CartPhotoFile { get; set; }
        public string CartPhoto { get; set; }
        [NotMapped]
        public IFormFile DetailPhotoFile { get; set; }

        public string DetailPhoto { get; set; }
    }
}
