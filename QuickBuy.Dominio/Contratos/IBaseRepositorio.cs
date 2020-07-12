using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity>: IDisposable where TEntity: class
    {
        void Adicionar(TEntity entity);
        TEntity ObterId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Remover(TEntity entity);
        void Atualizar(TEntity entity);

    }
}
