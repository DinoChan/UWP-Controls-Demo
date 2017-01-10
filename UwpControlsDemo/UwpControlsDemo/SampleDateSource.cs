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
            var group = new PageItemGroup("ContentControl");

            group.Items.Add(new PageItem { Title = "Mage" });
            group.Items.Add(new PageItem { Title = "C" });
            group.Items.Add(new PageItem { Title = "A" });
            group.Items.Add(new PageItem { Title = "RRR" });
            group = new PageItemGroup("Layout");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });

            group = new PageItemGroup("Pages");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });

            group = new PageItemGroup("Header");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });

            group = new PageItemGroup("Title");
            group.Items.Add(new PageItem { Title = "HTRDdf" });
            group.Items.Add(new PageItem { Title = "CTRE" });
            group.Items.Add(new PageItem { Title = "ewtetrt" });
            return pages;
        }
    }
}
