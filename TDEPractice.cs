namespace TODO
{
    public class TDEPractice : TDEvent
    {
        //attributes 
        private string _practice_focus;
        private string _event_description;

        //constructors
        public TDEPractice() : base() 
        {
            _practice_focus = "Practicing";
            _event_description = "";
        }

        public TDEPractice(string practice_focus, string event_description) : base() 
        {
            _practice_focus=practice_focus;
            _event_description=event_description;
        }

        //properties
        public string PracticeFocus
        {
            get { return _practice_focus; }
        }
        public string EventDescription
        {
            get { return _event_description; }
            set { _event_description = value; }
        }

        //methods
    }
}
