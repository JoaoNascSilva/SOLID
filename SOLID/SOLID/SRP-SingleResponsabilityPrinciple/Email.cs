﻿namespace AplicandoSOLIDNaPratica
{
    public class Email
    {
        public string Address { get; private set; }

        public Email(string address)
        {        
            this.Address = address;
        }

        public bool Validar()
        {
            if (!this.Address.Contains("@"))
                return false;

            return true;
        }

    }
}