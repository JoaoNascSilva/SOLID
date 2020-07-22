namespace Aplicando_SOLID_NaPratica
{
    public abstract class Entity
    {
        protected string Id { get; private set; }

        protected Entity()
        {
            this.Id = System.Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}