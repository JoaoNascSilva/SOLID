using System;

namespace Aplicando_SOLID_NaPratica
{
    public class Document
    {
        public string Cpf { get; private set; }
        public string Rg { get; private set; }

        public Document(string cpf, string rg)
        {
            this.Cpf = cpf.Replace(".", "").Replace("-", "");
            this.Rg = rg.Replace(".", "").Replace("-", ""); ;
        }

        //Validacao Simples
        //Intuito e trabalhar o SOLID e nao demais funcionalidades
        public bool IsValid()
        {
            if (this.Cpf.Length != 11)
                return false;

            if (this.Rg.Length != 9)
                return false;

            return true;
        }
    }
}