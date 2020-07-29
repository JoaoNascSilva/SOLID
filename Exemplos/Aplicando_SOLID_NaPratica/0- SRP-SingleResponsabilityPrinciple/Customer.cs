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

        public bool IsValid()
        {
            if (!EmailAddress.IsValid() && !Documents.IsValid())
                return false;

            return true;
        }
    }
}