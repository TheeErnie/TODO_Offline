namespace TODO
{
    public class TDEWork : TDEvent
    {
        //attributes
        private string _company;
        private decimal _wage;

        //constructors
        public TDEWork() : base()
        {
            _company = "UNKNOWN";
            _wage = 0;
        }

        public TDEWork(string company, decimal wage, DateTime start_time, DateTime end_time, string name) : base(start_time, end_time, name)
        {
            _company=company;
            _wage=wage;
        }

        //properties
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public string Description
        {
            get { return _company; }
            set { _company = value; }
        }
        public decimal Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }


        //methods
        public override string ToString()
        {
            string retval = this.StartTime.ToString("h:mm") + " - " + this.EndTime.ToString("h:mm tt 'on' MMM dd");
            retval += "   " + this.Name + " @ " + this.Company + " at $" + Wage.ToString("0.00") + "/hr";
            return retval;
        }
        public override string ShortString()
        {
            return this.StartTime.ToString("h:mm tt") + " - " + this.Name + " @ " + this.Company;
        }
        public double GetPay()
        {
            return (double)_wage * Math.Round((EndTime - StartTime).TotalHours, 2);
        }
        public double ShiftLength()
        {
            return Math.Round((double)(EndTime - StartTime).TotalHours,2);
        }
    }
}
