namespace AplicandoSOLIDNaPratica.LISP_LiskovSubstutionPrinciple
{
    // Principio da Substrituicao De Liskov
    /// <summary>
    /// SubClasses devem ser substituiveis por sua SuperClasse (Classe Pai)
    /// </summary>
    public class Payment
    {
        public virtual decimal Total()
        {
            return 0.00M;
        }  
    }
}