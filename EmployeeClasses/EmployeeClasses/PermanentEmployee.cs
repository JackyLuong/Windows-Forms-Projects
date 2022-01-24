namespace EmployeeClasses
{
    public class PermanentEmployee: Employees
    {
        //add private data
        private decimal rrspPct; // decimal of RRSP deduction; for example 0.1 for 10% deduction
        
        //constructor of derived class invokes base class constructor
        public PermanentEmployee(string n , decimal h, decimal p, decimal r): base(n,h,p)
        {
            rrspPct = r;
        }

        //public mehtods
        public decimal CalcRRSP() // added method
        {
            decimal basePay = base.CalcPay();
            return basePay * rrspPct;
        }
        public override decimal CalcPay()
        {
            decimal basePay = base.CalcPay(); // call calcPay from base class
            decimal deduction = CalcRRSP();
            decimal payWithDeduction = basePay - deduction;
            return payWithDeduction;
        }
        public override string ToString()
        {
            return base.ToString() + $", {rrspPct.ToString("p")}";
        }
    }
}
