using System;
using System.Collections.Generic;
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
        public int CarModelId { get; set; }
        public CarModel Model { get; set; }

        public string Slug { get; set; }
        public Transmissions Transmission { get; set; }

        public FuelType Fuel { get; set; }

        public byte Passsenger { get; set; }

        public byte Luggage { get; set; }

        public byte Door { get; set; }

        public string Title { get; set; }
        public decimal DailyPrice { get; set; }

        public byte Discount { get; set; }
        public string Description { get; set; }

        public List<Facilities> Facilities { get; set; }

        public bool Status { get; set; }
    }
}
