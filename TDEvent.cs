﻿namespace TODO
{
    public interface IEvent
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string ToShortString { get; } 
        string ToLongString { get; }
    }
    public abstract class TDEvent : IEvent
    {
        //attributes
        private DateTime _start_time;
        private DateTime _end_time;
        private string _name;

        //constructor
        public TDEvent()
        {
            _start_time = DateTime.Today; 
            _end_time = DateTime.Today;
            _name = "NO_NAME_GIVEN";
        }

        public TDEvent(DateTime start_time, DateTime end_time, string name)
        {
            _start_time=start_time;
            _end_time=end_time;
            _name=name;
        }

        //properties
        public string StartTimeString
        {
            get { return _start_time.ToString("h:mm tt"); }
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
        public string ToShortString
        {
            get
            {
                return this.ShortString();
            }
        }
        public string ToLongString
        {
            get { return this.ToString(); }
        }

        //methods
        public abstract string ToString();
        public abstract string ShortString();
    }
}
