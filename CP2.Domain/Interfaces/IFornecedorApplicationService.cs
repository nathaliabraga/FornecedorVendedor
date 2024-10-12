using CP2.Domain.Entities;
using System.Collections.Generic;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorApplicationService
    {
        IEnumerable<FornecedorEntity> ObterTodos();

        FornecedorEntity? ObterPorId(int id);

        FornecedorEntity? SalvarDados(FornecedorEntity entity);

        FornecedorEntity? EditarDados(int id, FornecedorEntity entity);

        FornecedorEntity? DeletarDados(int id);
        FornecedorEntity SalvarDados();
    }
}
