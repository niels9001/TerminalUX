using CommunityToolkit.WinUI.Animations;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TerminalUX.Controls;

public partial class AnimatedImage : UserControl
{
    public AnimatedImage()
    {
        InitializeComponent();
    }
    public static readonly DependencyProperty ImageUrlProperty = DependencyProperty.Register(
      nameof(ImageUrl),
      typeof(Uri),
      typeof(AnimatedImage),
      new PropertyMetadata(defaultValue: null, (d, e) => ((AnimatedImage)d).IsImageChanged((Uri)e.OldValue, (Uri)e.NewValue)));

    public Uri ImageUrl
    {
        get => (Uri)GetValue(ImageUrlProperty);
        set => SetValue(ImageUrlProperty, value);
    }

    protected virtual void IsImageChanged(Uri oldValue, Uri newValue)
    {
        OnIsImageChanged();
    }

    private void OnIsImageChanged()
    {
        BottomImage.Source = new BitmapImage(this.ImageUrl);
        AnimationSet selectAnimation = [new OpacityAnimation() { From = 1, To = 0, Duration = TimeSpan.FromMilliseconds(600) }];
        selectAnimation.Completed += (s, e) =>
        {
            TopImage.Source = new BitmapImage(this.ImageUrl);
            TopImage.Opacity = 1;
        };
        selectAnimation.Start(TopImage);
    }
}

