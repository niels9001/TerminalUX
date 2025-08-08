using CommunityToolkit.WinUI.Animations;
using Microsoft.UI.Xaml.Controls;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TerminalUX.Controls;

public sealed partial class HeroImage : UserControl
{
    public HeroImage()
    {
        InitializeComponent();
    }

    public void Animate(int state)
    {
        switch (state)
        {
            case 0:
                AnimatedImageControl.ImageUrl = new Uri("ms-appx:///Assets/Image1.png");
                break;
            case 1:
                AnimatedImageControl.ImageUrl = new Uri("ms-appx:///Assets/Image2.png");
                break;
            case 2:
                AnimatedImageControl.ImageUrl = new Uri("ms-appx:///Assets/Image3.png");
                break;
            case 3:
                AnimatedImageControl.ImageUrl = new Uri("ms-appx:///Assets/Image4.png");
                break;
            case 4:
                AnimatedImageControl.ImageUrl = new Uri("ms-appx:///Assets/Image5.png");
                break;
        }
    }
}
