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
        public decimal GetPay()
        {
            return _wage * Math.Round((decimal)(EndTime - StartTime).TotalHours, 2);
        }
        public double ShiftLength()
        {
            return Math.Round((double)(EndTime - StartTime).TotalHours,2);
        }
    }
}
