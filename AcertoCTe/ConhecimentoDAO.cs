using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Net;
using System.Text;

namespace AcertoCTe
{
    class ConhecimentoDAO
    { //teste
        public static DataTable pesquisarTransferencia(int numCar, string empresa)
        {
            string sql = "select DTNFTRANSF,numped,codfilial,numnota,data,dtentrega from pcpedc where numcar=" + numCar + " and codfilial=21";

            return MetodosDB.ExecutaSelect(sql, empresa);
        }

        public static DataTable pesquisarCancelamento(int numCar, string empresa)
        {
            string sql = "select NUMTRANSVENDACONHEC,a.chavenfe,a.chavecte,a.numnota,a.especie,a.vltotal,a.dtsaida from pcnfsaid a " +
                " where numcar=" + numCar + " and codfilial in (21,80)";

            return MetodosDB.ExecutaSelect(sql, empresa);
        }

        public static void alterarDados(List<ConhecimentoVO> itens, UsuarioVO usuario)
        {
            OracleConnection conexao = new OracleConnection();

            if (usuario.Empresa == "VEP")
                conexao = ConexaoDB.GetConexaoProdVEP();
            else
                conexao = ConexaoDB.GetConexaoProd();

            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                foreach (ConhecimentoVO item in itens)
                {
                    OracleCommand cmd = conexao.CreateCommand();
                    cmd.Transaction = transacao;

                    if (item.Tipo == TipoAtualizacao.Transferencia)
                    {
                        cmd.CommandText = "UPDATE pcpedc set DTNFTRANSF = null where codfilial = :codfilial and numnota = :numnota and numcar = :numcar";
                        cmd.Parameters.AddWithValue(":codfilial", item.Filial);
                        cmd.Parameters.AddWithValue(":numnota", item.Nota);
                        cmd.Parameters.AddWithValue(":numcar", item.Carregamento);
                    }
                    else if (item.Tipo == TipoAtualizacao.Cancelamento)
                    {
                        cmd.CommandText = "UPDATE pcnfsaid set NUMTRANSVENDACONHEC = null where codfilial = :codfilial and numnota = :numnota and numcar = :numcar";
                        cmd.Parameters.AddWithValue(":codfilial", item.Filial);
                        cmd.Parameters.AddWithValue(":numnota", item.Nota);
                        cmd.Parameters.AddWithValue(":numcar", item.Carregamento);
                    }
                    cmd.ExecuteNonQuery();

                    OracleCommand log = conexao.CreateCommand();
                    log.Transaction = transacao;
                    log.CommandText = " INSERT INTO ti.fstlogcte (NUMNOTA,CODFILIAL,TIPO,DTALTERACAO,USUARIO,COMPUTADOR)  " +
                        " VALUES (:NUMNOTA, :CODFILIAL, :TIPO, sysdate, :USUARIO, :COMPUTADOR)";
                    log.Parameters.AddWithValue(":NUMNOTA", item.Nota);
                    log.Parameters.AddWithValue(":CODFILIAL", item.Filial);

                    if (item.Tipo == TipoAtualizacao.Cancelamento)
                        log.Parameters.AddWithValue(":TIPO", "C");
                    else if (item.Tipo == TipoAtualizacao.Transferencia)
                        log.Parameters.AddWithValue(":TIPO", "T");

                    log.Parameters.AddWithValue(":USUARIO", usuario.Matricula);
                    log.Parameters.AddWithValue(":COMPUTADOR", Dns.GetHostName());

                    log.ExecuteNonQuery();
                }

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
