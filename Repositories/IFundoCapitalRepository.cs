using ApiRest.Models;
using System;
using System.Collections.Generic;


namespace ApiRest.Repositories
{
    public interface IFundoCapitalRepository
    {
        void Adicionar(FundoCapital fundo);
        void Alterar(FundoCapital fundo);
        IEnumerable<FundoCapital> ListarFundos();
        FundoCapital ObeterPorID(Guid id);
        void RemoverFundo(FundoCapital fundo);
    }
}
  