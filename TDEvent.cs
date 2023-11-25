namespace TODO
{
    public interface IEvent
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
    public class TDEvent : IEvent
    {
        //attributes
        private DateTime _start_time;
        private DateTime _end_time;
        private string _name;
        private bool _completed;

        //constructor
        public TDEvent()
        {
            _start_time = DateTime.Today; 
            _end_time = DateTime.Today;
            _name = "NO_NAME_GIVEN";
            _completed = false;
        }

        public TDEvent(DateTime start_time, DateTime end_time, string name)
        {
            _start_time=start_time;
            _end_time=end_time;
            _name=name;
            _completed = false;
        }

        //properties
        public string StartTimeString
        {
            get { return _start_time.ToString("h:mm tt"); }
        }
        public string EventName
        {
            get { return _name; }
            set { _name = value; }
        }

        //interface
        public DateTime StartTime { 
            get { return _start_time; } 
            set { _start_time = value; } 
        }
        public DateTime EndTime
        {
            get { return _end_time; }
            set { _end_time = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description { get; set; }

        //methods

        public void UpdateAvailability()
        {

        }

        public void NotifyUser()
        {

        }

        public void VerifyEventCompletion()
        {
            bool ui = false;
            //userinput
            _completed = ui;
        }
    }
}
