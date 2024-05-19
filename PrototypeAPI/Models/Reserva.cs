namespace PrototypeAPI.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Produto? produto { get; set; }
        public int quantidade { get; set; }
    }
}
