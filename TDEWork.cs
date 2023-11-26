namespace TODO
{
    public class TDEWork : TDEvent
    {
        //attributes
        private string _company;
        private decimal _wage;
        private bool _paid;

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

        //methods
    }
}
