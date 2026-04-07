using System;

namespace HotelReservation.Models
{
    public class Rezervare
    {
        public int RezervareId { get; set; }
        public int ClientId { get; set; }
        public int CameraId { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public string StatusRezervare { get; set; }
        public decimal PretTotal { get; set; }

        // Navigation / display properties
        public string NumeClient { get; set; }
        public string NumarCamera { get; set; }

        public int NoptiRezervare => (DataCheckout - DataCheckin).Days;

        public override string ToString()
        {
            return $"Rezervare #{RezervareId}: {NumeClient} - Camera {NumarCamera} " +
                   $"({DataCheckin:dd/MM/yyyy} - {DataCheckout:dd/MM/yyyy})";
        }
    }
}
