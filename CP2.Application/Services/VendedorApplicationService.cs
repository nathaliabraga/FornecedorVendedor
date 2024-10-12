using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;

namespace CP2.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public VendedorEntity? DeletarDadosVendedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            return _repository.ObterTodos();
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public VendedorEntity? SalvarDadosVendedor(VendedorEntity entity)
        {
            return _repository.SalvarDados(entity);
        }

        public VendedorEntity? EditarDadosVendedor(VendedorEntity entity)
        {
            return _repository.EditarDados(entity);
        }

        public IEnumerable<VendedorEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? SalvarDados(VendedorEntity entity)
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? EditarDados(VendedorEntity entity)
        {
            throw new NotImplementedException();
        }

        public VendedorEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }

        public VendedorEntity EditarDados()
        {
            throw new NotImplementedException();
        }

        public VendedorEntity SalvarDados()
        {
            throw new NotImplementedException();
        }
    }
}
