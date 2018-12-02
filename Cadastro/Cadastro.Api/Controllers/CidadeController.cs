using System.Web.Http;

namespace Cadastro.Api.Controllers
{
    [RoutePrefix("cidade")]
    public class CidadeController : ApiController
    {
        public CidadeController()
        {

        }
        private readonly CidadeServicos CidadeApp;

        public CidadeController(CidadeServicos cidadeApp)
        {
            cidadeApp = CidadeApp;
        }


        [Route("inserir")]
        [HttpPost]
        public ResultadoOperacao Inserir(CidadeDTO cidade)
        {
            var retorno = CidadeApp.InserirCidade(cidade);
            return retorno;
        }
    }
}
