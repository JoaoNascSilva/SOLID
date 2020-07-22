namespace AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Customer(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public bool Validar()
        {
            // Validacooes Basicas para demonstrcao
            if (this.Name == "") return false;
            if (!this.Email.Contains("@")) return false;

            return true;
        }
    }
}
