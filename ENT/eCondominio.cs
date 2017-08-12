namespace ENT
{
    public class eCondominio
    {
        public string CondominioID { get; set; }
        public string Nome { get; set; }
        public int QtdBlocos { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public eCidade Cidade { get; set; }
    }
}