namespace Homework.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Relationship { get; set; }
        public string EmailAddress { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public Contact(
            int contactId,
            int studentId,
            string lastName,
            string firstName,
            string relationship,
            string emailAddress,
            string mobile,
            string address,
            string city,
            string state,
            int zipCode
            )
        {
            ContactId = contactId;
            StudentId = studentId;
            LastName = lastName;
            FirstName = firstName;
            Relationship = relationship;
            EmailAddress = emailAddress;
            Mobile = mobile;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
