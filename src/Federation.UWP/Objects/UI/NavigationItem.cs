using System;

using Federation.UWP.Common;
using Federation.UWP.Enums;

namespace Federation.UWP.Objects.UI
{
    public class NavigationItem
    {
        public Type PageType { get; set; }

        public string Tag { get; set; }

        public string PageTitle { get; set; }

        public NavigationItem() { }

        public NavigationItem(string tag, Type pageType, LocalizedStrings pageTitle)
        {
            PageTitle = pageTitle.ToLocalizedString();
            Tag = tag;
            PageType = pageType;
        }
    }
}