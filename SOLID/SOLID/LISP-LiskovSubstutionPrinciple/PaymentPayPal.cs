﻿namespace AplicandoSOLIDNaPratica.LISP_LiskovSubstutionPrinciple
{
    public class PaymentPayPal : Payment
    {
        public override decimal Total()
        {
            return 0.00M;
        }

        public void ReceivedPayPal() { } 
    }
}