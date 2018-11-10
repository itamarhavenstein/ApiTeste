namespace Cadastro
{
    public class Pessoa : ClasseBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public long IdEndereco { get; set; }
        public virtual Endereco Enderecos { get; set; }

        public Pessoa() { }
    }
}
