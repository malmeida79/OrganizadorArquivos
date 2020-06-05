namespace OrganizadorLog
{
    public class RegistroLog
    {
        public bool logAtivo = false;
        public int nivelLog = 0;

        public RegistroLog()
        {
            logAtivo = Properties.log.Default.Ativo;
            nivelLog = Properties.log.Default.NivelLog;
        }

        /// <summary>
        /// Gravação de logs
        /// </summary>
        /// <param name="msgLog">Mensagem a ser gravada</param>
        /// <param name="tipoLog">tipo de log</param>
        public void gravarLog(string msgLog, string modulo, EnumTipoLog tipoLog)
        {
            // devera gravar log apenas se estiver ativo e com nivel de log
            // liberado.
            if (logAtivo && nivelLog <= (int)tipoLog)
            {

            }
        }
    }
}
