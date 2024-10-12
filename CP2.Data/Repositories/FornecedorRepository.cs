using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<FornecedorEntity> ObterTodos()
        {
            return _context.Fornecedor.ToList();
        }

        public FornecedorEntity? ObterPorId(int id)
        {
            return _context.Fornecedor.Find(id);
        }

        public FornecedorEntity? SalvarDados(FornecedorEntity entity)
        {
            _context.Fornecedor.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public FornecedorEntity? EditarDados(FornecedorEntity entity)
        {
            var fornecedorExistente = _context.Fornecedor.Find(entity.Id);
            if (fornecedorExistente == null)
                return null;

            fornecedorExistente.Nome = entity.Nome;
            fornecedorExistente.CNPJ = entity.CNPJ;
            fornecedorExistente.Endereco = entity.Endereco;
            fornecedorExistente.Telefone = entity.Telefone;
            fornecedorExistente.Email = entity.Email;
            fornecedorExistente.CriadoEm = entity.CriadoEm;

            _context.Fornecedor.Update(fornecedorExistente);
            _context.SaveChanges();
            return fornecedorExistente;
        }

        public FornecedorEntity? DeletarDados(int id)
        {
            var fornecedor = _context.Fornecedor.Find(id);
            if (fornecedor == null)
                return null;

            _context.Fornecedor.Remove(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }
    }
}
