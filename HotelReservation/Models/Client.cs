namespace HotelReservation.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string DocumentIdentitate { get; set; }

        public string NumeComplet => $"{Nume} {Prenume}";

        public override string ToString()
        {
            return $"{Nume} {Prenume} ({DocumentIdentitate})";
        }
    }
}
