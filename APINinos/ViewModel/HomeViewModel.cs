namespace APINinos.ViewModel
{
    public class PratosViewModel
    {
        public string proteina { get; set; }
        public string condimentos { get; set; }
        public string disponivel { get; set; }
        public string foto { get; set; }
    }

    public class PedidosViewModel
    {
        public string cliente { get; set; }
        public string pratos { get; set; }
        public decimal total { get; set; }
        public string pagamento { get; set; }
        public string observacao { get; set; }
        public string entregador { get; set; }
    }

    public class ClientesViewModel
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereço { get; set; }
    }
}
        

    
