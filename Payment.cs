using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum PaymentType
{
    MBWAY,
    ATM,// Automated Teller Machine, multibanco
    CASH,
}


namespace Appointment
{
    public class Payment
    {
        #region Attributes

        private int amount;
        private PaymentType type;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// the default constructor
        /// </summary>
        public Payment()
        {
            amount = 0;
            type = PaymentType.CASH;
        }
        /// <summary>
        /// construtor com valor
        /// </summary>
        /// <param name="amount"></param>
        public Payment(int amount)
        {
            this.amount = amount;
        }
        /// <summary>
        /// construtor parametrizado com valor e tipo
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="type"></param>
        #endregion
        public Payment(int amount, PaymentType type) : this(amount)
        {
            this.type = type;
        }

        #region Properties

        public int Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid value."); //o valor inserido nao pode ser negativo, tem que ser superior a zero
                amount = value;
            }
        }

        public PaymentType Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"Payment: {Amount} euros, Type:{type}";
        }
            #endregion

            #region OtherMethods
            #endregion

            #region Destructor
        ~Payment() { }

            #endregion

            #endregion


    }
}