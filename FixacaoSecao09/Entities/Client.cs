using System;
using System.Text;

namespace FixacaoSecao09.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime bithDate)
        {
            Name = name;
            Email = email;
            BithDate = bithDate;
        }

        public override string ToString()
        {
            return Name
                + " "
                + "("
                + BithDate.ToString("dd/MM/yyyy")
                + ")"
                + " - "
                + Email;
        }
    }
}

