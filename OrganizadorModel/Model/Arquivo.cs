using OrganizadorDomain.Model.Interface;

namespace OrganizadorDomain.Model
{
    public class Arquivo : IArquivo
    {
        public string Nome { get; set; }
        public string Extensao { get; set; }
        public string Tamanho { get; set; }
        public string CaminhoFisico { get; set; }
    }
}
