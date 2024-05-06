using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_APP_MOBILE_FIDELITE.Modeles
{
    public class Blason
    {
        #region Attributs

        private string _nomBlason;
        private double _montantAchats;

        #endregion

        #region Constructeurs

        public Blason() { }

        public Blason(string leNomBlason, double leMontantAchats)
        {
            _nomBlason = leNomBlason;
            _montantAchats = leMontantAchats;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("nomBlason")]
        public string NomBlason
        {
            get => _nomBlason;
            set => _nomBlason = value;
        }


        [JsonProperty("montantAchats")]
        public double MontantAchats
        {
            get => _montantAchats;
            set => _montantAchats = value;
        }

        #endregion
    }
}