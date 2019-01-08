using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Orthodocx.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PatientsPage : Page
    {
        public PatientsPage()
        {
            this.InitializeComponent();
        }

        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Instead of hard coded items, the data could be pulled 
            // asynchronously from a database or the internet.
            Items.Add("Jack Sparrow");
            Items.Add("Kaj Jak");
            Items.Add("Pak Yew");
            Items.Add("Item 4");
            Items.Add("Item 5");
        }
    }
}
