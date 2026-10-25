namespace EXAMENINTER.Domain.Entities
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Doctor> Doctors { get; set; } = new();
    }
}
