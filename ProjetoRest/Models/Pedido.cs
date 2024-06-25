namespace ProjetoRest.Models
{
    public class Pedido
    {
        #region "Attributes"
        private Guid _uid;
        private List<Item> _lstItem;
        private Cliente _faturador;
        private string _prTotal;
        private DateTime _dtEmissao;
        #endregion

        #region "Properties"
        public Guid Id {
            get { return _uid; }
        }

        public Cliente Faturador {
            get { return _faturador; }
            set
            {
                _faturador = value;
            }
        }

        //RN1: se _prTotal <= "0" || "" --> _prTotal = "Por Calcular"
        public string PrTotal
        {
            get { return _prTotal; }
            set
            {
                _prTotal = value.Trim();
                if (_prTotal == "0" || _prTotal == "") _prTotal = "Por Calcular";
            }
        }

        public DateTime DtEmissao
        {
            get { return _dtEmissao; }
        }
        #endregion

        #region "Constructors"
        public Pedido()
        {
            _lstItem = new List<Item>();
            Faturador = new Cliente();
            PrTotal = "";
            _dtEmissao = DateTime.Now;
        }
        #endregion

        #region "Methods"
        public string Total(List<Item> itens)
        {
            double p = 0;
            itens = _lstItem;
            foreach (Item i in itens) 
            {
                p += i.Preco;
            }
            PrTotal = p.ToString();
            return PrTotal;
        }

        #endregion
    }
}
