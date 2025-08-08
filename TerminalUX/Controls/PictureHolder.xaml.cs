using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TerminalUX.Controls;

public sealed partial class PictureHolder : UserControl
{
    public static readonly DependencyProperty ImageUrlProperty = DependencyProperty.Register(
    nameof(ImageUrl),
    typeof(Uri),
    typeof(AnimatedImage),
    new PropertyMetadata(defaultValue: null));

    public Uri ImageUrl
    {
        get => (Uri)GetValue(ImageUrlProperty);
        set => SetValue(ImageUrlProperty, value);
    }


    public PictureHolder()
    {
        InitializeComponent();
    }

    private void Border_Loaded(object sender, RoutedEventArgs e)
    {
        PictureShadow.Receivers.Add(ShadowCastGrid);
    }
}
