using Federation.UWP.Enums;

namespace Federation.UWP.Common
{
    public static class ExtensionMethods
    {
        public static string ToLocalizedString(this LocalizedStrings name) => Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView().GetString(name.ToString());
    }
}