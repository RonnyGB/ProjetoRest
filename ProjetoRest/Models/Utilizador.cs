namespace ProjetoRest.Models
{
    public class Utilizador
    {
        #region "Attributes"
        private Guid _uid;
        private string _userName;
        private string _email;
        private string _password;
        private int _nivelAcesso;
        #endregion

        #region "Properties"
        public Guid Uid { get { return _uid; } }

        //RN1: _username != _email --> _username = "Guest"
        public string Username 
        { 
            get { return _userName; }
            set 
            {
                _userName = value.Trim(); 
                if (_userName == _email) _userName = "Guest";
            }
        }

        //RN2: se _email < 6 --> _email = guest@guest.com
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value.Trim();
                if (_email.Length < 6) _email = "guest@guest.com";
            }
        }

        //RN3: se _password < 4 --> _password = guestpassword
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value.Trim();
                if (_password.Length < 4) _password = "guestpassword";
            }
        }

        //RN4: _nivelAcesso > -1 && _nivelAcesso < 3 --> _nivelAcesso = 0
        public int NivelAcesso
        {
            get { return _nivelAcesso; }
            set
            {
                _nivelAcesso = value;
                if (_nivelAcesso < 0 || _nivelAcesso > 2)
                {
                    _nivelAcesso = 0;
                }
            }
        }
        #endregion

        #region "Constructor"
        public Utilizador()
        {
            _uid = Guid.NewGuid();
            Username = "";
            Email = "";
            Password = "";
            NivelAcesso = 0;
        }
        #endregion
    }
}