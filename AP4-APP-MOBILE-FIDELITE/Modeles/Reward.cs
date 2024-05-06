using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Reward
    {
        #region Attributs

        private int _id;
        private string _nomRecompense;
        private int _pointsNecessaires;
        private int _leProduit;

        #endregion

        #region Constructeurs

        public Reward() { }

        public Reward(int id, string leNomRecompense, int nbrPointsNecessaires, int leProduit)
        {
            _id = id;
            _nomRecompense = leNomRecompense;
            _pointsNecessaires = nbrPointsNecessaires;
            _leProduit = leProduit;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        [JsonProperty("nomRecompense")]
        public string NomRecompense
        {
            get => _nomRecompense;
            set => _nomRecompense = value;
        }

        [JsonProperty("pointsNecessaires")]
        public int PointsNecessaires
        {
            get => _pointsNecessaires;
            set => _pointsNecessaires = value;
        }

        [JsonProperty("leProduit")]
        public int LeProduit
        {
            get => _leProduit;
            set => _leProduit = value;
        }
    }

    #endregion
}