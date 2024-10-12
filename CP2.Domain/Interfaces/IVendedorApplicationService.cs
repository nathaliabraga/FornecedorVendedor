﻿using CP2.Domain.Entities;
using System.Collections.Generic;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorApplicationService
    {
        IEnumerable<VendedorEntity> ObterTodos();

        VendedorEntity? ObterPorId(int id);

        VendedorEntity? SalvarDados(VendedorEntity entity);

        VendedorEntity? EditarDados(VendedorEntity entity);

        VendedorEntity? DeletarDados(int id);
        VendedorEntity EditarDados();
        VendedorEntity SalvarDados();
    }
}