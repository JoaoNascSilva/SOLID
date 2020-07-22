namespace Aplicando_SOLID_NaPratica.OCP_OpenClosedPrinciple
{
    public class CurrentAccount : Account
    {
        public override string Debit(decimal value)
        {
            // Regras de Debito

            // Validar Taxas

            return CodeTransaction();
        }

        public override string Deposit(decimal value)
        {
            // Regras de Deposito

            return CodeTransaction();
        }
    }
}