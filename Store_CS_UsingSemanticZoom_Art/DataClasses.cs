using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Store_CS_UsingSemanticZoom
{
    /// <summary>
    /// Class for Patients Info
    /// </summary>
    public class PatientInfo
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string HospitalName { get; set; }
    }

    /// <summary>
    /// Class to Store Patients per Hospital
    /// </summary>
    public class HospitalGroup
    {
        public string HospitalName { get; set; }
        public List<PatientInfo> Patients { get; set; }
    }

    /// <summary>
    /// Data Access class where the Patient Information is stored.
    /// </summary>
    public class DataAccess
    {
        ObservableCollection<PatientInfo> _Patients;

        public ObservableCollection<PatientInfo> Patients
        {
            get { return _Patients; }
            set { _Patients = value; }
        }

        public DataAccess()
        {
            Patients = new ObservableCollection<PatientInfo>();
            Patients.Add(new PatientInfo() { PatientId = 1, PatientName = "Ajay", Age = 30, HospitalName = "JD Med-Institute"});
            Patients.Add(new PatientInfo() { PatientId = 2, PatientName = "Rajesh", Age = 28, HospitalName = "JD Med-Institute" });
            Patients.Add(new PatientInfo() { PatientId = 3, PatientName = "Sanjay", Age = 17, HospitalName = "JD Med-Institute" });
            Patients.Add(new PatientInfo() { PatientId = 4, PatientName = "Gopal", Age = 19, HospitalName = "City Hospital"});
            Patients.Add(new PatientInfo() { PatientId = 5, PatientName = "Ram", Age = 45, HospitalName = "City Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 6, PatientName = "Bhargav", Age = 48, HospitalName = "City Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 7, PatientName = "Vaman", Age = 32, HospitalName = "Care Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 8, PatientName = "Vasudev", Age = 36, HospitalName = "Care Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 9, PatientName = "Murlidhar", Age = 23, HospitalName = "Care Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 10, PatientName = "Krishna", Age = 19, HospitalName = "Diamond Hospital"});
            Patients.Add(new PatientInfo() { PatientId = 11, PatientName = "Krushna", Age = 14, HospitalName = "Diamond Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 12, PatientName = "Narayan", Age = 19, HospitalName = "Diamond Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 13, PatientName = "Vikas", Age = 22, HospitalName = "MS Hospital"});
            Patients.Add(new PatientInfo() { PatientId = 14, PatientName = "Vinayak", Age = 78, HospitalName = "MS Hospital" });
            Patients.Add(new PatientInfo() { PatientId = 15, PatientName = "Vikram", Age = 55, HospitalName = "MS Hospital" });
        }

        public ObservableCollection<PatientInfo> GetPatients()
        {
            return Patients;
        }
    }
}
