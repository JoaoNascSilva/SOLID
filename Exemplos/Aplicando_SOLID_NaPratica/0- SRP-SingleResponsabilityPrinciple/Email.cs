namespace Aplicando_SOLID_NaPratica
{
    public class Email
    {
        public string Address { get; private set; }

        public Email(string address)
        {        
            this.Address = address;
        }

        public bool IsValid()
        {
            if (!this.Address.Contains("@"))
                return false;

            return true;
        }

    }
}