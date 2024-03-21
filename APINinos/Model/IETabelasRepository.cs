namespace APINinos.Model
{
    public interface IETabelasRepository
    {
        void addPratos(Pratos pratos);
        List<Pratos> GetPratos();

        void addPedidos(Pedidos pedidos);
        List<Pedidos> GetPedidos();

        void addClientes(Clientes clientes);
        List<Clientes> GetClientes();
    }
}
