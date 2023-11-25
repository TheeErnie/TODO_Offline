namespace TODO
{
    public class TDDay
    {
        //attributes
        private DateOnly _date = new DateOnly();                                         //date represented internally
        private List<TDEvent> _day_events = new List<TDEvent>();        //list of events held in a single day for the calendar

        //constructors
        TDDay()
        { 
            _date = DateOnly.FromDateTime(DateTime.Now);
        }

        TDDay(DateOnly date, List<TDEvent> day_events)
        {
            _date=date;
            _day_events=day_events;
        }

        //properties

        //methods
        public string GenerateDailySummary()
        {
            return "";
        }
    }
}
