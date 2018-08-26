using System;

namespace Federation.UWP.Objects.UI
{
    public class NavigationItem
    {
        public Type PageType { get; set; }

        public string Tag { get; set; }

        public string PageTitle { get; set; }

        public NavigationItem() { }

        public NavigationItem(string tag, Type pageType, string pageTitle)
        {
            PageTitle = pageTitle;
            Tag = tag;
            PageType = pageType;
        }
    }
}