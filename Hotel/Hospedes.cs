﻿

namespace Hotel
{
    public class Hospedes
    {

        
        public string Nome { get; set; }
        public string Email { get; set; }

        public Hospedes( string nome, string email)
        {
            
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "NOME: " + Nome + 
                "EMAIL: " + Email;
        }
    }
}
