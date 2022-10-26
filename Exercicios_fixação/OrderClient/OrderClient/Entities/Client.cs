using System;

namespace OrderClient.Entities
{
    class Client
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }

        public Client()
        {

        }

        public Client(string name, DateTime birthDate, string email)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
        }

        public override string ToString()
        {
            return Name
                + ", BirthDate: "
                + BirthDate.ToString("dd/MM/yyyy")
                + ", e-mail: "
                + Email;
        }
    }
}