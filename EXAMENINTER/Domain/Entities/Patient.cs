namespace EXAMENINTER.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string NationalId { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public List<Appointment> Appointments { get; set; } = new();
    }
}