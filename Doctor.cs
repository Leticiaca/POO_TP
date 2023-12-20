using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DentalClinic_AdriLeti
{
    public class Doctor : Person //Declares the class 'Doctor', which inherits from 'Person'.
    {
        #region Attributes

       private int nationalProviderIdentifier;// Private attribute for provider national identifier (order number).
        private string specialty; //Private attribute for the doctor's specialty

        #endregion

        #region Methods

        //Constructor for class 'Doctor'. This constructor calls the base constructor of the 'Person' class and initializes the specific attributes of the 'Doctor' class.
        #region Constructors
        public Doctor(int id, string n, int a, string ad, string ph, string eml,int nPI, string s) : base(id, n, a, ad, ph, eml)
        {
            nationalProviderIdentifier = nPI; //Initializes the provider's national identifier.
            specialty = s; //Initializes the doctor's specialty.
        }

        #endregion

        #region Properties

        //Public property to access and modify the provider's national identifier.
        public int nPI
        {
            get { return nationalProviderIdentifier; }
            set { nationalProviderIdentifier = value; }
        }

        //Public property to access and modify the doctor's specialty
        public string s
        {
            get { return specialty; }
            set { specialty = value; }
        }

        #endregion

        #region Overrides


        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Doctor() { }

        #endregion

        #endregion

    }
}

