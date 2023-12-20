using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic_AdriLeti
{
    public class Patient : Person
    {
        #region Attributes

        private static double nextInsuranceNumber = 1; //contador estático 
        private double insuranceNumber;



        #endregion
        #region Methods

        #region Constructors
        /// <summary>
        /// contrutor com contador
        /// </summary>

        public Patient()
        { 
            InsuranceNumber = nextInsuranceNumber++; //garante que o numero é sequencial
        }

        public Patient(int id,string n, int a, string ad, string ph, string eml,double iN) : base(id,n, a, ad,ph,eml)
        {
            InsuranceNumber = nextInsuranceNumber++;
            InsuranceNumber = iN;
        }
      
        #endregion

        #region Properties
        public double InsuranceNumber
        {
            get { return insuranceNumber; }
            set { insuranceNumber = value; }
        }

        #endregion

        #region Overrides
        public override string ToString()
        {
            return base.ToString() + $"Insurance Number: {InsuranceNumber}";
        }

        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Patient() { }

        #endregion

        #endregion


    }
}
