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
            if(meeting_days >= 16)
            {
                meeting_days -= 16;
                _meeting_days[(int)TDDayofWeek.Monday] = true;
            }
            if(meeting_days >= 8)
            {
                meeting_days -= 8;
                _meeting_days[(int)TDDayofWeek.Tuesday] = true;
            }
            if(meeting_days >= 4)
            {
                meeting_days -= 4;
                _meeting_days[(int)TDDayofWeek.Wednesday] = true;
            }
            if(meeting_days >= 2)
            {
                meeting_days -= 2;
                _meeting_days[(int)TDDayofWeek.Thursday] = true;
            }
            if(meeting_days == 1)
            {
                meeting_days -= 1;
                _meeting_days[(int)TDDayofWeek.Friday] = true;
            }
        }

        //properties

        //methods
    }
}
