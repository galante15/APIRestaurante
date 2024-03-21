using APINinos.Model;
using APINinos.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APINinos.Controllers
{   
    [ApiController]
    [Route("controller/")]
    public class HomeController : ControllerBase
    {
        private readonly IETabelasRepository _TabelasRepository;

        public HomeController(IETabelasRepository tabelasRepository)
        {
            _TabelasRepository = tabelasRepository ?? throw new ArgumentNullException(nameof(tabelasRepository));
        }

        [HttpPost("addPrato")]
        public IActionResult AddPratos(PratosViewModel pratosViewModel)
        {
            var pratos = new Pratos(pratosViewModel.proteina, pratosViewModel.condimentos, pratosViewModel.disponivel, null);
            _TabelasRepository.addPratos(pratos);
            return Ok(pratos);
        }

        [HttpPost("addPedidos")]
        public IActionResult AddPedidos(PedidosViewModel pedidosViewModel)
        {
            var pedidos = new Pedidos(pedidosViewModel.cliente, pedidosViewModel.pratos, pedidosViewModel.total, pedidosViewModel.pagamento, pedidosViewModel.observacao, pedidosViewModel.entregador);
            _TabelasRepository.addPedidos(pedidos);
            return Ok(pedidos);
        }

        [HttpPost("addClientes")]
        public IActionResult AddClientes(ClientesViewModel clientesViewModel)
        {
            var clientes = new Clientes(clientesViewModel.nome, clientesViewModel.telefone, clientesViewModel.endereço);
            _TabelasRepository.addClientes(clientes);
            return Ok(clientes);
        }

        [HttpGet("pratos")] 
        public IActionResult GetPratos()
        {
            var prato = _TabelasRepository.GetPratos();
            return Ok(prato);
        }

        [HttpGet("pedidos")] 
        public IActionResult GetPedidos()
        {
            var pedido = _TabelasRepository.GetPedidos();
            return Ok(pedido);
        }

        [HttpGet("clientes")]
        public IActionResult GetClientes()
        {
            var cliente = _TabelasRepository.GetClientes();
            return Ok(cliente);
        }

        [HttpPut("")]


    }
}
