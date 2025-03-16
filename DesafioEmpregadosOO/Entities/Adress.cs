using System;

namespace DesafioEmpregadosOO.Entities
{
    class Adress
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public Adress()
        {
        }

        public Adress(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }
    }
}
