using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;

namespace CP2.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.ObterTodos();
        }

        public FornecedorEntity? SalvarDadosFornecedor(FornecedorEntity entity)
        {
            return _repository.SalvarDados(entity);
        }

        public FornecedorEntity? EditarDadosFornecedor(FornecedorEntity entity)
        {
            return _repository.EditarDados(entity);
        }

        public IEnumerable<FornecedorEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? SalvarDados(FornecedorEntity entity)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? EditarDados(FornecedorEntity entity)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? EditarDados(int id, FornecedorEntity entity)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity SalvarDados()
        {
            throw new NotImplementedException();
        }
    }
}
