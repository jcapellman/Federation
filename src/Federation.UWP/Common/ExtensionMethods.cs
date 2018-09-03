using System;
using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Enums;

namespace Federation.UWP.Common
{
    public static class ExtensionMethods
    {
        public static string ToLocalizedString(this LocalizedStrings name) => 
            Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString(name.ToString());

        public static IEnumerable<Faction> FactionList => 
            Enum.GetNames(typeof(Faction)).Where(a => a != Faction.Unknown.ToString()).Select(a => (Faction)Enum.Parse(typeof(Faction), a));
    }
}