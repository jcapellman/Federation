using System;
using System.Collections.Generic;
using System.Linq;

using Federation.UWP.Enums;

namespace Federation.UWP.Common
{
    public static class ExtensionMethods
    {
        public static string ToLocalizedString(this LocalizedStrings name) => Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString(name.ToString());

        public static IEnumerable<Race> RaceList => Enum.GetNames(typeof(Race)).Where(a => a != Race.Unknown.ToString()).Select(a => (Race)Enum.Parse(typeof(Race), a));
    }
}