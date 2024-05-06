using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Product
    {
        #region Attributs

        private int _id; 
        private string _nom_produit;
        private double _prix_produit;
        private int _points_fidelite; 
        private string _image_url; 

        #endregion

        #region Constructeurs

        public Product() { }

        public Product(int id, string nom_produit, double prix_produit, int points_fidelite, string image_url)
        {
            _id = id;
            _nom_produit = nom_produit;
            _prix_produit = prix_produit;
            _points_fidelite = points_fidelite;
            _image_url = image_url;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        [JsonProperty("nomProduit")]
        public string NomProduit
        {
            get => _nom_produit;
            set => _nom_produit = value;
        }

        [JsonProperty("prixProduit")]
        public double PrixProduit
        {
            get => _prix_produit;
            set => _prix_produit = value;
        }

        [JsonProperty("pointsFidelite")]
        public int PointsFidelite
        {
            get => _points_fidelite;
            set => _points_fidelite = value;
        }

        [JsonProperty("imageUrl")]
        public string ImageUrl
        {
            get => _image_url;
            set => _image_url = value; 
        }

        #endregion
    }
}
