//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("aclara_meters.view.AclaraViewInstallConfirmation.xaml", "view/AclaraViewInstallConfirmation.xaml", typeof(global::aclara_meters.view.AclaraViewInstallConfirmation))]

namespace aclara_meters.view {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("view/AclaraViewInstallConfirmation.xaml")]
    public partial class AclaraViewInstallConfirmation : global::aclara_meters.util.BasePage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ContentView background_scan_page;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ColumnDefinition menu_controller_width;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::aclara_meters.view.TopBar TopBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label valorHEX;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ListView listaMTUread;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::aclara_meters.view.BottomBar BottomBar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Image shadoweffect;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ContentView ContentNav;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::aclara_meters.view.MenuView MenuOptions;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout backdark_bg;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator indicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Image dialog_open_bg;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ContentView turnoff_mtu_background;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::aclara_meters.view.DialogsView DialogView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AclaraViewInstallConfirmation));
            background_scan_page = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ContentView>(this, "background_scan_page");
            menu_controller_width = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ColumnDefinition>(this, "menu_controller_width");
            TopBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::aclara_meters.view.TopBar>(this, "TopBar");
            valorHEX = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "valorHEX");
            listaMTUread = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ListView>(this, "listaMTUread");
            BottomBar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::aclara_meters.view.BottomBar>(this, "BottomBar");
            shadoweffect = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Image>(this, "shadoweffect");
            ContentNav = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ContentView>(this, "ContentNav");
            MenuOptions = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::aclara_meters.view.MenuView>(this, "MenuOptions");
            backdark_bg = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "backdark_bg");
            indicator = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "indicator");
            dialog_open_bg = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Image>(this, "dialog_open_bg");
            turnoff_mtu_background = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ContentView>(this, "turnoff_mtu_background");
            DialogView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::aclara_meters.view.DialogsView>(this, "DialogView");
        }
    }
}
