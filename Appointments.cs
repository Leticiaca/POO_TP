using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DentalClinic_AdriLeti
{/// <summary>
/// criar classe apppointments
/// </summary>
    public class Appointments
    {
        #region Attributes
        public List<Appointment> appointments;
        #endregion



        #region Methods
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        //Listar as consultas por médico
        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return appointments.Where(Appointment => Appointment.nPI == doctorId).ToList();
        }
        //listar consultas por paciente
        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return appointments.Where(Appointment => Appointment.iN == patientId).ToList();
        }
        // Listar consultas por especialidade
        public List<Appointment> GetAppointmentsBySpecialty(double specialtyId)
        {
            return appointments.Where(Appointment => Appointment.MedicalSpecialtyId == specialtyId).ToList();
        }
        #endregion

        #region Constructors
        public Appointments()
        {
            // Não é necessário reatribuir o appointments aqui pois já foi inicializado na declaração do campo
        }
        #endregion

        #region Properties

        #endregion

        #region Overrides


        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Appointments() { }

        #endregion

        


    }
}
