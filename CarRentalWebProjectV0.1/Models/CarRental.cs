using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Models {
    public class CarRental {
        public int CarRentalId { get; set; }
        public string Name { get; set; }
        public double CpfCnpj { get; set; }
        public double Telephone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Payment { get; set; }
        public DateTime Withdraw { get; set; }
        public DateTime Devolution { get; set; }
    }
}
