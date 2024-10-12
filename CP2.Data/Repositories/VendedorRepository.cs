using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<VendedorEntity> ObterTodos()
        {
            return _context.Vendedor.ToList();
        }

        public VendedorEntity? ObterPorId(int id)
        {
            return _context.Vendedor.Find(id);
        }

        public VendedorEntity? SalvarDados(VendedorEntity entity)
        {
            _context.Vendedor.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public VendedorEntity? EditarDados(VendedorEntity entity)
        {
            var vendedorExistente = _context.Vendedor.Find(entity.Id);
            if (vendedorExistente == null)
                return null;

            vendedorExistente.Nome = entity.Nome;
            vendedorExistente.Email = entity.Email;
            vendedorExistente.DataNascimento = entity.DataNascimento;
            vendedorExistente.Telefone = entity.Telefone;
            vendedorExistente.Endereco = entity.Endereco;
            vendedorExistente.DataContratacao = entity.DataContratacao;
            vendedorExistente.ComissaoPercentual = entity.ComissaoPercentual;
            vendedorExistente.MetaMensal = entity.MetaMensal;
            vendedorExistente.CriadoEm = entity.CriadoEm;

            _context.Vendedor.Update(vendedorExistente);
            _context.SaveChanges();
            return vendedorExistente;
        }

        public VendedorEntity? DeletarDados(int id)
        {
            var vendedor = _context.Vendedor.Find(id);
            if (vendedor == null)
                return null;

            _context.Vendedor.Remove(vendedor);
            _context.SaveChanges();
            return vendedor;
        }
    }
}

