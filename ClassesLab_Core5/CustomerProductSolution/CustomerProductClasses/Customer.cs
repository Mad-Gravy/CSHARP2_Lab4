using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int Id;
        private string FName;
        private string LName;
        private string EMail;
        private string PhoneNumber;

        public Customer() { } // Default constructor!

        public Customer(int id, string fName, string lName, string eMail, string phoneNumber) //Full constructor!
        {
            Id = id;
            FName = fName;
            LName = lName;
            EMail = eMail;
            PhoneNumber = phoneNumber;
        }


        // Getters and Setters!
        public int CustomerId
        {
            get { return Id; }
            set { Id = value; }
        }

        public string FirstName
        {
            get { return FName; }
            set { FName = value; }
        }

        public string LastName
        {
            get { return LName; }
            set { LName = value; }
        }

        public string Email
        {
            get { return EMail; }
            set{ EMail = value; }
        }

        public string Phone
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }


        // ToString Method!
        public override string ToString()
        {
            return String.Format(
                "Id: {0} First Name: {1} Last Name: {2} Email: {3} Phone: {4}", 
                Id, FName, LName, EMail, PhoneNumber);
        }

        // This was much easier than trying to teach recursive code to play the Tower of Hanoi game lol
    }
}
