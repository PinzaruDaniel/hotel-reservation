namespace HotelReservation.Models
{
    public class Camera
    {
        public int CameraId { get; set; }
        public string NumarCamera { get; set; }
        public string TipCamera { get; set; }
        public decimal PretNoapte { get; set; }
        public int Etaj { get; set; }
        public bool Activa { get; set; }

        public override string ToString()
        {
            return $"[{NumarCamera}] {TipCamera} - Etaj {Etaj} - {PretNoapte:F2} RON";
        }
    }
}
