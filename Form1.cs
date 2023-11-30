using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;
using TODO;

namespace projoffline
{
    public partial class Form1 : Form
    {

        private List<TDTodo> todoList = new List<TDTodo>(); //listing of todo items
        private List<IEvent> eventList = new List<IEvent>();//list of all events in calendar
        private int tdindex; // index to be updated when todoList items are being updated
        private int eindex;  // index to be updated when eventList items are being updated
        private DateTime userSelectedDate;
        private double totalTodos = 0;
        private double finishedTodos = 0;
        public Form1()
        {
            InitializeComponent();

            //set date formats for events creation
            inPEStartTimeDate.Format = inPEEndTimeDate.Format = inWStartTimeDate.Format = inWEndTimeDate.Format = inSEStartTimeDate.Format = inSEEndTimeDate.Format = DateTimePickerFormat.Custom;
            inPEStartTimeDate.CustomFormat = inPEEndTimeDate.CustomFormat = inWStartTimeDate.CustomFormat = inWEndTimeDate.CustomFormat = inSEStartTimeDate.CustomFormat = inSEEndTimeDate.CustomFormat = "h:mm tt 'on' MMM dd";
            userSelectedDate = DateTime.Now;
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
            finishedTodos += 1;
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
                totalTodos += 1;
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
            lblTodoPB.Show();
            pbTodoProgress.Show();
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
            lblTodoPB.Hide();
            pbTodoProgress.Hide();
        }
        #endregion
        private void updateTDL()    //updates todo list after todoList has been edited
        {
            pbTodoProgress.Value = (int)((finishedTodos/totalTodos)*100);
            lblTodoPB.Text = "Todo List Progress: (" + finishedTodos.ToString() + "/" + totalTodos.ToString() + ")";
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
            List<IEvent> eventsToday = eventList.Where(e => e.StartTime.Date.Day == userSelectedDate.Day).ToList();
            foreach (IEvent e in eventsToday)
            {
                lbSelectedDayEvents.Items.Add(e.ToShortString);
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
            hideAllEventButtons();
            showEventAddCancelButtons();
            clearAllEventInputs();
            tcCreateEvents.Hide();
            btnEEdit.Enabled = btnEDelete.Enabled = false;
            showECtrlPanel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tmpdt = DateTime.Now;
            lblMainLabel.Text = tmpdt.ToString("dddd: MMM d, yyyy");
            lblTime.Text = tmpdt.ToString("t");
            timer1.Interval = 10000;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            userSelectedDate = monthCalendar1.SelectionStart;
            updateEL();
        }

        #region Show/Hide Displays
        private void hideAllEventButtons()
        {
            btnPECreate.Hide();
            btnPECancel.Hide();
            btnPEUpdate.Hide();
            btnWECreate.Hide();
            btnWECancel.Hide();
            btnWEUpdate.Hide();
            btnSECreate.Hide();
            btnSECancel.Hide();
            btnSEUpdate.Hide();
        }
        private void showEventAddCancelButtons()
        {
            btnPECreate.Show();
            btnPECancel.Show();
            btnWECreate.Show();
            btnWECancel.Show();
            btnSECreate.Show();
            btnSECancel.Show();
        }
        private void showECtrlPanel()
        {
            btnEAdd.Show();
            btnEEdit.Show();
            btnEDelete.Show();
            monthCalendar1.Enabled = true;
        }
        private void hideECtrlPanel()
        {
            btnEAdd.Hide();
            btnEEdit.Hide();
            btnEDelete.Hide();
            monthCalendar1.Enabled = false;
        }
        #endregion
        #region Event Control Panel
        private void btnEAdd_Click(object sender, EventArgs e)
        {
            hideECtrlPanel();
            btnPEUpdate.Hide();
            btnWEUpdate.Hide();
            btnSEUpdate.Hide();
            inSEStartTimeDate.Value = inWStartTimeDate.Value = inPEStartTimeDate.Value = userSelectedDate;
            inSEEndTimeDate.Value = inWEndTimeDate.Value = inPEEndTimeDate.Value = userSelectedDate.AddHours(1);
            tcCreateEvents.Show();
        }
        private void btnEEdit_Click(object sender, EventArgs e)
        {
            hideECtrlPanel();
            tcCreateEvents.Show();

            string tmpename = lbSelectedDayEvents.GetItemText(lbSelectedDayEvents.SelectedItem);
            IEvent tmpe = eventList.Where(x => x.ToShortString == tmpename && x.StartTime.Date.Day == userSelectedDate.Day).FirstOrDefault();
            eindex = eventList.FindIndex(x => x.ToShortString == tmpename && x.StartTime.Date.Day == userSelectedDate.Day);
            if (tmpe is TDEPersonal)
            {
                hideAllEventButtons();                      //disallow input to be submitted in other tabs
                btnPEUpdate.Show();                         //no obvious way to disable tabs in tab control object
                btnPECancel.Show();
                TDEPersonal tmpp = (TDEPersonal)tmpe;       //cast to right type                
                inPEName.Text = tmpp.Name;                  //fill input fields with current values
                inPEStartTimeDate.Value = tmpp.StartTime;
                inPEEndTimeDate.Value = tmpp.EndTime;
                inPEDescription.Text = tmpp.Description;
                tcCreateEvents.SelectedIndex = 0;           //set correct tab
            }
            else if (tmpe is TDEWork)
            {
                hideAllEventButtons();                      //disallow input of other types
                btnWEUpdate.Show();
                btnWECancel.Show();
                TDEWork tmpw = (TDEWork)tmpe;               //create tmp copy of right type to fill input fields
                inWJobName.Text = tmpw.Name;
                inWStartTimeDate.Value = tmpw.StartTime;
                inWEndTimeDate.Value = tmpw.EndTime;
                inWCompany.Text = tmpw.Company;
                inWWage.Value = tmpw.Wage;
                tcCreateEvents.SelectedIndex = 1;           //set correct tab
            }
            else if (tmpe is TDESchool)
            {
                hideAllEventButtons();                      //disallow input of other types in edit
                btnSECancel.Show();
                btnSEUpdate.Show();
                TDESchool tmps = (TDESchool)tmpe;           //create tmp copy of right type to fill input fields
                inSEClassName.Text = tmps.Name;
                inSEClassID.Text = tmps.CID;
                inSEStartTimeDate.Value = tmps.StartTime;
                inSEEndTimeDate.Value = tmps.EndTime;
                inSEOnline.Checked = tmps.IsOnline;

                int tmpmd = tmps.EncodedMeetingDays;        //using subset sum tactic to store meeting days in a single int
                inSEMonday.Checked = tmpmd >= 16;
                if (tmpmd >= 16) tmpmd -= 16;
                inSETuesday.Checked = tmpmd >= 8;
                if (tmpmd >= 8) tmpmd -= 8;
                inSEWednesday.Checked = tmpmd >= 4;
                if (tmpmd >= 4) tmpmd -= 4;
                inSEThursday.Checked = tmpmd >= 2;
                if (tmpmd >= 2) tmpmd -= 2;
                inSEFriday.Checked = tmpmd == 1;

                tcCreateEvents.SelectedIndex = 2;           //set correct tab
            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            string tmpdel = lbSelectedDayEvents.GetItemText(lbSelectedDayEvents.SelectedItem);
            IEvent tmpev = eventList.Where(x => x.ToShortString == tmpdel && x.StartTime.Date.Day == userSelectedDate.Day).FirstOrDefault();
            eventList.Remove(tmpev);
            updateEL();
            btnEEdit.Enabled = false;
            btnEDelete.Enabled = false;
        }
        private void lbSelectedDayEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSelectedDayEvents.SelectedIndex != -1)
            {
                btnEEdit.Enabled = true;
                btnEDelete.Enabled = true;
            }
        }
        #endregion
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
        private void btnPEUpdate_Click(object sender, EventArgs e)
        {
            if (inPEName.Text != string.Empty)                           //check for empty name
            {
                eventList[eindex].Name = inPEName.Text;                  //fill values
                eventList[eindex].StartTime = inPEStartTimeDate.Value;
                eventList[eindex].EndTime = inPEEndTimeDate.Value;
                eventList[eindex].Description = inPEDescription.Text;
                updateEL();
            }
            cancelEventInput();
            btnEEdit.Enabled = false;
            btnEDelete.Enabled = false;
        }
        private void btnPECancel_Click(object sender, EventArgs e)
        {
            cancelEventInput();
        }
        private void inPEStartTimeDate_ValueChanged(object sender, EventArgs e)
        {
            inPEEndTimeDate.Value.AddHours(1);
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
        private void btnWEUpdate_Click(object sender, EventArgs e)
        {
            if (inWJobName.Text != "")
            {
                TDEWork tmpw = (TDEWork)eventList[eindex];
                tmpw.Name = inWJobName.Text;
                tmpw.StartTime = inWStartTimeDate.Value;
                tmpw.EndTime = inWEndTimeDate.Value;
                tmpw.Description = inWCompany.Text;
                tmpw.Wage = inWWage.Value;
                eventList.RemoveAt(eindex);
                eventList.Add(tmpw);
                updateEL();
            }
            cancelEventInput();
            btnEEdit.Enabled = false;
            btnEDelete.Enabled = false;
        }
        private void btnWECancel_Click(object sender, EventArgs e)
        {
            cancelEventInput();
        }
        private void inWStartTimeDate_ValueChanged(object sender, EventArgs e)
        {
            inWEndTimeDate.Value.AddHours(1);
        }
        #endregion
        #region School
        private void btnSECreate_Click(object sender, EventArgs e)
        {
            if (inSEClassName.Text != "")
            {
                int meetingDays = 0;
                if (!inSEOnline.Checked)
                {
                    if (inSEMonday.Checked) { meetingDays += 16; }
                    if (inSETuesday.Checked) { meetingDays += 8; }
                    if (inSEWednesday.Checked) { meetingDays += 4; }
                    if (inSEThursday.Checked) { meetingDays += 2; }
                    if (inSEFriday.Checked) { meetingDays += 1; }
                }
                TDESchool tmpschool = new TDESchool(inSEClassID.Text, inSEOnline.Checked, meetingDays, inSEStartTimeDate.Value, inSEEndTimeDate.Value, inSEClassName.Text);
                eventList.Add(tmpschool);
                updateEL();
                cancelEventInput();
            }
        }
        private void btnSEUpdate_Click(object sender, EventArgs e)
        {
            if (inSEClassName.Text != "")
            {
                TDESchool tmps = (TDESchool)eventList[eindex];
                tmps.Name = inSEClassName.Text;
                tmps.CID = inSEClassID.Text;
                tmps.StartTime = inSEStartTimeDate.Value;
                tmps.EndTime = inSEEndTimeDate.Value;
                tmps.IsOnline = inSEOnline.Checked;

                int meetingdays = 0;
                if (inSEMonday.Checked) { meetingdays +=16; }
                if (inSETuesday.Checked) { meetingdays += 8; }
                if (inSEWednesday.Checked) { meetingdays += 4; }
                if (inSEThursday.Checked) { meetingdays += 2; }
                if (inSEFriday.Checked) { meetingdays += 1; }

                tmps.EncodedMeetingDays = meetingdays;
                updateEL();
            }
            cancelEventInput();
            btnEEdit.Enabled = false;
            btnEDelete.Enabled = false;
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
        private void inSEStartTimeDate_ValueChanged(object sender, EventArgs e)
        {
            inSEEndTimeDate.Value.AddHours(1);
        }
        #endregion

        #endregion
    }
}