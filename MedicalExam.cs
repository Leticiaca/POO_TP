using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public enum MedicalExamType
{
    DENTALEXAMINATION, // Exame Dental
    RADIOGRAPHY // Radiografia.
}


namespace DentalClinic_AdriLeti
{

    public class MedicalExam
    {

        #region Attributes
        
        private string name; //Name of the medical examination.
        private MedicalExamType type; //Type of medical exam, according to the 'MedicalExamType' enum.
        
    #endregion
    #region Methods

    #region Constructors
        /// <summary>
        /// the default constructor
        /// </summary>
    public MedicalExam()
    {
        name = "Exam"; //Assigns a default name to the exam.
        type = MedicalExamType.RADIOGRAPHY; //Assigns a default type to the exam.

    }
        /// <summary>
        /// construtor parametrizado
        /// </summary>
        /// <param name="medicalExamName"></param>
        /// <param name="t"></param>
    public MedicalExam(string medicalExamName, MedicalExamType t)
    {
        name = medicalExamName; //Assigns the specified name to the exam.
            type = t; //Assigns the specified type to the exam.
    }

        #endregion

           #region Properties
        /// <summary>
        /// O nome tem que ser válido
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    throw new ArgumentException("This parameter can't be empty or null."); //Throws an exception if the value is invalid.
            }
        }
        /// <summary>
        /// propriedade tipo
        /// </summary>
        public MedicalExamType Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

        #region Overrides
        /// <summary>
        /// string to string
        /// </summary>
        /// <returns>devolve o nome e tipo de exame medico</returns>
        public override string ToString()
        {
            return $"Medical Exam: {Name}, Type: {Type}";
        }

        #endregion
        #region OtherMethods
        #endregion

        #region Destructor
        ~MedicalExam() { }

        #endregion

        #endregion



    }
}
