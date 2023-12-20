using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum MedicalSuppliesType
{
    DENTALINSTRUMENTSANDTOOLS,//Dental Instruments and Tools
    PPE //Infection Control and Personal Protective Equipment (PPE)
}



namespace ClinicaDentária_AdriLeti
{
    public class MedicalSupplies
    {
        #region Attributes

        private string name;
        private MedicalSuppliesType type;


        #endregion

        #region Methods

        #region Constructors


        public MedicalSupplies()
        {
            name = "";
            type = MedicalSuppliesType.PPE;

        }

        public MedicalSupplies(string MedicalSuppliesName, MedicalSuppliesType t)
        {
            name = name;
            type = t;
        }

        #endregion

        #region Properties

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public MedicalSuppliesType Type { get { return type; } }
            

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor

        #endregion

        #endregion}



    }
}









