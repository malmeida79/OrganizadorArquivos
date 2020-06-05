using System.ComponentModel;

namespace OrganizadorLog
{
    public enum EnumTipoLog
    {
        [Description("Grava qualquer tipo de log.")]
        Geral = 0,
        [Description("Aplicação parou!")]
        ErroCritico = 1,
        [Description("Ocorreu um erro!")]
        Erro = 2,
        [Description("Algum serviço falhou.")]
        Falha = 3,
        [Description("Poderá ocorrer erro se ...")]
        Warning = 4,
        [Description("Registros e controles internos.")]
        Controle = 5,
        [Description("Apenas informativo.")]
        Informacao = 6
    }
}
