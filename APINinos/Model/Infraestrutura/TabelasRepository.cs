using APINinos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APINinos.Infraestrutura
{
    public class TabelasRepository : IETabelasRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        //implementação da tabela Pratos
        public void addPratos(Pratos pratos)
        {
            _context.Pratos.Add(pratos);
            _context.SaveChanges();
        }


        public List<Pratos> GetPratos()
        {
            return _context.Pratos.ToList();
        }

        //implementação da tabela Pedidos
        public void addPedidos(Pedidos pedidos)
        {
            _context.Pedidos.Add(pedidos);
            _context.SaveChanges();
        }

        public List<Pedidos> GetPedidos()
        {
            return _context.Pedidos.ToList();
        }

        public void addClientes(Clientes clientes)
        {
            _context.Clientes.Add(clientes);
            _context.SaveChanges();
        }

        public List<Clientes> GetClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}
