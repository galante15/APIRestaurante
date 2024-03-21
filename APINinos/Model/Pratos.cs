using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APINinos.Model
{
    [Table("pratos")]
    public class Pratos
    {
        [Key]
        public int id { get; set; }
        public string proteina { get; set; }
        public string? condimentos { get; set; }
        public string? disponivel { get; set; }
        public string? foto { get; set; }

        public Pratos(string proteina, string condimentos, string disponivel, string foto)
        {
            this.proteina = proteina;
            this.condimentos = condimentos;
            this.disponivel = disponivel;
            this.foto = foto;
        }
    }

    [Table("pedidos")]
    public class Pedidos
    {
        [Key]
        public int id { get; set; }
        public string cliente { get; set; }
        public string pratos { get; set; } 
        public decimal total { get; set; }
        public string pagamento { get; set; }   
        public string? observacao { get; set;}
        public string? entregador { get; set;}

        public Pedidos(string cliente, string pratos, decimal total, string pagamento, string observacao, string entregador)
        {
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            this.pratos = pratos ?? throw new ArgumentNullException(nameof(pratos));
            this.total = total;
            this.observacao = observacao;
            this.entregador = entregador;
            this.pagamento = pagamento;
        }

    }

    [Table("clientes")]
    public class Clientes
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set;}
        public string endereço { get; set; }

        public Clientes(string nome, string telefone, string endereço)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereço = endereço;
        }
    }
}
