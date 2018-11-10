namespace Cadastro
{
    public class Endereco : ClasseBase
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public long IdCidade { get; set; }
        public virtual Cidade Cidades { get; set; }
        public long IdEstado { get; set; }
        public virtual Estado Estados { get; set; }
    }
}
