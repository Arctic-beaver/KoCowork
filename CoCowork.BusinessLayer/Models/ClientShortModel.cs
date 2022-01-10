namespace CoCowork.BusinessLayer.Models
{
    public class ClientShortModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }
    }
}
