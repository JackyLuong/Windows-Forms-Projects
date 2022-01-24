namespace PayRollGUI
{
    public class Employees
    {
        //Class constants
        const decimal FULL_WEEK = 37.5m;
        const decimal OT_PAY_RATE = 1.5m;

        //private data
        private string name;
        private decimal hours;
        private decimal rate; // hourly rate

        //constructor with parameters
        public Employees(string _name, decimal _hours, decimal _rate)
        {
            name = _name;
            hours = _hours;
            rate = _rate;
        }
        //public methods
        public virtual decimal CalcPay() // allows overrides
        {
            if(hours <= FULL_WEEK)
            {
                return hours * rate;
            } 
            else
            {
                return (FULL_WEEK * rate) + ((hours - FULL_WEEK) * OT_PAY_RATE * rate);
            }
        }
        public override string ToString()
        {
            return $"name: {name}, hours: {hours.ToString()}, Pay Rate: {rate.ToString()}";
        }
    }
}
