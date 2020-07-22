namespace Aplicando_SOLID_NaPratica
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public Email EmailAddress { get; private set; }
        public Document Documents { get; private set; }

        public Customer(string name, Email emailAddress, Document documents)
        {
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.Documents = documents;
        }

        public bool Validar()
        {
            if (!EmailAddress.Validar() && !Documents.Validar())
                return false;

            return true;
        }
    }
}