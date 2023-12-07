using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
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
        private double hrsInClass = 0;
        private double moneyMade = 0;
        public Form1()
        {
            InitializeComponent();

            //set date formats for events creation
            inPEStartTimeDate.Format = inPEEndTimeDate.Format = inWStartTimeDate.Format = inWEndTimeDate.Format = inSEStartTimeDate.Format = inSEEndTimeDate.Format = DateTimePickerFormat.Custom;
            inPEStartTimeDate.CustomFormat = inPEEndTimeDate.CustomFormat = inWStartTimeDate.CustomFormat = inWEndTimeDate.CustomFormat = inSEStartTimeDate.CustomFormat = inSEEndTimeDate.CustomFormat = "h:mm tt 'on' MMM dd";
            userSelectedDate = DateTime.Now;
            ttEventTip.SetToolTip(lbSelectedDayEvents, null);
            lblHoursInClass.Hide();
            lblMoneyMade.Hide();
            displayClearTodo();
            displayClearDayEvents();

            this.FormClosing += Form1_FormClosing;
        }

        #region TODO_List

        private void displayClearTodo()
        {
            lbTODOlisting.Items.Clear();
            lbTODOlisting.Items.Add("You're all caught up!");
        }

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
            bool duplicate = false;
            foreach (var td in todoList)
            {
                if (inItemName.Text == td.Name) duplicate = true;
            }
            if (duplicate)
            {
                MessageBox.Show("NOTICE: You cannot have duplicate names for todo items", "ERROR!");
                return;
            }
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
            bool duplicate = false;
            foreach (var td in todoList)
            {
                if (inItemName.Text == td.Name) duplicate = true;
            }
            if (duplicate)
            {
                MessageBox.Show("NOTICE: You cannot have duplicate names for todo items", "ERROR!");
                return;
            }
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
            showInfoPanel();
        }
        private void hideTDCtrlPanel()
        {
            btnTAdd.Hide();
            btnTEdit.Hide();
            btnTFinish.Hide();
            hideInfoPanel();
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
            if (todoList.Count == 0) displayClearTodo();
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
        private void displayClearDayEvents()
        {
            if (eventList.Where(e => e.StartTime.Date == userSelectedDate.Date).ToList().Count() == 0)
            {
                lbSelectedDayEvents.Items.Clear();
                if (userSelectedDate.Date == DateTime.Now.Date) lbSelectedDayEvents.Items.Add("Nothing to do today!");
                else lbSelectedDayEvents.Items.Add("Nothing to do on " + userSelectedDate.Date.ToString("d") + "!");
            }
        }
        private void updateEL()
        {
            eventList.Sort((e1, e2) => e1.StartTime.CompareTo(e2.StartTime));
            lbSelectedDayEvents.Items.Clear();
            List<IEvent> eventsToday = eventList.Where(e => e.StartTime.Date.Day == userSelectedDate.Day).ToList();
            foreach (IEvent e in eventsToday)
            {
                lbSelectedDayEvents.Items.Add(e.ToShortString);
            }
            if (lbSelectedDayEvents.Items.Count == 0) displayClearDayEvents();
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
            lblMainLabel.Text = tmpdt.ToString("h:mm dddd");
            timer1.Interval = 10000;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            userSelectedDate = monthCalendar1.SelectionStart;
            updateEL();
            updateHrsInClass();
            updateMoneyMade();
        }
        private bool checkTimeOrder()
        {
            if (inPEStartTimeDate.Value > inPEEndTimeDate.Value)
            {
                MessageBox.Show("NOTICE: The ending time must be later than the starting time.", "ERROR!");
                return true;
            }
            return false;
        }
        private bool checkDuplicates(int inputType) //inputType 0 -> Personal, 1 -> Work, 2 -> School
        {
            if (eventList.Count(e => e.ToShortString == lbSelectedDayEvents.GetItemText(lbSelectedDayEvents.SelectedItem)) == 1) return false;
            bool duplicate = false;
            foreach (var eve in eventList)
            {
                if (inputType == 0 && inPEStartTimeDate.Value == eve.StartTime) duplicate = true;
                if (inputType == 1 &&  inWStartTimeDate.Value == eve.StartTime) duplicate = true;
                if (inputType == 2 && inSEStartTimeDate.Value == eve.StartTime) duplicate = true;
            }
            if (duplicate)
            {
                MessageBox.Show("NOTICE: Only one event can be scheduled to start at a given time.\nPlease enter a new Start Time.", "ERROR!");
            }
            return duplicate;
        }

        #endregion
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
                IEvent tmpev = eventList.Where(x => x.ToShortString == lbSelectedDayEvents.GetItemText(lbSelectedDayEvents.SelectedItem)).FirstOrDefault();
                ttEventTip.SetToolTip(lbSelectedDayEvents, tmpev.ToLongString);
            }
        }
        #endregion
        #region Personal
        private void btnPECreate_Click(object sender, EventArgs e)
        {
            if (checkTimeOrder()) return;
            if (checkDuplicates(0)) return;
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
            if (checkTimeOrder()) return;
            if (checkDuplicates(0)) return;
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
            if (checkTimeOrder()) return;
            if (checkDuplicates(1)) return;
            if (inWJobName.Text != string.Empty)
            {
                TDEWork tmpwork = new TDEWork(inWCompany.Text, inWWage.Value, inWStartTimeDate.Value, inWEndTimeDate.Value, inWJobName.Text);
                eventList.Add(tmpwork);
                updateEL();
                updateMoneyMade();
                cancelEventInput();
            }
        }
        private void btnWEUpdate_Click(object sender, EventArgs e)
        {
            if (checkTimeOrder()) return;
            if (checkDuplicates(1)) return;
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
                updateMoneyMade();
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
            if (checkTimeOrder()) return;
            if (checkDuplicates(2)) return;
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
                updateHrsInClass();
                cancelEventInput();
            }
        }
        private void btnSEUpdate_Click(object sender, EventArgs e)
        {
            if (checkTimeOrder()) return;
            if (checkDuplicates(2)) return;
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
                updateHrsInClass();
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

        #region Info Panel
        private void hideInfoPanel()
        {
            lblTodoPB.Hide();
            pbTodoProgress.Hide();
            lblHoursInClass.Hide();
            lblMoneyMade.Hide();
        }
        private void showInfoPanel()
        {
            lblTodoPB.Show();
            pbTodoProgress.Show();
            if (hrsInClass > 0) lblHoursInClass.Show();
            if (moneyMade > 0) lblMoneyMade.Show();
        }
        private void updateHrsInClass()
        {
            List<TDESchool> classes = new List<TDESchool>();
            foreach (var eve in eventList)
            {
                if (eve is TDESchool) classes.Add((TDESchool)eve);
            }
            classes = classes.Where(e => e.StartTime < userSelectedDate.AddDays(7-(double)userSelectedDate.DayOfWeek)).ToList();
            classes = classes.Where(e => e.StartTime > userSelectedDate.AddDays(-(double)userSelectedDate.DayOfWeek)).ToList();
            for (int i = 0; i < classes.Count; i++)
            {
                TDESchool tmp = classes[i];
                for (int j = i + 1; j < classes.Count; j++)
                {
                    if (tmp.CID == classes[j].CID && tmp.EncodedMeetingDays == classes[j].EncodedMeetingDays)
                    {
                        classes.Remove(classes[j]);
                        j--;
                    }
                }
            }
            hrsInClass = classes.Sum(e => e.HrsInClassPerWeek());
            lblHoursInClass.Text = "Time in class: " + hrsInClass.ToString("0.0") + " hrs";
            if (hrsInClass == 0) lblHoursInClass.Hide();
            else lblHoursInClass.Show();
        }
        private void updateMoneyMade()
        {
            List<TDEWork> shifts = new List<TDEWork>();
            foreach (var eve in eventList)
            {
                if (eve is TDEWork) shifts.Add((TDEWork)eve);
            }
            shifts = shifts.Where(e => e.StartTime < userSelectedDate.AddDays(7-(double)userSelectedDate.DayOfWeek)).ToList();
            shifts = shifts.Where(e => e.StartTime > userSelectedDate.AddDays(-(double)userSelectedDate.DayOfWeek)).ToList();
            moneyMade = shifts.Sum(s => (double)s.GetPay());
            lblMoneyMade.Text = "Cash made this week:\n   est. $" + moneyMade.ToString("0.00");
            if (moneyMade == 0) lblMoneyMade.Hide();
            else lblMoneyMade.Show();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //load data in this function
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save data here
            string tmp;
            string form1path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);//change THIS!!!!
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(form1path, "todosave.csv")))
            {
                foreach(var td in todoList)
                {
                    tmp = (td.Name + "#" + td.Description + "#" + td.ImportanceLevel);
                    outputFile.WriteLine(tmp);
                }
            }
            foreach(var eve in eventList)
            {
                if(eve is TDEPersonal)
                {
                    var tmpe = (TDEPersonal)eve;
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(form1path, "epersonalsave.csv"), true))
                    {
                        tmp = tmpe.Name + "#" + tmpe.Description + "#" + tmpe.StartTime + "#" + tmpe.EndTime;
                        outputFile.WriteLine(tmp);
                    }
                } else if (eve is TDEWork)
                {
                    var tmpe = (TDEWork)eve;
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(form1path, "eworksave.csv"), true))
                    {
                        tmp = tmpe.Name + "#" + tmpe.Company + "#" + tmpe.Wage + "#" + tmpe.StartTime + "#" + tmpe.EndTime;
                        outputFile.WriteLine(tmp);
                    }
                } else
                {
                    var tmpe = (TDESchool)eve;
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(form1path, "eschool.csv"), true))
                    {
                        tmp = tmpe.Name + "#" + tmpe.CID + "#" + tmpe.IsOnline + "#" + tmpe.EncodedMeetingDays + "#" + tmpe.StartTime + "#" + tmpe.EndTime;
                        outputFile.WriteLine(tmp);
                    }
                }
            }            
        }
    }
}