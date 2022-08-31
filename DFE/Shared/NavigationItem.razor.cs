using Microsoft.AspNetCore.Components;

namespace DFE.Shared {
    public partial class NavigationItem {
        [Parameter]
        public NavItemProps Props { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool Expanded {
            get {
                return Props.Expanded;
            }
            set {
                Props.Expanded = value;
            }
        }

        [Parameter]
        public EventCallback<bool> ExpandedChanged { get; set; }
    }
    public class NavItemProps {
        public string Name { get; set; }
        public bool New { get; set; } = false;
        public bool Updated { get; set; } = false;
        public bool Expanded { get; set; } = false;
        public string Path { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public NavItemProps[] Children { get; set; }
    }
}
