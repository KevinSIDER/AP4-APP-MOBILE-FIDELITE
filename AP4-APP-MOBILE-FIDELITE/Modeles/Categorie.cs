using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Categorie
    {
        #region Attributs

        private int _id;
        private string _nomCategorie;
        private string _urlImage;

        #endregion

        #region Constructeurs

        public Categorie() { }
        public Categorie(int id, string nomCategorie, string urlImage)
        {
            _id = id;
            _nomCategorie = nomCategorie;
            _urlImage = urlImage;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        [JsonProperty("nomCategorie")]
        public string nomCategorie
        {
            get => _nomCategorie; 
            set => _nomCategorie = value; 
        }

        [JsonProperty("urlImage")]
        public string urlImage 
        {
            get => _urlImage; 
            set => _urlImage = value; 
        }

        #endregion
    }
}
