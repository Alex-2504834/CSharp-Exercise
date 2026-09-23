using DesktopApp.Components.Tab1;
using DesktopApp.Components.Tab2;
using DesktopApp.Components.Tab3;
using DesktopApp.Components.Tab4;
using Microsoft.AspNetCore.Components;


namespace DesktopApp.Components.Layout;

public partial class MainTabs
{
    protected int ActiveMainTab { get; private set; }

    protected int[] ActiveSubTabs { get; } = [0, 0, 0, 0];

    protected string[] MainTabNames { get; } = ["Tab 1", "Tab 2", "Tab 3", "Tab 4"];

    protected string[][] SubTabNames { get; } =
        [
         ["Tab 1A", "Tab 1B", "Tab 1C"],
         ["Tab 2A", "Tab 2B", "Tab 2C"],
         ["Tab 3A", "Tab 3B", "Tab 3C"],
         ["Tab 4A", "Tab 4B", "Tab 4C"]
        ];

    private Type[][] TabComponents { get; } =
        [
            [typeof(Tab1A), typeof(Tab1B), typeof(Tab1C)],
            [typeof(Tab2A), typeof(Tab2B), typeof(Tab2C)],
            [typeof(Tab3A), typeof(Tab3B), typeof(Tab3C)],
            [typeof(Tab4A), typeof(Tab4B), typeof(Tab4C)]
        ];

    protected Type ActiveComponentType => TabComponents[ActiveMainTab][ActiveSubTabs[ActiveMainTab]];

    protected void SelectMainTab(int index) {
        ActiveMainTab = index;
    }

    protected void SelectSubTab(int index) {
        ActiveSubTabs[ActiveMainTab] = index;
    }
}