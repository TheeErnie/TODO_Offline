namespace TODO
{
    public class TDEWork : TDEvent
    {
        //attributes
        private string _job_name;
        private double _wage;
        private bool _paid;

        //constructors
        public TDEWork() : base()
        {
            _job_name = "Work";
            _wage = 0;
            _paid = false;
        }

        public TDEWork(string job_name, double wage, bool paid) : base()
        {
            _job_name=job_name;
            _wage=wage;
            _paid=paid;
        }

        //properties

        //methods
    }
}
