using System.Web.Http;

namespace Cadastro.Api.Controllers
{
    [RoutePrefix("cidade")]
    public class CidadeController : ApiController
    {
        private CidadeServicos CidadeApp = null;

        public CidadeController(CidadeServicos cidadeApp)
        {
            CidadeApp = cidadeApp;
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
