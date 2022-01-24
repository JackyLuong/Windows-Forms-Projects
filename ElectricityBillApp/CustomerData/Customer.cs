namespace ElectricityBillApp
{
    /// <summary>
    /// Customer object that contains their first name, last name,
    /// kWh used, and their bill amount.
    /// </summary>
    public class Customer
    {
        #region Class Variables
        public int accountNo;
        private static int counter = 100; // account number starts at 100 and adds one for each new customer added.
        private decimal billAmount;
        private decimal adminCharge = 12m;
        private decimal kWhRate = 0.07m;
        #endregion

        /// <summary>
        /// Constructor creates a unqiue account number for each customer and 
        /// requires a first name, last name, and number of kWh used.
        /// </summary>
        /// <param name="_fName"></param>
        /// <param name="_lName"></param>
        /// <param name="_kWh"></param>
        public Customer(string _fName, string _lName, decimal _kWh)
        {
            accountNo = counter;
            counter++;
            FName = _fName;
            LName = _lName;
            if(_kWh < 0)
            {
                NumOfkWh = -_kWh;
            }
            else
            {
                NumOfkWh = _kWh;
            }
            CalcBillAmount();
        }
        /// <summary>
        /// Calcualte the total that the customer has to pay for their
        /// electricity bill.
        /// </summary>
        private void CalcBillAmount()
        {
            billAmount = (kWhRate * NumOfkWh) + adminCharge;
        }
        #region GetterAndSetters
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal NumOfkWh { get; set; }
        public decimal AdminCharge { get { return adminCharge; } }
        public decimal KWhRate { get { return kWhRate; } }
        public decimal BillAmount
        {
            get
            {
                return billAmount;
            }
        }
        #endregion
    }
}
