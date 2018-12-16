using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;

namespace Cadastro
{
    public class CidadeValidador : AbstractValidator<Cidade>
    {
        private ICidadeRepositorio CidadeRepo;
        public CidadeValidador(ICidadeRepositorio cidadeApp)
        {
            CidadeRepo = cidadeApp;
        }

        public CidadeValidador()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("A cidade precisa ser informado.")
                .Must(ConfereNome)
                .WithMessage("Cidade já cadastrada.");
        }

        public ResultadoOperacao Validar(Cidade obj)
        {
            var cidade = new CidadeValidador();
            var retorno = new ResultadoOperacao();
            var resposta = cidade.Validate(obj);


            if (!resposta.IsValid)
            {       
                foreach (var failure in resposta.Errors)
                {
                    // Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                    var ret = new ResultadoOperacao(failure.PropertyName, failure.ErrorMessage, failure.ErrorCode);                                     
                    ret.setValido(resposta.IsValid);
                    return ret;
                }
            }
            retorno.setValido(true);
            return retorno;
        }

        private bool ConfereNome(string cidade)
        {
            var res = CidadeRepo.BuscarPorNome(cidade);
            return res;
        }
    }
}
