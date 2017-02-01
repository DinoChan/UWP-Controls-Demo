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

            group.Items.Add(new PageItem { Title = "Button", Type = typeof(ButtonPage) });
            group.Items.Add(new PageItem { Title = "HyperlinkButton", Type = typeof(HyperlinkButtonPage) });
            group.Items.Add(new PageItem { Title = "RepeatButton", Type = typeof(RepeatButtonPage) });
            pages.Add(group);
            group = new PageItemGroup("Collection/data controls");
            group.Items.Add(new PageItem { Title = "Flip view" });
            group.Items.Add(new PageItem { Title = "Grid view" });
            group.Items.Add(new PageItem { Title = "Hub" });
            group.Items.Add(new PageItem { Title = "Items control" });
            group.Items.Add(new PageItem { Title = "List view" });
            group.Items.Add(new PageItem { Title = "Semantic zoom" });
            pages.Add(group);
            group = new PageItemGroup("Flyouts");
            group.Items.Add(new PageItem { Title = "Context menu" });
            group.Items.Add(new PageItem { Title = "Flyout" });
            group.Items.Add(new PageItem { Title = "Menu flyout" });
            group.Items.Add(new PageItem { Title = "Popup menu" });
            group.Items.Add(new PageItem { Title = "Tooltip" });

            pages.Add(group);
            group = new PageItemGroup("Images");
            group.Items.Add(new PageItem { Title = "Image", Type = typeof(ImagePage) });
            pages.Add(group);
            group = new PageItemGroup("Graphics");
            group.Items.Add(new PageItem { Title = "Ellipse" });
            group.Items.Add(new PageItem { Title = "Path" });
            group.Items.Add(new PageItem { Title = "Rectangle" });
            pages.Add(group);

            group = new PageItemGroup("Layout controls");
            group.Items.Add(new PageItem { Title = "Border" });
            group.Items.Add(new PageItem { Title = "Canvas" });
            group.Items.Add(new PageItem { Title = "Flex box" });
            group.Items.Add(new PageItem { Title = "Canvas" });
            group.Items.Add(new PageItem { Title = "Scroll viewer" });
            group.Items.Add(new PageItem { Title = " Zooming scroll viewer" });
            group.Items.Add(new PageItem { Title = "StackPanel" });
            group.Items.Add(new PageItem { Title = "VariableSizedWrapGrid" });
            group.Items.Add(new PageItem { Title = "Viewbox" });
            pages.Add(group);

            group = new PageItemGroup("Navigation");
            group.Items.Add(new PageItem { Title = "Pivot" });
            group.Items.Add(new PageItem { Title = "WebView" });

            pages.Add(group);

            group = new PageItemGroup("Media controls");
            group.Items.Add(new PageItem { Title = "Media element" });
            pages.Add(group);

            group = new PageItemGroup("Progress controls");
            group.Items.Add(new PageItem { Title = "ProgressBar " });
            group.Items.Add(new PageItem { Title = "ProgressRing " });
            pages.Add(group);

            group = new PageItemGroup("Text controls");
            group.Items.Add(new PageItem { Title = "AutoSuggestBox" });
            group.Items.Add(new PageItem { Title = "PasswordBox " });
            group.Items.Add(new PageItem { Title = "RichEditBox " });
            group.Items.Add(new PageItem { Title = "SearchBox" });
            group.Items.Add(new PageItem { Title = "TextBlock" });
            group.Items.Add(new PageItem { Title = "TextBox" });
            group.Items.Add(new PageItem { Title = "TextBlock" });
            pages.Add(group);

            group = new PageItemGroup("Selection controls");
            group.Items.Add(new PageItem { Title = "CheckBox", Type = typeof(CheckBoxPage) });
            group.Items.Add(new PageItem { Title = "ToggleButton", Type = typeof(ToggleButtonPage) });
            group.Items.Add(new PageItem { Title = "ComboBox", Type = typeof(ComboBoxPage) });
            group.Items.Add(new PageItem { Title = "DatePicker", Type = typeof(DatePickerPage) });
            group.Items.Add(new PageItem { Title = "CalendarDatePicker", Type = typeof(CalendarDatePickerPage) });
            group.Items.Add(new PageItem { Title = "CalendarView", Type = typeof(CalendarViewPage) });
            group.Items.Add(new PageItem { Title = "ListBox", Type = typeof(ListBoxPage) });
            group.Items.Add(new PageItem { Title = "ListView", Type = typeof(ListViewPage) });
            group.Items.Add(new PageItem { Title = "RadioButton", Type = typeof(RadioButtonPage) });
            group.Items.Add(new PageItem { Title = "Slider", Type = typeof(SliderPage) });
            group.Items.Add(new PageItem { Title = "TimePicker", Type = typeof(TimePickerPage) });
            group.Items.Add(new PageItem { Title = "ToggleSwitch", Type = typeof(ToggleSwitchPage) });
            pages.Add(group);
            return pages;
        }
    }
}
