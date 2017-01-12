using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpControlsDemo
{
    public static class SampleDateSource
    {
        public static IEnumerable<PageItemGroup> LoadPages()
        {
            List<PageItemGroup> pages = new List<PageItemGroup>();
            var group = new PageItemGroup("Buttons");

            group.Items.Add(new PageItem { Title = "Button" ,Type=typeof(ButtonPage) });
            group.Items.Add(new PageItem { Title = "HyperlinkButton" });
            group.Items.Add(new PageItem { Title = "RepeatButton" });
            group.Items.Add(new PageItem { Title = "RRR" });
            pages.Add(group);
            group = new PageItemGroup("Layout");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });
            pages.Add(group);
            group = new PageItemGroup("Pages");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });
            pages.Add(group);
            group = new PageItemGroup("Header");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });
            pages.Add(group);
            group = new PageItemGroup("Title");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });
            pages.Add(group);
            return pages;
        }
    }
}
