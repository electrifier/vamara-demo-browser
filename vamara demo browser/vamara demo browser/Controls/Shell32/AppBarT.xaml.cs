using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Controls.Shell32;

public partial class AppBarT : UserControl
{
    public event EventHandler BackRequested;
    public event EventHandler ForwardRequested;
    public event EventHandler UpRequested;
    public event EventHandler RefreshRequested;
    public event EventHandler<string> PathChanged;

    public AppBarT()
    {
        //InitializeComponent();
        this.Loaded += AppBarT_Loaded;

        //BackButton.Click += (_, _) => BackRequested?.Invoke(this, EventArgs.Empty);
        //ForwardButton.Click += (_, _) => ForwardRequested?.Invoke(this, EventArgs.Empty);
        //UpButton.Click += (_, _) => UpRequested?.Invoke(this, EventArgs.Empty);
        //RefreshButton.Click += (_, _) => RefreshRequested?.Invoke(this, EventArgs.Empty);

        //BreadcrumbControl.PathChanged += (_, path) =>
        //{
        //    PathChanged?.Invoke(this, path);
        //};
    }

    private void AppBarT_Loaded(object sender, RoutedEventArgs e)
    {
        //BackButton.Click += (_, _) => BackRequested?.Invoke(this, EventArgs.Empty);
        //ForwardButton.Click += (_, _) => ForwardRequested?.Invoke(this, EventArgs.Empty);
        //UpButton.Click += (_, _) => UpRequested?.Invoke(this, EventArgs.Empty);
        //RefreshButton.Click += (_, _) => RefreshRequested?.Invoke(this, EventArgs.Empty);

        //BreadcrumbControl.PathChanged += (_, path) =>
        //{
        //    PathChanged?.Invoke(this, path);
        //};
    }
}
