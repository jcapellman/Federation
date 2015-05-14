using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Federation.Objects.Ships {
    public abstract class BaseShip {
        public enum RACE {
            FEDERATION,
            ROMULAN,
            KLINGON,
            FERENGI,
            CARDASSIAN
        };

        public abstract RACE RaceType { get; }

        public abstract string Description { get; }

        public abstract string TextureName { get; }

        public string getTextureName(string texture) { return String.Format("/Assets/Ships/{0}_{1}.png", RaceType, texture); }
    }
}
