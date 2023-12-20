using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum MedicalSpecialtyId
{
    NONE=1, // MÉDICO DENTISTA GENERALISTA
    ORTHODONTICS=2,
    ORALANDMAXILLOFACIALSURGERY=3 //Oral and Maxillofacial Surgery- ESTOMATOLOGIA
}

namespace DentalClinic_AdriLeti
{
    public class MedicalSpecialty
    {
        #region Attributes

        private MedicalSpecialtyId id;
        private string name;

        #endregion


        #region Methods

        #region Constructors
        /// <summary>
        /// the default construtor
        /// </summary>
        public MedicalSpecialty() { }

        /// <summary>
        /// construtor com parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public MedicalSpecialty(MedicalSpecialtyId id, string name)
        {
            this.id = id;
            this.name = name;
        }


        #endregion

        #region Properties

        public MedicalSpecialtyId Id 
        { 
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("This fild cant be empty."); //nao pode ser nulo
                name = value;
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"Specialty ID: {Id}, Name: {Name}";
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~MedicalSpecialty() { }

        #endregion

        #endregion


    }
}
