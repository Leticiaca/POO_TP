using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DentalClinic_AdriLeti
{
    public class Appointment
    {
        public enum AppointmentStatus // Declaration of an 'AppointmentStatus' enum with possible states for an appointment. 
        {
            Scheduled,
            Completed,
            Cancelled,
            Postponed
        }
        #region Attributes

        // Private and public attributes of the class.
        private DateTime appointmentDate = DateTime.Now; //Schedule date, default is the current date
        public double MedicalSpecialtyId; // Medical specialty ID, declared as public
        public int iN; //Patient ID, declared as public
        public int nPI; //Medium ID, declared as public
        private AppointmentStatus status; //Appointment status, private


        #endregion


        #region Methods

        #region Constructors
        public Appointment(DateTime appointmentDate, double MedicalSpecialtyId, int iN, int nPI, AppointmentStatus status = AppointmentStatus.Scheduled)
        {
            this.appointmentDate = appointmentDate;
            this.MedicalSpecialtyId = MedicalSpecialtyId;
            this.iN = iN;
            this.nPI = nPI;
            this.status = status;
        }
    
        #endregion

        #region Properties
        public DateTime AppointmentDate
        {
            get { return appointmentDate; } //Returns the scheduling date
            set { appointmentDate = value; } //Allows you to change the appointment date
        }

        public AppointmentStatus Status
        {
            get { return status; } //returns the status of the appointment
            set {  status = value; } //allows you to change the status of the appointment
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"Appointment Date: {AppointmentDate}, Specialty ID: {MedicalSpecialtyId}, Patient ID: {iN}, Doctor ID: {nPI}, Status:{status}";
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Appointment() { }

        #endregion

        #endregion


    }
}
