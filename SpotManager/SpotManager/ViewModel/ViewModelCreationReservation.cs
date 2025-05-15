using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace SpotManager.ViewModel
{

    public partial class ViewModelCreationReservation : ObservableObject
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Name))]
        private int occur;

        partial void OnNameChanged(string value)
        {
            Name = value;
            Occur = value.Length;
            Debug.WriteLine(value);
        }

        public ObservableCollection<string> Maliste { get; }


        public ViewModelCreationReservation()
        {
            this.Name = "TOTO";
            this.Maliste = new ObservableCollection<string>() 
            { 
                "car",
                "var",
                "bar",
                "dare",
                "sar",
                "sas",
                "far"
            };
        }
    }
}
