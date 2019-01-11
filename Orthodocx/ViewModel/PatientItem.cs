using System.Collections.ObjectModel;

namespace Orthodocx.ViewModel
{
    public class PatientItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FullName { get => FirstName + " " + LastName; }
        public string Gender { get; set; }
        public ObservableCollection<Visit> Visits { get; set; }
    }

    public class Visit
    {
        public long StartDateTime { get; set; }
        public long EndDateTime { get; set; }
        public string Title { get; set; }
        public string DiagnosedBy { get; set; }
        public string Location { get; set; }
        public ObservableCollection<Encounter> Encounters { get; set; }
    }

    public class VisitNote
    {
        public long DateTime { get; set; }
        public string Provider { get; set; }
        public string Location { get; set; }
        public string PrimaryDiagnosis { get; set; }
        public string SecondaryDiagnosis { get; set; }
        public string ClinicalNote { get; set; }
    }

    public class Vitals
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string HeightUnit { get; set; }
        public string WeightUnit { get; set; }
        public decimal CalculatedBMI { get; set; }
        public decimal Temperature { get; set; }
        public string TemperatureUnit { get; set; }
        public decimal PulseRate { get; set; }
        public decimal RespiratoryRate { get; set; }
        public string BloodPressure { get; set; }
        public string BloodOxygenSaturation { get; set; }
    }

    public class Encounter
    {
        public VisitNote VisitNote { get; set; }
        public Vitals Vitals { get; set; }
    }

    public class PatientItemViewModel
    {
        public ObservableCollection<PatientItem> PatientItems { get; } = new ObservableCollection<PatientItem>();
    }
}
