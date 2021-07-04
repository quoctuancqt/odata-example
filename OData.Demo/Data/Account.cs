namespace OData.Demo.Data
{
    public class Account
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public string RoleId { get; set; }
        public virtual Role Role { get; set; }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
