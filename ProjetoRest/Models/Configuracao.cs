namespace ProjetoRest.Models
{
    public class Configuracao
    {
        #region "Attributes"
        private string _conexao;
        private string _smtpIP;
        private string _useTLS;
        #endregion

        #region "Properties"
        public string Conexao
        {
            get { return _conexao; }
            set
            {
                _conexao = value;
            }
        }

        public string SmtpIP
        {
            get { return _smtpIP; }
            set 
            { 
                _smtpIP = value; 
            }
        }

        public string UseTLS
        {
            get { return _useTLS; }
            set 
            { 
                _useTLS = value; 
            }
        }
        #endregion
    }
}
