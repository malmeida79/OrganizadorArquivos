using OrganizadorDomain.Model.Interface;

namespace OrganizadorDomain.Model
{
    class Pasta : IPasta
    {
        public string NomePasta { get; set; }
        public string CaminhoFisico { get; set; }
    }
}
