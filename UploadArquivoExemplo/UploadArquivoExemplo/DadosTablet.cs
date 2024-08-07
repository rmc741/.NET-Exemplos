namespace UploadArquivoExemplo
{
    public class DadosTablet
    {
        public int Id { get; set; }
        public int EditalId { get; set; }
        public int Inscricao { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Dia { get; set; }
        public DateTime HoraAberturaPortoes { get; set; }
        public DateTime HoraFechamentoPortoes { get; set; }
        public DateTime HoraProva { get; set; }
        public string Concurso { get; set; }
        public string Cargo { get; set; }
        public string LocalProva { get; set; }
        public string Escola { get; set; }
        public string Andar { get; set; }
        public string Bloco { get; set; }
        public string Sala { get; set; }
        public string Endereco { get; set; }
        public string? Obs { get; set; }
    }
}
