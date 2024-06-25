namespace ProjetoRest.Models
{
    public class Comida : Item
    {
        #region "Attributes"
        private string _acompanhamento;
        #endregion

        #region "Properties"

        //RN1: se _acompanhamento = "" --> _acompanhamento = "Indisponível"
        public string Acompanhamento
        {
            get { return _acompanhamento; }
            set 
            {
                _acompanhamento = value.Trim(); 
                if (_acompanhamento == "") _acompanhamento = "Indisponível";
            }
        }
        #endregion

        #region "Constructors"
        public Comida() : base()
        {
            Acompanhamento = "";
        }

        #endregion

        #region "Methods"
        #endregion
    }
}
