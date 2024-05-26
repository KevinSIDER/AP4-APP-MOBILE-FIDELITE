using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Commander
    {
        #region Attributs

        private int _id;
        private int _iduser;
        private int _leProduit;
        private int _laCommande;
        private int _quantite;

        #endregion

        #region Constructeurs

        public Commander() { }

        public Commander(int id, int id_user, int le_produit, int la_commande, int la_quantite)
        {
            _id = id;
            _iduser = id_user;
            _leProduit = le_produit;
            _laCommande = la_commande;
            _quantite = la_quantite;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int UserID
        {
            get => _iduser;
            set => _iduser = value;
        }

        [JsonProperty("Id")]
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [JsonProperty("leProduit")]
        public int LeProduit
        {
            get => _leProduit;
            set => _leProduit = value;
        }

        [JsonProperty("laCommande")]
        public int LaCommande
        {
            get => _laCommande;
            set => _laCommande = value;
        }

        [JsonProperty("quantite")]
        public int Quantite
        {
            get => _quantite;
            set => _quantite = value;
        }

        #endregion
    }
}
