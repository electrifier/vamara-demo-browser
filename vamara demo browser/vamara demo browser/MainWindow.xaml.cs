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

//        try 
//        {
//            //InitializeComponent();
//            // add Command "F5" to open DevTools / Close the window
//        }
//        catch (Exception ex)
//        {
//            Debug.WriteLine("Exception in MainWindow constructor: " + ex);
//            throw;
//        }
//

        //  Window.Current.SetTitleBar(AppTitleBar);   // TODO: 19/03/26 - Custom TitleBar implementieren
        //        Window.Current.SizeChanged += OnWindowSizeChanged;

        //        _bgVisual = ElementCompositionPreview.GetElementVisual(BackgroundLayer) as SpriteVisual;
        //        _fgVisual = ElementCompositionPreview.GetElementVisual(ForegroundLayer) as SpriteVisual;

        //  OnLoaded += OnLoaded;

        //  RootNavigationView.SelectionChanged += NavigationView_SelectionChanged;
        //  TODO: Add event handlers for navigation view selection changes and settings selection
        //       // NavigationView initialisiert → jetzt direkt zur AboutPage navigieren
        //       RootNavigationView.Loaded += (_, __) =>
        //       {
        //           RootNavigationView.SelectedItem = RootNavigationView.MenuItems
        //               .OfType<NavigationViewItem>()
        //               .FirstOrDefault(i => (string)i.Tag == "AboutPage");
        //
        //           ContentFrame.Navigate(typeof(Pages.AboutPage));
        //       };

        //  var sun = _sunService.GetSunPosition(DateTimeOffset.Now, lat, lon);
    }

    private void UpdateParallax(double width)
    {
        // Parallax-Faktor abhängig von Fensterbreite
        float bgOffset = (float)(width * -0.02);   // Hintergrund bewegt sich wenig
        float fgOffset = (float)(width * 0.04);    // Vordergrund bewegt sich stärker

        _bgVisual.Offset = new Vector3(bgOffset, 0, 0);
        _fgVisual.Offset = new Vector3(fgOffset, 0, 0);
    }


    //  protected override void OnActivated(WindowActivatedEventArgs args)
    //  {
    //      base.OnActivated(args);
    //      if (args.WindowActivationState == WindowActivationState.CodeActivated ||
    //          args.WindowActivationState == WindowActivationState.PointerActivated)
    //      {
    //          this.AppWindow.Resize(new Windows.Graphics.SizeInt32(Width, Height));
    //      }
    //  }

    //  private void RootNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    //  {
    //      try
    //      {
    //          if (args.IsSettingsSelected)
    //          {
    //              ContentFrame.Navigate(typeof(SettingsPage));
    //              return;
    //          }
    //  
    //          if (args.SelectedItem is NavigationViewItem item)
    //          {
    //              switch (item.Tag)
    //              {
    //                  case "AboutPage":
    //                      ContentFrame.Navigate(typeof(AboutPage));
    //                      break;
    //                  case "FileExplorerPage":
    //                      ContentFrame.Navigate(typeof(FileExplorerPage));
    //                      break;
    //                  default:
    //                      Debug.Fail("RootNavigationView_SelectionChanged: Unknown Tag to navigate to");
    //                      break;
    //              }
    //          }
    //  
    //          Debug.Print("RootNavigationView_SelectionChanged: Navigated to {0}", args.SelectedItem);
    //      }
    //      catch (Exception)
    //      {
    //          throw;
    //      }
    //  }
}