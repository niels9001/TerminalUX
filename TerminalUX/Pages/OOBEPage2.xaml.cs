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
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TerminalUX.Pages;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class OOBEPage2 : Page
{
    ObservableCollection<OOBEItem> OOBEItems;
    public OOBEPage2()
    {
        InitializeComponent();

        OOBEItems = new ObservableCollection<OOBEItem>();
        OOBEItems.Add(new OOBEItem() { Name = "Tabs made easy", Icon = "\uEC6C", Description = "Quickly open multiple command-line shells in a single window using tabs—just click the “+” or press Ctrl+Shift+T." });
        OOBEItems.Add(new OOBEItem() { Name = "Split your view", Icon = "\uE748", Description = "Run multiple commands side by side in the same tab using panes—perfect for multitasking and comparing outputs." });
        OOBEItems.Add(new OOBEItem() { Name = "Personalize everything", Icon = "\uEDA7", Description = "Customize your Terminal with themes, fonts, background images, and colors to create a setup that fits your style." });
        OOBEItems.Add(new OOBEItem() { Name = "Fast & keyboard friendly", Icon = "\uE8BD", Description = "Boost your productivity with powerful keyboard shortcuts for navigation, tab control, and pane management." });
        OOBEItems.Add(new OOBEItem() { Name = "Your shells, your profiles", Icon = "\uF4A5", Description = "Access all your tools—PowerShell, Command Prompt, WSL, and Azure Cloud Shell—in one unified, fast interface." });

    }

    private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //Assign DataTemplate for selected items
        foreach (var item in e.AddedItems)
        {
            ListViewItem lvi = (sender as ListView).ContainerFromItem(item) as ListViewItem;
            lvi.ContentTemplate = (DataTemplate)this.Resources["Detail"];
        }
        //Remove DataTemplate for unselected items
        foreach (var item in e.RemovedItems)
        {
            ListViewItem lvi = (sender as ListView).ContainerFromItem(item) as ListViewItem;
            lvi.ContentTemplate = (DataTemplate)this.Resources["Normal"];
        }

       
    }

    private void listje_Loaded(object sender, RoutedEventArgs e)
    {
        listje.SelectedIndex = 0;
    }

    private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
    {
        int Count = listje.SelectedIndex + 1;

        if (Count >= listje.Items.Count)
        {
            Count = 0;
        }

        listje.SelectedIndex = Count;
    }
}
public class OOBEItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}
