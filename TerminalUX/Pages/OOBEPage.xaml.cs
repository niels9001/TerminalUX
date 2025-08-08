using Microsoft.UI.Xaml.Controls;

namespace TerminalUX.Pages;

public sealed partial class OOBEPage : Page
{
    public OOBEPage()
    {
        InitializeComponent();
    }

    private void SelectorBar_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
    {
        if (sender is SelectorBar bar && bar.SelectedItem is SelectorBarItem item)
        {
            flipper.SelectedIndex = bar.Items.IndexOf(item);
            hero.Animate(flipper.SelectedIndex);
        }
    
    }
}
