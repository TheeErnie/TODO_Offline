using System.Xml.Linq;

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

        //methods
    }
}
