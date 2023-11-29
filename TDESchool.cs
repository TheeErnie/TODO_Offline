namespace TODO
{
    public enum TDDayofWeek
    {
        Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4
    }
    public class TDESchool : TDEvent
    {
        //attributes
        private string _course_id;
        private bool _online;
        private bool[] _meeting_days;

        //constructors
        public TDESchool() : base()
        {
            _course_id = "ABC-123";
            _online = false;
        }
        public TDESchool(string course_id, bool online, int meeting_days, DateTime start_time, DateTime end_time, string name) : base(start_time, end_time, name) 
        {
            _meeting_days = new bool[5];
            _course_id = course_id;
            _online = online;

            _meeting_days[(int)TDDayofWeek.Monday] = meeting_days >= 16;
            if (meeting_days >= 16) { meeting_days -= 16; }
            _meeting_days[(int)TDDayofWeek.Tuesday] = meeting_days >= 8;
            if (meeting_days >= 8) { meeting_days -= 8; }
            _meeting_days[(int)TDDayofWeek.Wednesday] = meeting_days >= 4;
            if (meeting_days >= 4) { meeting_days -= 4; }
            _meeting_days[(int)TDDayofWeek.Thursday] = meeting_days >= 2;
            if (meeting_days >= 2) { meeting_days -= 2; }
            _meeting_days[(int)TDDayofWeek.Friday] = meeting_days == 1;           
        }

        //properties
        public string CID
        {
            get { return _course_id; }
            set { _course_id = value; }
        }
        public bool IsOnline
        {
            get { return _online; }
            set { _online = value; }
        }
        public int EncodedMeetingDays
        {
            get
            {
                int code = 0;
                if (_meeting_days[0]) code += 16;
                if (_meeting_days[1]) code += 8;
                if (_meeting_days[2]) code += 4;
                if (_meeting_days[3]) code += 2;
                if (_meeting_days[4]) code += 1;
                return code;
            }
            set
            {
                int meeting_days = value;
                _meeting_days[(int)TDDayofWeek.Monday] = meeting_days >= 16;
                if (meeting_days >= 16) { meeting_days -= 16; }
                _meeting_days[(int)TDDayofWeek.Tuesday] = meeting_days >= 8;
                if (meeting_days >= 8) { meeting_days -= 8; }
                _meeting_days[(int)TDDayofWeek.Wednesday] = meeting_days >= 4;
                if (meeting_days >= 4) { meeting_days -= 4; }
                _meeting_days[(int)TDDayofWeek.Thursday] = meeting_days >= 2;
                if (meeting_days >= 2) { meeting_days -= 2; }
                _meeting_days[(int)TDDayofWeek.Friday] = meeting_days == 1;
            }
        }

        //methods
        public double HrsInClassPerWeek()
        {
            double numdays = 0;
            foreach(bool d in _meeting_days)
            {
                if(d) numdays++;
            }

            double hrsinclass = Math.Round((double)(EndTime-StartTime).TotalHours, 2);

            return numdays * hrsinclass;
        }
    }
}
