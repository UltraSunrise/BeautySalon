namespace BeautySalon.Models.Interfaces
{
    using BeautySalon.Models.Enums;

    public interface Procedure
    {
        int Id { get; set; }
        string Name { get; set; }
        int TimeDuration { get; set; }
        ProcedureTypes ProcedureType { get; set; }
    }
}
