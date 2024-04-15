using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Produit
    {
        #region Attributs

        private int _idUser;
        private string _nomProduit;
        private int _prixProduit;
        private int _pointsFidelite;
        private string _imageUrl;

        #endregion

        #region Constructeurs

        public Produit() { }

        public Produit(int id, string nomProduit, int prixProduit, int pointsFidelite, string imageUrl)
        {
            _idUser = id;
            _nomProduit = nomProduit;
            _prixProduit = prixProduit;
            _pointsFidelite = pointsFidelite;
            _imageUrl = imageUrl;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("Id")]
        public int idUser
        {
            get => _idUser;
            set => _idUser = value;
        }

        [JsonProperty("nomProduit")]
        public string NomProduit
        {
            get => _nomProduit;
            set => _nomProduit = value;
        }

        [JsonProperty("prixProduit")]
        public int PrixProduit
        {
            get => _prixProduit;
            set => _prixProduit = value;
        }

        [JsonProperty("pointsFidelite")]
        public int PointsFidelite
        {
            get => _pointsFidelite;
            set => _pointsFidelite = value;
        }

        [JsonProperty("imageUrl")]
        public string ImageUrl
        {
            get => _imageUrl;
            set => _imageUrl = value;
        }


        #endregion

        #region Methodes

        #endregion

    }
}