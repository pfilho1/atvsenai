using System;

namespace Atividade
{
    public class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }

        public virtual void Pagar_Imposto(float valor)
        {
            this.valor = valor;
            this.valor_imposto = valor * 0.10f;
            this.total = valor + this.valor_imposto;
        }
    }

    public class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }
    }

    public class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float valor)
        {
            this.valor = valor;
            this.valor_imposto = valor * 0.20f;
            this.total = valor + this.valor_imposto;
        }
    }
}