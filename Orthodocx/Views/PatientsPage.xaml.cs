using Orthodocx.ViewModel;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
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
            InitializeComponent();
        }

        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

        public PatientItemViewModel PatientItemVM = new PatientItemViewModel();
        public ObservableCollection<PatientItem> PatientItems { get; } = new ObservableCollection<PatientItem>();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Instead of hard coded items, the data could be pulled 
            // asynchronously from a database or a backend API.
            PatientItems.Add(new PatientItem()
            {
                FirstName = "Bruce",
                LastName = "Wayne",
                DateOfBirth = "12-Dec-1956",
                Email = "bruce.wayne@email.com"
            });
            PatientItems.Add(new PatientItem()
            {
                FirstName = "Tony",
                LastName = "Stark",
                DateOfBirth = "24-Jul-1967",
                Email = "tony.stark@email.com"
            });
            PatientItems.Add(new PatientItem()
            {
                FirstName = "Jack",
                LastName = "Sparrow",
                DateOfBirth = "10-Oct-1921",
                Email = "jack.sparrow@email.com"
            });

            // and more data
            for (int i = 1; i < 150000; i++)
            {
                this.PatientItems.Add(new PatientItem()
                {
                    FirstName = "First " + i,
                    LastName = "Last " + i,
                    DateOfBirth = "DOB " + i,
                    Email = "Email: " + i
                });
            }
        }
    }
}
