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
        private string _etat;

        #endregion

        #region Constructeurs

        public Commande() { }
        public Commande(int id, string etat)
        {
            _id = id;
            _etat = etat;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        [JsonProperty("etat")]
        public string Etat
        {
            get => _etat;
            set => _etat = value;
        }

        #endregion
    }
}
