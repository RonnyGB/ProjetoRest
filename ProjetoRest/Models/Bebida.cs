namespace ProjetoRest.Models
{
    public class Bebida : Item
    {
        #region "Attributes"
        private string _tamanho;
        private string _extra;
        #endregion

        #region "Properties"
        //RN1: se _tamanho = "" --> _tamanho = "Pequeno"
        public string Tamanho
        {
            get { return _tamanho; }
            set
            {
                _tamanho = value.Trim();
                if (_tamanho == "") _tamanho = "Pequeno";
            }
        }

        //RN2: se _extra = "" --> _extra = "Nenhum"
        public string Extra
        {
            get { return _extra; }
            set
            {
                _extra = value.Trim();
                if (_extra == "") _extra = "Nenhum";
            }
        }
        #endregion

        #region "Constructors"
        public Bebida() : base() 
        {
            Tamanho = "";
            Extra = "";
        }
        #endregion

        #region "Methods"
        #endregion
    }
}
