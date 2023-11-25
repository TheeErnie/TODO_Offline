using TODO;

namespace projoffline
{
    public partial class Form1 : Form
    {

        private List<TDTodo> todoList = new List<TDTodo>(); //listing of todo items
        private int tdindex; // index to be updated when todoList items are being updated
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        #region TODO_List

        #region Button_Functionalities
        private void btnTAdd_Click(object sender, EventArgs e)
        {
            hideTDCtrlPanel();
            inItemName.Text = string.Empty;
            inImportanceLevel.Text = "0";
            inItemDescription.Text = string.Empty;
            showTDCreate();
            this.ActiveControl = inItemName;
        }
        private void btnTEdit_Click(object sender, EventArgs e)
        {
            hideTDCtrlPanel();
            tdindex = todoList.FindIndex(x => x.Name == lbTODOlisting.Text);
            TDTodo tmptd = todoList.Where(x => x.Name == lbTODOlisting.Text).FirstOrDefault();
            inItemName.Text = tmptd.Name;
            inImportanceLevel.Value = (int)tmptd.ImportanceLevel;
            inItemDescription.Text = tmptd.Description;
            showTDEdit();
            btnTEdit.Enabled = false;
            btnTFinish.Enabled = false;
            this.ActiveControl = inItemName;
        }
        private void btnTFinish_Click(object sender, EventArgs e)   //deletes selected item from listing
        {
            string tmpdel = lbTODOlisting.GetItemText(lbTODOlisting.SelectedItem);
            TDTodo tmptd = todoList.Where(x => x.Name == tmpdel).FirstOrDefault();
            todoList.Remove(tmptd);
            updateTDL();
            btnTFinish.Enabled = false;
            btnTEdit.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e) //function for create td item, I had troubles with renaming it and decided not to get hung up on it for now
        {
            if (inItemName.Text != "")
            {
                int tmpImpLvl = Decimal.ToInt32(inImportanceLevel.Value);
                TDTodo tmptd = new TDTodo(inItemName.Text, inItemDescription.Text, (TDImportanceLevel)Enum.ToObject(typeof(TDImportanceLevel), tmpImpLvl));
                todoList.Add(tmptd);
                inItemName.Text = "";
                inImportanceLevel.Text = "0";
                inItemDescription.Text = "";
                updateTDL();
            }
            hideTDCreate();
            showTDCtrlPanel();
        }
        private void btnUpdateTodo_Click(object sender, EventArgs e)
        {
            if (inItemName.Text != "")
            {
                todoList[tdindex].Name = inItemName.Text;
                int tmpImpLvl = Decimal.ToInt32(inImportanceLevel.Value);
                todoList[tdindex].ImportanceLevel = (TDImportanceLevel)Enum.ToObject(typeof(TDImportanceLevel), tmpImpLvl);
                todoList[tdindex].Description = inItemDescription.Text;
                inItemName.Text = "";
                inImportanceLevel.Text = "0";
                inItemDescription.Text = "";
                updateTDL();
            }
            hideTDEdit();
            showTDCtrlPanel();
        }
        private void btnCancelCreateTodo_Click(object sender, EventArgs e)
        {
            inItemName.Text = string.Empty;
            inImportanceLevel.Text = "0";
            inItemDescription.Text = string.Empty;
            hideTDCreate();
            hideTDEdit();
            showTDCtrlPanel();
            lbTODOlisting.SelectedIndex = -1;
        }


        #endregion

        #region Show-Hide_Displays
        private void showTDCreate()
        {
            lblItemName.Show();
            lblImportanceLevel.Show();
            lblItemDescription.Show();
            inItemName.Show();
            inImportanceLevel.Show();
            inItemDescription.Show();
            lblItemDescription.Show();
            btnCreateTodo.Show();
            btnCancelCreateTodo.Show();
        }

        private void showTDEdit()
        {
            lblItemName.Show();
            lblImportanceLevel.Show();
            lblItemDescription.Show();
            inItemName.Show();
            inImportanceLevel.Show();
            inItemDescription.Show();
            lblItemDescription.Show();
            btnUpdateTodo.Show();
            btnCancelCreateTodo.Show();
        }

        private void showTDCtrlPanel()
        {
            btnTAdd.Show();
            btnTEdit.Show();
            btnTFinish.Show();
        }

        private void hideTDCreate()
        {
            lblItemName.Hide();
            lblImportanceLevel.Hide();
            lblItemDescription.Hide();
            inItemName.Hide();
            inImportanceLevel.Hide();
            inItemDescription.Hide();
            lblItemDescription.Hide();
            btnCreateTodo.Hide();
            btnCancelCreateTodo.Hide();
        }

        private void hideTDEdit()
        {
            lblItemName.Hide();
            lblImportanceLevel.Hide();
            lblItemDescription.Hide();
            inItemName.Hide();
            inImportanceLevel.Hide();
            inItemDescription.Hide();
            lblItemDescription.Hide();
            btnUpdateTodo.Hide();
            btnCancelCreateTodo.Hide();
        }

        private void hideTDCtrlPanel()
        {
            btnTAdd.Hide();
            btnTEdit.Hide();
            btnTFinish.Hide();
        }
        #endregion
        private void updateTDL()    //updates todo list after todoList has been edited
        {
            todoList.Sort((td1, td2) => td2.ImportanceLevel.CompareTo(td1.ImportanceLevel));
            lbTODOlisting.Items.Clear();
            foreach (TDTodo td in todoList)
            {
                lbTODOlisting.Items.Add(td.Name);
            }
        }


        #endregion

        private void lbTODOlisting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTODOlisting.SelectedIndex != -1)
            {
                btnTFinish.Enabled = true;
                btnTEdit.Enabled = true;
            }
        }

    }
}