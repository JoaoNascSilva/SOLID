namespace AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple
{
    public class Entity
    {
        public string Id { get; private set; }

        protected Entity()
        {
            this.Id = System.Guid.NewGuid().ToString();
        }
    }
}