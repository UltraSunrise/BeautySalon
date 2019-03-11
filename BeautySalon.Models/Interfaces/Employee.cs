using static System.Net.Mime.MediaTypeNames;

namespace BeautySalon.Models.Interfaces
{
    public interface Employee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        Image Avatar { get; set; }
    }
}
