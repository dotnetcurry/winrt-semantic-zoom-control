using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Store_CS_UsingSemanticZoom
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        DataAccess objDs;
        public MainPage()
        {
            this.InitializeComponent();

            objDs = new DataAccess(); 
        }


        ObservableCollection<PatientInfo> _Patients;

        public ObservableCollection<PatientInfo> Patients
        {
            get { return _Patients; }
            set { _Patients = value; }
        }

        ObservableCollection<HospitalGroup> _HospitalNameGroup;

        public ObservableCollection<HospitalGroup> HospitalNameGroup
        {
            get { return _HospitalNameGroup; }
            set { _HospitalNameGroup = value; }
        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private  void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            //Get Patients
            Patients = objDs.GetPatients();

            HospitalNameGroup = new ObservableCollection<HospitalGroup>(); 

            //Create a Group of Patients Group be HospitalName
            var HospitalwiseGroup = Patients.GroupBy(d => d.HospitalName).Select(d => new HospitalGroup() { HospitalName = d.Key, Patients = d.ToList() });

            foreach (var item in HospitalwiseGroup.ToList())
            {
                HospitalNameGroup.Add(item);
            }

            //Set the CollectionViewSource
            PatientsCollection.Source = HospitalNameGroup;
            //Bind the Groups in the Collection View Source to the ZoomedOutPatGridView
            ZoomedOutPatGridView.ItemsSource = PatientsCollection.View.CollectionGroups;

        }

        private void ZoomedInEmpGridView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    
}
