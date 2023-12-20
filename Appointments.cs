using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace DentalClinic_AdriLeti
{/// <summary>
/// criar classe apppointments
/// </summary>
    public class Appointments
    {
        #region Attributes
        //declaring a list of 'appointment' objects
        public List<Appointment> appointments;
        #endregion



        #region Methods
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        //list appointments by doctor
        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return appointments.Where(Appointment => Appointment.nPI == doctorId).ToList();
        }
        //list appointments by patient
        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return appointments.Where(Appointment => Appointment.iN == patientId).ToList();
        }
        //list consultations by specialty
        public List<Appointment> GetAppointmentsBySpecialty(double specialtyId)
        {
            return appointments.Where(Appointment => Appointment.MedicalSpecialtyId == specialtyId).ToList();
        }
        #endregion

        #region Constructors
        public Appointments()
        {

            //It is not necessary to reassign appointments here as it has already been initialized in the field declaration        }
        #endregion

        #region Properties

        #endregion

        #region Overrides


        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Appointments() {}

        #endregion

        


    }
}
