using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ApiRest.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ApiRest.Repositories {
    public class FundoCapitalRepository : IFundoCapitalRepository {
        
        public IEnumerable<Indicador> Get (
            [FromServices] IConfiguration config) {
            using (SqlConnection conexao =
                new SqlConnection (config.GetConnectionString ("BaseIndicadores"))) {
                
                //return conexao.Query<Indicador> ("SELECT * FROM dbo.Indicadores");
                

                public FundoCapitalRepository () {
                    _storage = new List<FundoCapital> ();
                }

                public void Adicionar (FundoCapital fundo) {
                    _storage.Add (fundo);
                }

                public void Alterar (FundoCapital fundo) {
                    conexao.Query<Indicador> ("UPDATE * FROM dbo.FundoCapital");
                }

                public IEnumerable<FundoCapital> ListarFundos () {
                    return conexao.Query<Indicador> ("SELECT * FROM dbo.FundoCapital");
                }

                public FundoCapital ObeterPorID (Guid id) {
                    return conexao.Query<Indicador> ("SELECT * FROM dbo.FundoCapital WHERE = {id}")
                }

                public void RemoverFundo (FundoCapital fundo) {
                    _storage.Remove (fundo);
                }
            }
        }
    }

    public IEnumerable<Indicador> Get (
        [FromServices] IConfiguration config) {
        using (SqlConnection conexao =
            new SqlConnection (config.GetConnectionString ("FundoCapitalTable"))) {
            return conexao.Query<Indicador> ("SELECT * FROM dbo.Indicadores");
        }
    }
}