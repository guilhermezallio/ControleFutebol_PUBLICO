using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.AplicativoDesktop
{
    public class TituloFormularios
    {
        public static string GetTituloFormulario(string nomeObjeto)
        {
            switch (nomeObjeto.ToUpper())
            {
                case "FRMPRINCIPAL":
                    return "Aplicativo de Controle de Futebol - PARTIDAS E CAIXA!";
                case "FRMABRIRCAIXA":
                    return "Abrir Caixa!";
                case "FRMCADASTRARPELADA":
                    return "Cadastro de Partida";
                case "FRMCADASTRODESPESA":
                    return "Cadastro de Despesas";
                case "FRMCADASTROFORMAPAGAMENTO":
                    return "Cadastro de Forma de Pagamento";
                case "FRMCADASTROMENSALIDADEMENSALISTA":
                    return "Cadastro de Mensalidade do Mensalista";
                case "FRMCADASTROMENSALISTA":
                    return "Cadastro de Mensalista";
                case "FRMCADASTRORECEITA":
                    return "Cadastro de Receita Diversa";
                case "FRMCADASTROTIPOPAGAMENTO":
                    return "Cadastro de Tipo de Pagamento";
                case "FRMFECHARCAIXA":
                    return "Fechar Caixa!";
                case "FRMMANUTENCAOCAIXA":
                    return "Manutenção de Caixa";
                case "FRMMANUTENCAODESPESA":
                    return "Manutenção de Despesas Diversas";
                case "FRMMANUTENCAOFORMAPAGAMENTO":
                    return "Manutenção de Formas de Pagamento do Sistema";
                case "FRMMANUTENCAOMENSALIDADEMENSALISTA":
                    return "Manutenção de Mensalidades do Mensalista";
                case "FRMMANUTENCAOMENSALISTA":
                    return "Manutenção de Mensalistas";
                case "FRMMANUTENCAOPARTIDA":
                    return "Manutenção de Partidas";
                case "FRMMANUTENCAORECEITA":
                    return "Manutenção de Receitas Diversas";
                case "FRMMANUTENCAOTIPOPAGAMENTO":
                    return "Manutenção de Tipos de Pagamento";
                case "FRMMOVIMENTACOESCAIXA":
                    return "Movimentação do Caixa";
                case "FRMTRANSFERIRSALDOCAIXA":
                    return "Transferir Saldo!";
                case "FRMQUESTAOCAIXA":
                    return "Caixa!";
                case "FRMQUESTAOMENSALIDADE":
                    return "Mensalidade";
                default:
                    return "";
            }
        }
    }
}
