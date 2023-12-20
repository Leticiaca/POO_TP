using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_AdriLeti
{
    public class Appointment
    {
        public enum AppointmentStatus
        {
            Scheduled,
            Completed,
            Cancelled,
            Postponed
        }
        #region Attributes

        private DateTime appointmentDate = DateTime.Now;
        public double MedicalSpecialtyId;
        public int iN;
        public int nPI;
        private AppointmentStatus status;


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
            get { return appointmentDate; }
            set { appointmentDate = value; }
        }

        public AppointmentStatus Status
        {
            get { return status; }
            set {  status = value; }
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
