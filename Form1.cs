using System.Diagnostics.Eventing.Reader;
using TODO;

namespace projoffline
{
    public partial class Form1 : Form
    {

        private List<TDTodo> todoList = new List<TDTodo>(); //listing of todo items
        private List<IEvent> eventList = new List<IEvent>();//list of all events in calendar
        private int tdindex; // index to be updated when todoList items are being updated
        public Form1()
        {
            InitializeComponent();

            //set date formats for events creation
            inPEStartTimeDate.Format = inPEEndTimeDate.Format = inWStartTimeDate.Format = inWEndTimeDate.Format = inSEStartTimeDate.Format = inSEEndTimeDate.Format = DateTimePickerFormat.Custom;
            inPEStartTimeDate.CustomFormat = inPEEndTimeDate.CustomFormat = inWStartTimeDate.CustomFormat = inWEndTimeDate.CustomFormat = inSEStartTimeDate.CustomFormat = inSEEndTimeDate.CustomFormat = "h:mm tt 'on' MMM dd";
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

        private void lbTODOlisting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTODOlisting.SelectedIndex != -1)
            {
                btnTFinish.Enabled = true;
                btnTEdit.Enabled = true;
            }
        }

        #endregion

        #region Events
        #region Cleanup around crud
        private void updateEL()
        {
            eventList.Sort((e1, e2) => e1.StartTime.CompareTo(e2.StartTime));
            lbSelectedDayEvents.Items.Clear();
            List<IEvent> eventsToday = eventList.Where(e => e.StartTime.Date.Day == DateTime.Today.Day).ToList();
            foreach (IEvent e in eventsToday)
            {
                string tmpstr = e.StartTime.ToString("hh:mm tt");
                tmpstr += " - " + e.Name;
                lbSelectedDayEvents.Items.Add(tmpstr);
            }
        }
        private void clearAllEventInputs()
        {
            inPEName.Clear();
            inPEDescription.Clear();
            inWJobName.Clear();
            inWCompany.Clear();
            inWWage.Value = 0;
            inSEClassName.Clear();
            inSEClassID.Clear();
            inSEOnline.Checked = inSEMonday.Checked = inSETuesday.Checked = inSEWednesday.Checked = inSEThursday.Checked = inSEFriday.Checked = false;
            inPEStartTimeDate.Value = inPEEndTimeDate.Value = inWEndTimeDate.Value = inWStartTimeDate.Value = inSEStartTimeDate.Value = inSEEndTimeDate.Value = DateTime.Now;
        }
        private void cancelEventInput()
        {
            clearAllEventInputs();
            tcCreateEvents.Hide();
            showECtrlPanel();
        }


        #region Show-Hide_Displays
        private void showECtrlPanel()
        {
            btnEAdd.Show();
            btnEEdit.Show();
            btnEDelete.Show();
        }
        private void hideECtrlPanel()
        {
            btnEAdd.Hide();
            btnEEdit.Hide();
            btnEDelete.Hide();
        }
        #endregion
        #endregion


        #region Event Control Panel
        private void btnEAdd_Click(object sender, EventArgs e)
        {
            hideECtrlPanel();
            tcCreateEvents.Show();
        }
        private void btnEEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            string tmpdel = lbSelectedDayEvents.GetItemText(lbSelectedDayEvents.SelectedItem);
            IEvent tmpev = eventList.Where(x => x.StartTime.ToString("hh:mm tt").Substring(0, 6) == tmpdel.Substring(0, 6) && x.StartTime.Date.Day == DateTime.Now.Day).FirstOrDefault();
            //TODO :::::::
            //UPDATE THIS SO THAT IT IS NOT JUST USING THE CURRENT DATE BUT THE ONE SELECTED BY THE USERS
            //!!!!!!!!!!!!!!!
            eventList.Remove(tmpev);
            updateEL();
            btnEEdit.Enabled = false;
            btnEDelete.Enabled = false;
        }
        private void lbSelectedDayEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbSelectedDayEvents.SelectedIndex != -1)
            {
                btnEEdit.Enabled = true;
                btnEDelete.Enabled = true;
            }

        }
        #endregion

        #region Personal
        private void btnPECreate_Click(object sender, EventArgs e)
        {
            if (inPEName.Text != string.Empty)
            {
                TDEPersonal tmppersonal = new TDEPersonal(inPEDescription.Text, inPEStartTimeDate.Value, inPEEndTimeDate.Value, inPEName.Text);
                eventList.Add(tmppersonal);
                updateEL();
                cancelEventInput();
            }
        }
        private void btnPECancel_Click(object sender, EventArgs e)
        {
            cancelEventInput();
        }
        #endregion
        #region Work
        private void btnWECreate_Click(object sender, EventArgs e)
        {
            if (inWJobName.Text != string.Empty)
            {
                TDEWork tmpwork = new TDEWork(inWCompany.Text, inWWage.Value, inWStartTimeDate.Value, inWEndTimeDate.Value, inWJobName.Text);
                eventList.Add(tmpwork);
                updateEL();
                cancelEventInput();
            }
        }
        private void btnWECancel_Click(object sender, EventArgs e)
        {
            cancelEventInput();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region School
        private void btnSECreate_Click(object sender, EventArgs e)
        {
            int meetingDays = 0;
            if (!inSEOnline.Checked)
            {
                if (inSEMonday.Checked) { meetingDays += 16; }
                if (inSETuesday.Checked) { meetingDays += 16; }
                if (inSEWednesday.Checked) { meetingDays += 16; }
                if (inSEThursday.Checked) { meetingDays += 16; }
                if (inSEFriday.Checked) { meetingDays += 16; }
            }
            TDESchool tmpschool = new TDESchool(inSEClassID.Text, inSEOnline.Checked, meetingDays, inSEStartTimeDate.Value, inSEEndTimeDate.Value, inSEClassName.Text);
            eventList.Add(tmpschool);
            updateEL();
            cancelEventInput();
        }
        private void btnSECancel_Click(object sender, EventArgs e)
        {
            cancelEventInput();
        }

        private void inSEOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (inSEOnline.Checked)
            {
                inSEMonday.Checked = inSETuesday.Checked = inSEWednesday.Checked = inSEThursday.Checked = inSEFriday.Checked = false;
                inSEMonday.Enabled = inSETuesday.Enabled = inSEWednesday.Enabled = inSEThursday.Enabled = inSEFriday.Enabled = false;
            }
            else
            {
                inSEMonday.Enabled = inSETuesday.Enabled = inSEWednesday.Enabled = inSEThursday.Enabled = inSEFriday.Enabled = true;
            }
        }



        #endregion

        #endregion

        //lblPEName
    }
}