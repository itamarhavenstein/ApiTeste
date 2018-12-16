using System.Collections.Generic;

namespace Cadastro
{
    public class ResultadoOperacao : IResultadoOperacao
    {
        private string PropriedadeNome;
        private string ErroMensagem;
        private string ErroCodigo;
        private bool Valido;

        public string getPropriedadeNome() { return PropriedadeNome; }
        public void setPropriedadeNome(string propriedadeNome) { PropriedadeNome = propriedadeNome; }
        public string getErroMensagem() { return ErroMensagem; }
        public void setErroMensagem(string erroMensagem) { ErroMensagem = erroMensagem; }
        public string getErroCodigo() { return ErroMensagem; }
        public void setErroCodigo(string erroCodigo) { ErroCodigo = erroCodigo; }
        public bool GetValido() { return Valido; }
        public void setValido(bool valido) { Valido = valido; }

        public ResultadoOperacao() { }
        public ResultadoOperacao(string propriedadeNome, string erroMensagem, string erroCodigo)
        {
            PropriedadeNome = propriedadeNome;
            ErroMensagem = erroMensagem;
            ErroCodigo = erroCodigo;
        }
      
    }
}
