using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Federation.PCL.Objects {
    public abstract class BaseObject {
        public enum RACE {
            FEDERATION,
            ROMULAN,
            KLINGON,
            FERENGI,
            CARDASSIAN
        };

        public abstract RACE RaceType { get; }

        public enum OBJECT {
            SHIP,
            PLANET
        };

        public abstract OBJECT ObjectType { get; }

        public abstract int Attack { get; }

        public abstract int Defense { get; }

        public abstract int DilithiumCostPerTurn { get; }

        public abstract string Description { get; }

        public abstract string TextureName { get; }

        public string GetTextureName(string texture) { return String.Format("/Assets/{0}s/{1}_{2}.png", ObjectType, RaceType, texture); }
    }
}