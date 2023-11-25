namespace TODO
{
    public enum TDDayofWeek
    {
        Sunday = 0, Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6
    }
    public class TDESchool : TDEvent
    {
        //attributes
        private string _course_name;
        private string _course_id;
        private bool _online;
        private List<TDDayofWeek> _meeting_days;

        //constructors
        public TDESchool() : base()
        {
            _course_name = "Unknown";
            _course_id = "ABC-123";
            _online = false;
        }
        public TDESchool(string course_name, string course_id, bool online, int meeting_days) : base() 
        {
            _course_name = course_name;
            _course_id = course_id;
            _online = online;
            if(meeting_days > 64)
            {
                _meeting_days.Add(TDDayofWeek.Sunday);
                meeting_days -= 64;
            }
            if(meeting_days > 32)
            {
                meeting_days -= 32;
                _meeting_days.Add(TDDayofWeek.Monday);
            }
            if(meeting_days > 16)
            {
                meeting_days -= 16;
                _meeting_days.Add(TDDayofWeek.Tuesday);
            }
            if(meeting_days > 8)
            {
                meeting_days -= 8;
                _meeting_days.Add(TDDayofWeek.Wednesday);
            }
            if(meeting_days > 4)
            {
                meeting_days -= 4;
                _meeting_days.Add(TDDayofWeek.Thursday);
            }
            if(meeting_days > 2)
            {
                meeting_days -= 2;
                _meeting_days.Add(TDDayofWeek.Friday);
            }
            if(meeting_days > 1)
            {
                meeting_days -= 1;
                _meeting_days.Add(TDDayofWeek.Saturday);
            }
        }

        //properties

        //methods
    }
}
