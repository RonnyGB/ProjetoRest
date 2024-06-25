namespace ProjetoRest.Models
{
    public class Item
    {
        #region "Attributes"
        private Guid _uid;
        private string _nome;
        private string _descricao;
        private double _preco;
        #endregion

        #region "Properties"
        public Guid Uid
        {
            get { return _uid; }
        }

        //RN1: se _nome = "" --> _nome = "A definir"
        public string Nome
        {
            get { return _nome; }
            set 
            { 
                _nome = value.Trim(); 
            }
        }

        //RN2: se _descricao = "" --> _descricao = "Sem descrição"
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                _descricao = value.Trim();
                if (_descricao == "") _descricao = "Sem descrição";
            }
        }

        //RN3: _preco > 0 --> _preco = 1
        public double Preco
        {
            get { return _preco; }
            set
            {
                _preco = value;
                if (_preco <= 0) _preco = 1;
            }
        }
        #endregion

        #region "Constructor"
        public Item ()
        {
            _uid = Guid.NewGuid();
            Nome = "";
            Descricao = "";
            Preco = 0;
        }
        #endregion

        #region "Methods"
        #endregion
    }
}
