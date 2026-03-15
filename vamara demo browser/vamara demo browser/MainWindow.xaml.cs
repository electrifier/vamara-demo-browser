using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Text;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace vamara_demo_browser;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        //this.navigationView.SelectionChanged += NavigationView_SelectionChanged;

        // "NavigationView_SelectionChanged";    
        // TODO: Add event handlers for navigation view selection changes and settings selection
        // 
    }

    //private void InitializeComponent()
    //{
    //    DebugSettings.ReferenceEquals(this, null);
    //
    //    Debug.WriteLine("InitializeComponent called");
    //}

    private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        StringBuilder strBuf = new();

        try
        {
            //                if (args.IsSettingsSelected)
            //                {
            //                    // Handle settings selection
            //                    return;
            //                }
        }
        catch (Exception)
        {

            throw;
        }

    }

    // StringBuilder sb = new();
    // var dbgSettings = DebugSettings.Equals(args, sender);

    //        public void OpenBrowser(object sender, RoutedEventArgs e)
    //        {
    //            var browserWindow = new BrowserWindow();
    //            browserWindow.Activate();
    //        }

    //public bool NavigationView_SelectionChanged(object sender, NavigationViewSelectionChangedEventArgs e)
    //{
    //    if (e.IsSettingsSelected)
    //    {
    //        // Handle settings selection
    //        return;
    //    }
    //    var selectedItem = e.SelectedItem as NavigationViewItem;
    //    if (selectedItem != null)
    //    {
    //        var tag = selectedItem.Tag as string;
    //        switch (tag)
    //        {
    //            case "home":
    //                // Navigate to home page
    //                break;
    //            case "favorites":
    //                // Navigate to favorites page
    //                break;
    //            case "history":
    //                // Navigate to history page
    //                break;
    //            default:
    //                break;
    //        }
    //    }
    //}
}