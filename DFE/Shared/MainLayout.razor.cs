using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Radzen.Blazor;
using DFE.Infrastructure.Library.UI;
using Microsoft.JSInterop;
using Radzen;

namespace DFE.Shared {
    public partial class MainLayout {
        RadzenSidebar sidebar0;
        RadzenBody body0;
        bool sidebarExpanded = true;
        bool bodyExpanded = false;
        [Inject]
        NavigationManager UriHelper { get; set; }
        [Inject]
        ThemeService ThemeService { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        
        public NavItemProps[] navIts;
        public MainLayout() {
            loadNavs();
        }
        protected override void OnInitialized() {

            ThemeService.Initialize(UriHelper);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        void FilterPanelMenu(ChangeEventArgs args) {

        }

        void ChangeTheme(object value) {
            var url = UriHelper.GetUriWithQueryParameter("theme", $"{value}");
            UriHelper.NavigateTo(url, true);
        }

        async Task PanelMenuClick(MenuItemEventArgs args) {
            if (args.Path == "/") {
                await JSRuntime.InvokeVoidAsync("document.location.reload");
            }
        }
        private void loadNavs() {
            navIts = new NavItemProps[3];
            navIts[0] = new NavItemProps {
                Name = "Overview",
                Path = "/",
                Icon = "&#xe88a"
            };
            navIts[1] = new NavItemProps {
                Name = "Projects",
                Path = "/projects",
                Icon = "&#xe94c"
            };
            navIts[2] = new NavItemProps {
                Name = "Schema",
                Path = "/schema",
                Icon = "&#xf1be"
            };
        }
    }
}
