﻿using System.Xml.Linq;

namespace TODO
{
    public class TDEPersonal : TDEvent
    {
        //attributes
        private string _description; 

        //constructors
        public TDEPersonal() : base() 
        {
            _description = "Personal Event";
        }

        public TDEPersonal(string description, DateTime start_time, DateTime end_time, string name) : base(start_time, end_time, name) 
        {
            _description=description;
        }

        //properties
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        //methods
        public override string ToString()
        {
            string retval = this.StartTime.ToString("h:mm") + " - " + this.EndTime.ToString("h:mm tt 'on' MMM dd");
            retval += "   " + this.Name + " : " + this.Description;
            return retval;
        }

        public override string ShortString()
        {
            return this.StartTime.ToString("h:mm tt") + " - " + this.Name;
        }        
    }
}
