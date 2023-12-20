using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DentalClinic_AdriLeti
{
    public class Doctor : Person
    {
        #region Attributes

       private int nationalProviderIdentifier;// equiparado a nº da ordem
       private string specialty;

        #endregion

        #region Methods


        #region Constructors
        public Doctor(int id, string n, int a, string ad, string ph, string eml,int nPI, string s) : base(id, n, a, ad, ph, eml)
        {
            nationalProviderIdentifier = nPI;
            specialty = s;
        }

        #endregion

        #region Properties

        public int nPI
        {
            get { return nationalProviderIdentifier; }
            set { nationalProviderIdentifier = value; }
        }

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

