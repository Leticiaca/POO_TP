using static System.Net.Mime.MediaTypeNames;

namespace DentalClinic_AdriLeti
{
    public class Person // esta classe vai ter 2 'filhos' paciente e médico
    {

        #region Attributes 

        private string name;
        private static int idNum = 1; // =1 para ser um id unico
        private int age;
        private string address;
        private string phoneNumber;
        private string email;



        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// the default contrutor
        /// </summary>
        public Person()
        {
        }
        /// <summary>
        /// construtor parametrizado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="ad"></param>
        /// <param name="ph"></param>
        /// <param name="eml"></param>
        public Person(int id, string n, int a, string ad, string ph, string eml)
        {
            name = n;
            idNum = id++;
            age = a;
            address = ad;
            phoneNumber = ph;
            email = eml;
        }


        #endregion


        #region Properties
        /// <summary>
        /// set e get para garantir validação de dados no caso da idade garantindo que é superior a zero 
        /// </summary>
        public string Name
        {
            get { return (name); }
            set { name = value; }
        }
        public int IdNum
        {
            get { return idNum; }
            set { idNum = value; }
        }
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        #endregion

        #region Overrides
        #endregion

        #region Other Methods 
        #endregion

        #region Destructor
        ~Person()
        {

        }
        #endregion

        #endregion

    }
}


