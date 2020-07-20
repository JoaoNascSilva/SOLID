namespace AplicandoSOLIDNaPratica.OCP_OpenClosedPrinciple.ExtensionMethod
{
    public static class CurrentAccountGold
    {
        /// <summary>
        /// OCP Utilizando os Extension Methods
        /// </summary>
        /// <param name="currentAccount"></param>
        public static string DebitCurrentAccountGold(this CurrentAccount currentAccount)
        {
            // Regras especificas para conta GOLD

            return currentAccount.CodeTransaction();
        }
    }
}