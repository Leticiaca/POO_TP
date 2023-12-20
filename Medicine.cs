using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public enum Medicinetype
{
   ANALGESIC,
   ANESTHETIC
}


namespace DentalClinic_AdriLeti
{


    public class Medicine
    {
        #region Attributes

        private string name;
        private Medicinetype type;


        #endregion

        #region Methods

        #region Constructors


        public Medicine()
        {
            name = "";
            type = Medicinetype.ANESTHETIC;
           
        }

        public Medicine(string MedicineName, Medicinetype t)
        {
            name = MedicineName;
            type = t;
        }

        #endregion

        #region Properties

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Medicinetype Type
        {
            get { return type; }
            set { type = value; }
        }


        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Medicine()
        {
        }
        #endregion

        #endregion

    }
}

