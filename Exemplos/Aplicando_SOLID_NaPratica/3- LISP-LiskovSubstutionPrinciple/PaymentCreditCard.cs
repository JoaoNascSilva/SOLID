namespace Aplicando_SOLID_NaPratica.LISP_LiskovSubstutionPrinciple
{
    public class PaymentCreditCard : Payment
    {
        public override decimal Total()
        {
            return 0.00M;
        }

        public void ReceiveCreditCard() { }
    }
}