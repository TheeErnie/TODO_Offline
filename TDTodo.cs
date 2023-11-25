namespace TODO
{
    public enum TDImportanceLevel
    {
        Low = 0, Medium = 1, High = 2
    }

    public class TDTodo
    {
        //attributes
        private string _item_name;              //the displayed name of the list item
        private string _item_description;       //the longer, optional description of the list item
        private TDImportanceLevel _item_importance;

        //constructors
        public TDTodo()
        {
            _item_name = "EMPTY";
            _item_description = string.Empty;
            _item_importance = TDImportanceLevel.Low;
        }
        public TDTodo(string item_name, string item_description, TDImportanceLevel item_importance)
        {
            _item_name=item_name;
            _item_description=item_description;
            _item_importance=item_importance;
        }

        //properties
        public string Name
        {
            get { return _item_name; }
            set { _item_name = value; }
        }

        public string Description
        {
            get { return _item_description; }
            set { _item_description = value; }
        }

        public TDImportanceLevel ImportanceLevel
        {
            get { return _item_importance;}
            set { _item_importance = value;}
        }

        //methods

    }
}
