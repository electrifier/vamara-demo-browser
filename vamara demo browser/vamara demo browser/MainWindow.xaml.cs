using Microsoft.UI.Composition;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System;
using vamara_demo_browser.Pages;
using Microsoft.UI.Xaml.Hosting;

namespace vamara_demo_browser;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(), nq}}")]
public sealed partial class MainWindow : Window
{
    //private Compositor _compositor;
    private SpriteVisual _bgVisual;
    private SpriteVisual _fgVisual;

    public bool GuruMeditationMode { get; set; } = true; 

    public MainWindow()
    {
        Debug.WriteLine("MainWindow ctor()");
        Debug.IndentLevel += 2;

        try 
        {
            //InitializeComponent();
            // add Command "F5" to open DevTools / Close the window
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Exception in MainWindow constructor: " + ex);
            throw;
        }


        // Window.Current.SetTitleBar(AppTitleBar);   // TODO: 19/03/26 - Custom TitleBar implementieren
        //        Window.Current.SizeChanged += OnWindowSizeChanged;

        //        _bgVisual = ElementCompositionPreview.GetElementVisual(BackgroundLayer) as SpriteVisual;
        //        _fgVisual = ElementCompositionPreview.GetElementVisual(ForegroundLayer) as SpriteVisual;

        //OnLoaded += OnLoaded;

        //RootNavigationView.SelectionChanged += NavigationView_SelectionChanged;
        // TODO: Add event handlers for navigation view selection changes and settings selection
        //       // NavigationView initialisiert → jetzt direkt zur AboutPage navigieren
        //       RootNavigationView.Loaded += (_, __) =>
        //       {
        //           RootNavigationView.SelectedItem = RootNavigationView.MenuItems
        //               .OfType<NavigationViewItem>()
        //               .FirstOrDefault(i => (string)i.Tag == "AboutPage");
        //
        //           ContentFrame.Navigate(typeof(Pages.AboutPage));
        //       };

        //var sun = _sunService.GetSunPosition(DateTimeOffset.Now, lat, lon);
    }

    private void InitializeComponent()
    {
        //DebugSettings.ReferenceEquals(this, null);
        Debug.WriteLine("InitializeComponent called");
    }



    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        // TODO: 19/03/26 - Parallax-Effekt implementieren
        //        _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
        //
        //        _bgVisual = ElementCompositionPreview.GetElementVisual(BackgroundLayer) as SpriteVisual;
        //        _fgVisual = ElementCompositionPreview.GetElementVisual(ForegroundLayer) as SpriteVisual;
        //
        //        UpdateParallax(Window.Current.Bounds.Width);
    }

    private void OnWindowSizeChanged(object sender, WindowSizeChangedEventArgs e)
    {
        UpdateParallax(e.Size.Width);
    }

    private void UpdateParallax(double width)
    {
        // Parallax-Faktor abhängig von Fensterbreite
        float bgOffset = (float)(width * -0.02);   // Hintergrund bewegt sich wenig
        float fgOffset = (float)(width * 0.04);    // Vordergrund bewegt sich stärker

        _bgVisual.Offset = new Vector3(bgOffset, 0, 0);
        _fgVisual.Offset = new Vector3(fgOffset, 0, 0);
    }


    // protected override void OnActivated(WindowActivatedEventArgs args)
    // {
    //     base.OnActivated(args);
    //     if (args.WindowActivationState == WindowActivationState.CodeActivated ||
    //         args.WindowActivationState == WindowActivationState.PointerActivated)
    //     {
    //         this.AppWindow.Resize(new Windows.Graphics.SizeInt32(Width, Height));
    //     }
    // }

    //    private void OnHeaderTapped(object sender, TappedRoutedEventArgs e)
    //    {
    //        NavView.SelectedItem = null;
    //        ContentFrame.Navigate(typeof(StartPage));
    //    }


    private void RootNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        try
        {
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
                return;
            }

            if (args.SelectedItem is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "AboutPage":
                        ContentFrame.Navigate(typeof(AboutPage));
                        break;
                    case "FileExplorerPage":
                        ContentFrame.Navigate(typeof(FileExplorerPage));
                        break;
                    default:
                        Debug.Fail("RootNavigationView_SelectionChanged: Unknown Tag to navigate to");
                        break;
                }
            }

            Debug.Print("RootNavigationView_SelectionChanged: Navigated to {0}", args.SelectedItem);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private void NavigationView_SelectionChanged(object sender, NavigationViewSelectionChangedEventArgs args)
    {
        RootNavigationView_SelectionChanged(sender as NavigationView, args);
    }

    private string GetDebuggerDisplay()
    {
        return new StringBuilder().AppendLine("{this}").Append(GetDebuggerDisplay()).ToString();
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