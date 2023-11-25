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

        public TDEPersonal(string description) : base() 
        {
            _description=description;
        }


        //properties

        //methods
    }
}
