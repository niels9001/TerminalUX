using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace TerminalUX.Controls
{
    public sealed partial class SettingsPageControl : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
        nameof(Title),
        typeof(string),
        typeof(SettingsPageControl),
        new PropertyMetadata(defaultValue: string.Empty));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty PageContentProperty = DependencyProperty.Register(
         nameof(PageContent),
         typeof(object),
         typeof(SettingsPageControl),
         new PropertyMetadata(defaultValue: null));

        public object PageContent
        {
            get => (object)GetValue(PageContentProperty);
            set => SetValue(PageContentProperty, value);
        }

        public SettingsPageControl()
        {
            InitializeComponent();
        }
    }
}
