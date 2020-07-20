namespace AplicandoSOLIDNaPratica.OCP_OpenClosedPrinciple
{
    public class SavingsAccount : Account
    {
        public override string Debit(decimal value)
        {
            // Regras de Debito

            return CodeTransaction();
        }

        public override string Deposit(decimal value)
        {
            // Regras de Deposito

            return CodeTransaction();
        }
    }
}