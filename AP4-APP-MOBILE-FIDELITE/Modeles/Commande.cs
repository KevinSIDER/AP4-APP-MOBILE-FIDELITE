using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Commande
    {
        #region Attributs

        private int _id;
        private string _nomCategorie;
        private string _urlImage;

        #endregion

        #region Constructeurs

        public Commande() { }
        public Commande(int id)
        {
            _id = id;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int ID
        {
            get => _id;
            set => _id = value;
        }  

        #endregion
    }
}
