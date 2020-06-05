namespace OrganizadorDomain.Model.Interface
{
    public interface IArquivo
    {
        string CaminhoFisico { get; set; }
        string Extensao { get; set; }
        string Nome { get; set; }
        string Tamanho { get; set; }
    }
}