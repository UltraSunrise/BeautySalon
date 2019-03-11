namespace BeautySalon.Models
{
    using BeautySalon.Models.Enums;

    public class Procedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimeDuration { get; set; }
        public ProcedureTypes Type { get; set; }
    }
}
