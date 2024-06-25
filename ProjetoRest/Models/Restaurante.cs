namespace ProjetoRest.Models
{
    public class Restaurante
    {
        #region "Attributes"
        private Guid _uid;
        private List<Pedido> _lstPedidos;
        private string _nome;
        private Admin _dono;
        private string _endereco;
        private DateTime _dtCriacao;
        private TimeOnly _hrAbertura;
        private TimeOnly _hrEncerramento;
        #endregion

        #region "Properties"
        public Guid Uid { get { return _uid; } }

        //RN1: se _nome < 3 --> _nome = "Por Estabelecer"
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value.Trim();
                if (_nome.Length < 3) _nome = "Por Estabelecer";
            }
        }

        public Admin Dono
        {
            get { return _dono; }
            set
            {
                _dono = value;
            }
        }

        //RN2: se _endereco < 6 --> _endereco = "Não Atribuído"
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                _endereco = value.Trim();
                if (_endereco.Length < 6) _endereco = "Não Atribuído";
            }
        }

        public DateTime DtCriacao
        {
            get { return _dtCriacao; }
        }

        public TimeOnly HrAbertura
        {
            get { return _hrAbertura; }
            set
            {
                _hrAbertura = value;
            }
        }

        public TimeOnly HrEncerramento
        {
            get { return _hrEncerramento; }
            set
            {
                _hrEncerramento = value;
            }
        }
        #endregion

        #region "Constructors"
        public Restaurante()
        {
            _uid = Guid.NewGuid();
            _lstPedidos = new List<Pedido>();
            Nome = "";
            Dono = new Admin();
            Endereco = "";
            HrAbertura = new TimeOnly(8, 0);
            HrEncerramento = new TimeOnly(20, 0);
        }
        #endregion

        #region "Methods"
        #endregion
    }
}
