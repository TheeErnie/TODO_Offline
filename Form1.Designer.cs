namespace projoffline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            monthCalendar1=new MonthCalendar();
            lbTODOlisting=new ListBox();
            lbSelectedDayEvents=new ListBox();
            lblItemName=new Label();
            lblItemDescription=new Label();
            lblImportanceLevel=new Label();
            inItemName=new RichTextBox();
            inImportanceLevel=new NumericUpDown();
            inItemDescription=new RichTextBox();
            btnCreateTodo=new Button();
            tcCreateEvents=new TabControl();
            tpPersonal=new TabPage();
            btnPEUpdate=new Button();
            btnPECancel=new Button();
            btnPECreate=new Button();
            inPEDescription=new RichTextBox();
            inPEEndTimeDate=new DateTimePicker();
            inPEStartTimeDate=new DateTimePicker();
            inPEName=new RichTextBox();
            lblPEDescription=new Label();
            lblPEEndTime=new Label();
            lblPEStartTime=new Label();
            lblPEName=new Label();
            tpWork=new TabPage();
            btnWEUpdate=new Button();
            btnWECancel=new Button();
            btnWECreate=new Button();
            inWEndTimeDate=new DateTimePicker();
            inWStartTimeDate=new DateTimePicker();
            inWWage=new NumericUpDown();
            inWCompany=new RichTextBox();
            inWJobName=new RichTextBox();
            lblWCompany=new Label();
            lblWEndTimeDate=new Label();
            lblWStartTimeDate=new Label();
            lblWWage=new Label();
            lblWName=new Label();
            tpSchool=new TabPage();
            btnSEUpdate=new Button();
            inSEFriday=new CheckBox();
            inSEThursday=new CheckBox();
            inSEWednesday=new CheckBox();
            inSETuesday=new CheckBox();
            inSEMonday=new CheckBox();
            inSEOnline=new CheckBox();
            btnSECancel=new Button();
            btnSECreate=new Button();
            inSEStartTimeDate=new DateTimePicker();
            inSEEndTimeDate=new DateTimePicker();
            inSEClassID=new RichTextBox();
            inSEClassName=new RichTextBox();
            lblSEMeetingDays=new Label();
            lblSEEndTimeDate=new Label();
            lblSEStartTimeDate=new Label();
            lblSEClassID=new Label();
            lblSEClass=new Label();
            btnTAdd=new Button();
            btnTEdit=new Button();
            btnTFinish=new Button();
            btnCancelCreateTodo=new Button();
            btnUpdateTodo=new Button();
            btnEDelete=new Button();
            btnEEdit=new Button();
            btnEAdd=new Button();
            timer1=new System.Windows.Forms.Timer(components);
            lblMainLabel=new Label();
            lblTime=new Label();
            pbTodoProgress=new ProgressBar();
            lblTodoPB=new Label();
            ((System.ComponentModel.ISupportInitialize)inImportanceLevel).BeginInit();
            tcCreateEvents.SuspendLayout();
            tpPersonal.SuspendLayout();
            tpWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inWWage).BeginInit();
            tpSchool.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location=new Point(12, 57);
            monthCalendar1.Name="monthCalendar1";
            monthCalendar1.TabIndex=0;
            monthCalendar1.DateChanged+=monthCalendar1_DateChanged;
            // 
            // lbTODOlisting
            // 
            lbTODOlisting.FormattingEnabled=true;
            lbTODOlisting.ItemHeight=15;
            lbTODOlisting.Location=new Point(505, 12);
            lbTODOlisting.Name="lbTODOlisting";
            lbTODOlisting.Size=new Size(176, 289);
            lbTODOlisting.TabIndex=3;
            lbTODOlisting.SelectedIndexChanged+=lbTODOlisting_SelectedIndexChanged;
            // 
            // lbSelectedDayEvents
            // 
            lbSelectedDayEvents.FormattingEnabled=true;
            lbSelectedDayEvents.ItemHeight=15;
            lbSelectedDayEvents.Location=new Point(12, 231);
            lbSelectedDayEvents.Name="lbSelectedDayEvents";
            lbSelectedDayEvents.Size=new Size(227, 199);
            lbSelectedDayEvents.TabIndex=100;
            lbSelectedDayEvents.SelectedIndexChanged+=lbSelectedDayEvents_SelectedIndexChanged;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize=true;
            lblItemName.Location=new Point(505, 309);
            lblItemName.Name="lblItemName";
            lblItemName.Size=new Size(69, 15);
            lblItemName.TabIndex=4;
            lblItemName.Text="Item Name:";
            lblItemName.Visible=false;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize=true;
            lblItemDescription.Location=new Point(505, 361);
            lblItemDescription.Name="lblItemDescription";
            lblItemDescription.Size=new Size(97, 15);
            lblItemDescription.TabIndex=8;
            lblItemDescription.Text="Item Description:";
            lblItemDescription.Visible=false;
            // 
            // lblImportanceLevel
            // 
            lblImportanceLevel.AutoSize=true;
            lblImportanceLevel.Location=new Point(505, 336);
            lblImportanceLevel.Name="lblImportanceLevel";
            lblImportanceLevel.Size=new Size(101, 15);
            lblImportanceLevel.TabIndex=6;
            lblImportanceLevel.Text="Importance Level:";
            lblImportanceLevel.Visible=false;
            // 
            // inItemName
            // 
            inItemName.Location=new Point(580, 306);
            inItemName.MaxLength=40;
            inItemName.Name="inItemName";
            inItemName.ScrollBars=RichTextBoxScrollBars.None;
            inItemName.Size=new Size(101, 18);
            inItemName.TabIndex=5;
            inItemName.TabStop=false;
            inItemName.Text="";
            inItemName.Visible=false;
            inItemName.WordWrap=false;
            // 
            // inImportanceLevel
            // 
            inImportanceLevel.Location=new Point(622, 334);
            inImportanceLevel.Maximum=new decimal(new int[] { 2, 0, 0, 0 });
            inImportanceLevel.Name="inImportanceLevel";
            inImportanceLevel.Size=new Size(59, 23);
            inImportanceLevel.TabIndex=7;
            inImportanceLevel.Visible=false;
            // 
            // inItemDescription
            // 
            inItemDescription.Location=new Point(505, 379);
            inItemDescription.MaxLength=500;
            inItemDescription.Name="inItemDescription";
            inItemDescription.ScrollBars=RichTextBoxScrollBars.None;
            inItemDescription.Size=new Size(176, 80);
            inItemDescription.TabIndex=9;
            inItemDescription.TabStop=false;
            inItemDescription.Text="";
            inItemDescription.Visible=false;
            // 
            // btnCreateTodo
            // 
            btnCreateTodo.Location=new Point(505, 465);
            btnCreateTodo.Name="btnCreateTodo";
            btnCreateTodo.Size=new Size(176, 23);
            btnCreateTodo.TabIndex=10;
            btnCreateTodo.Text="&Create";
            btnCreateTodo.UseVisualStyleBackColor=true;
            btnCreateTodo.Visible=false;
            btnCreateTodo.Click+=button1_Click;
            // 
            // tcCreateEvents
            // 
            tcCreateEvents.Controls.Add(tpPersonal);
            tcCreateEvents.Controls.Add(tpWork);
            tcCreateEvents.Controls.Add(tpSchool);
            tcCreateEvents.Location=new Point(12, 231);
            tcCreateEvents.Name="tcCreateEvents";
            tcCreateEvents.SelectedIndex=0;
            tcCreateEvents.Size=new Size(227, 286);
            tcCreateEvents.TabIndex=200;
            tcCreateEvents.Visible=false;
            // 
            // tpPersonal
            // 
            tpPersonal.Controls.Add(btnPEUpdate);
            tpPersonal.Controls.Add(btnPECancel);
            tpPersonal.Controls.Add(btnPECreate);
            tpPersonal.Controls.Add(inPEDescription);
            tpPersonal.Controls.Add(inPEEndTimeDate);
            tpPersonal.Controls.Add(inPEStartTimeDate);
            tpPersonal.Controls.Add(inPEName);
            tpPersonal.Controls.Add(lblPEDescription);
            tpPersonal.Controls.Add(lblPEEndTime);
            tpPersonal.Controls.Add(lblPEStartTime);
            tpPersonal.Controls.Add(lblPEName);
            tpPersonal.Location=new Point(4, 24);
            tpPersonal.Name="tpPersonal";
            tpPersonal.Padding=new Padding(3);
            tpPersonal.Size=new Size(219, 258);
            tpPersonal.TabIndex=0;
            tpPersonal.Text="Personal";
            tpPersonal.UseVisualStyleBackColor=true;
            // 
            // btnPEUpdate
            // 
            btnPEUpdate.Location=new Point(5, 227);
            btnPEUpdate.Name="btnPEUpdate";
            btnPEUpdate.Size=new Size(102, 25);
            btnPEUpdate.TabIndex=210;
            btnPEUpdate.Text="Update";
            btnPEUpdate.UseVisualStyleBackColor=true;
            btnPEUpdate.Click+=btnPEUpdate_Click;
            // 
            // btnPECancel
            // 
            btnPECancel.Location=new Point(112, 227);
            btnPECancel.Name="btnPECancel";
            btnPECancel.Size=new Size(102, 25);
            btnPECancel.TabIndex=211;
            btnPECancel.Text="Cancel";
            btnPECancel.UseVisualStyleBackColor=true;
            btnPECancel.Click+=btnPECancel_Click;
            // 
            // btnPECreate
            // 
            btnPECreate.Location=new Point(5, 227);
            btnPECreate.Name="btnPECreate";
            btnPECreate.Size=new Size(102, 25);
            btnPECreate.TabIndex=209;
            btnPECreate.Text="Create";
            btnPECreate.UseVisualStyleBackColor=true;
            btnPECreate.Click+=btnPECreate_Click;
            // 
            // inPEDescription
            // 
            inPEDescription.Location=new Point(5, 109);
            inPEDescription.MaxLength=1000;
            inPEDescription.Multiline=false;
            inPEDescription.Name="inPEDescription";
            inPEDescription.Size=new Size(209, 112);
            inPEDescription.TabIndex=208;
            inPEDescription.Text="";
            // 
            // inPEEndTimeDate
            // 
            inPEEndTimeDate.Format=DateTimePickerFormat.Custom;
            inPEEndTimeDate.Location=new Point(70, 60);
            inPEEndTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inPEEndTimeDate.Name="inPEEndTimeDate";
            inPEEndTimeDate.Size=new Size(144, 23);
            inPEEndTimeDate.TabIndex=206;
            // 
            // inPEStartTimeDate
            // 
            inPEStartTimeDate.Format=DateTimePickerFormat.Custom;
            inPEStartTimeDate.Location=new Point(70, 30);
            inPEStartTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inPEStartTimeDate.Name="inPEStartTimeDate";
            inPEStartTimeDate.Size=new Size(144, 23);
            inPEStartTimeDate.TabIndex=204;
            inPEStartTimeDate.ValueChanged+=inPEStartTimeDate_ValueChanged;
            // 
            // inPEName
            // 
            inPEName.Location=new Point(80, 6);
            inPEName.MaxLength=40;
            inPEName.Multiline=false;
            inPEName.Name="inPEName";
            inPEName.Size=new Size(134, 20);
            inPEName.TabIndex=202;
            inPEName.Text="";
            // 
            // lblPEDescription
            // 
            lblPEDescription.AutoSize=true;
            lblPEDescription.Location=new Point(5, 91);
            lblPEDescription.Name="lblPEDescription";
            lblPEDescription.Size=new Size(70, 15);
            lblPEDescription.TabIndex=207;
            lblPEDescription.Text="Description:";
            // 
            // lblPEEndTime
            // 
            lblPEEndTime.AutoSize=true;
            lblPEEndTime.Location=new Point(5, 64);
            lblPEEndTime.Name="lblPEEndTime";
            lblPEEndTime.Size=new Size(59, 15);
            lblPEEndTime.TabIndex=205;
            lblPEEndTime.Text="End Time:";
            // 
            // lblPEStartTime
            // 
            lblPEStartTime.AutoSize=true;
            lblPEStartTime.Location=new Point(5, 34);
            lblPEStartTime.Name="lblPEStartTime";
            lblPEStartTime.Size=new Size(63, 15);
            lblPEStartTime.TabIndex=203;
            lblPEStartTime.Text="Start Time:";
            // 
            // lblPEName
            // 
            lblPEName.AutoSize=true;
            lblPEName.Location=new Point(5, 8);
            lblPEName.Name="lblPEName";
            lblPEName.Size=new Size(74, 15);
            lblPEName.TabIndex=201;
            lblPEName.Text="Event Name:";
            // 
            // tpWork
            // 
            tpWork.Controls.Add(btnWEUpdate);
            tpWork.Controls.Add(btnWECancel);
            tpWork.Controls.Add(btnWECreate);
            tpWork.Controls.Add(inWEndTimeDate);
            tpWork.Controls.Add(inWStartTimeDate);
            tpWork.Controls.Add(inWWage);
            tpWork.Controls.Add(inWCompany);
            tpWork.Controls.Add(inWJobName);
            tpWork.Controls.Add(lblWCompany);
            tpWork.Controls.Add(lblWEndTimeDate);
            tpWork.Controls.Add(lblWStartTimeDate);
            tpWork.Controls.Add(lblWWage);
            tpWork.Controls.Add(lblWName);
            tpWork.Location=new Point(4, 24);
            tpWork.Name="tpWork";
            tpWork.Padding=new Padding(3);
            tpWork.Size=new Size(219, 258);
            tpWork.TabIndex=1;
            tpWork.Text="Work";
            tpWork.UseVisualStyleBackColor=true;
            // 
            // btnWEUpdate
            // 
            btnWEUpdate.Location=new Point(5, 227);
            btnWEUpdate.Name="btnWEUpdate";
            btnWEUpdate.Size=new Size(102, 25);
            btnWEUpdate.TabIndex=231;
            btnWEUpdate.Text="Update";
            btnWEUpdate.UseVisualStyleBackColor=true;
            btnWEUpdate.Click+=btnWEUpdate_Click;
            // 
            // btnWECancel
            // 
            btnWECancel.Location=new Point(112, 227);
            btnWECancel.Name="btnWECancel";
            btnWECancel.Size=new Size(102, 25);
            btnWECancel.TabIndex=232;
            btnWECancel.Text="Cancel";
            btnWECancel.UseVisualStyleBackColor=true;
            btnWECancel.Click+=btnWECancel_Click;
            // 
            // btnWECreate
            // 
            btnWECreate.Location=new Point(5, 227);
            btnWECreate.Name="btnWECreate";
            btnWECreate.Size=new Size(102, 25);
            btnWECreate.TabIndex=230;
            btnWECreate.Text="Create";
            btnWECreate.UseVisualStyleBackColor=true;
            btnWECreate.Click+=btnWECreate_Click;
            // 
            // inWEndTimeDate
            // 
            inWEndTimeDate.Format=DateTimePickerFormat.Custom;
            inWEndTimeDate.Location=new Point(70, 60);
            inWEndTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inWEndTimeDate.Name="inWEndTimeDate";
            inWEndTimeDate.Size=new Size(144, 23);
            inWEndTimeDate.TabIndex=225;
            // 
            // inWStartTimeDate
            // 
            inWStartTimeDate.Format=DateTimePickerFormat.Custom;
            inWStartTimeDate.Location=new Point(70, 30);
            inWStartTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inWStartTimeDate.Name="inWStartTimeDate";
            inWStartTimeDate.Size=new Size(144, 23);
            inWStartTimeDate.TabIndex=223;
            inWStartTimeDate.ValueChanged+=inWStartTimeDate_ValueChanged;
            // 
            // inWWage
            // 
            inWWage.DecimalPlaces=2;
            inWWage.Increment=new decimal(new int[] { 1, 0, 0, 131072 });
            inWWage.Location=new Point(56, 115);
            inWWage.Name="inWWage";
            inWWage.Size=new Size(88, 23);
            inWWage.TabIndex=229;
            // 
            // inWCompany
            // 
            inWCompany.Location=new Point(70, 88);
            inWCompany.MaxLength=50;
            inWCompany.Multiline=false;
            inWCompany.Name="inWCompany";
            inWCompany.Size=new Size(144, 21);
            inWCompany.TabIndex=227;
            inWCompany.Text="";
            // 
            // inWJobName
            // 
            inWJobName.Location=new Point(70, 6);
            inWJobName.MaxLength=50;
            inWJobName.Multiline=false;
            inWJobName.Name="inWJobName";
            inWJobName.Size=new Size(144, 20);
            inWJobName.TabIndex=221;
            inWJobName.Text="";
            // 
            // lblWCompany
            // 
            lblWCompany.AutoSize=true;
            lblWCompany.Location=new Point(5, 91);
            lblWCompany.Name="lblWCompany";
            lblWCompany.Size=new Size(62, 15);
            lblWCompany.TabIndex=226;
            lblWCompany.Text="Company:";
            // 
            // lblWEndTimeDate
            // 
            lblWEndTimeDate.AutoSize=true;
            lblWEndTimeDate.Location=new Point(5, 64);
            lblWEndTimeDate.Name="lblWEndTimeDate";
            lblWEndTimeDate.Size=new Size(59, 15);
            lblWEndTimeDate.TabIndex=224;
            lblWEndTimeDate.Text="End Time:";
            // 
            // lblWStartTimeDate
            // 
            lblWStartTimeDate.AutoSize=true;
            lblWStartTimeDate.Location=new Point(5, 34);
            lblWStartTimeDate.Name="lblWStartTimeDate";
            lblWStartTimeDate.Size=new Size(63, 15);
            lblWStartTimeDate.TabIndex=222;
            lblWStartTimeDate.Text="Start Time:";
            // 
            // lblWWage
            // 
            lblWWage.AutoSize=true;
            lblWWage.Location=new Point(5, 119);
            lblWWage.Name="lblWWage";
            lblWWage.Size=new Size(49, 15);
            lblWWage.TabIndex=228;
            lblWWage.Text="Wage: $";
            // 
            // lblWName
            // 
            lblWName.AutoSize=true;
            lblWName.Location=new Point(5, 8);
            lblWName.Name="lblWName";
            lblWName.Size=new Size(63, 15);
            lblWName.TabIndex=220;
            lblWName.Text="Job Name:";
            // 
            // tpSchool
            // 
            tpSchool.Controls.Add(btnSEUpdate);
            tpSchool.Controls.Add(inSEFriday);
            tpSchool.Controls.Add(inSEThursday);
            tpSchool.Controls.Add(inSEWednesday);
            tpSchool.Controls.Add(inSETuesday);
            tpSchool.Controls.Add(inSEMonday);
            tpSchool.Controls.Add(inSEOnline);
            tpSchool.Controls.Add(btnSECancel);
            tpSchool.Controls.Add(btnSECreate);
            tpSchool.Controls.Add(inSEStartTimeDate);
            tpSchool.Controls.Add(inSEEndTimeDate);
            tpSchool.Controls.Add(inSEClassID);
            tpSchool.Controls.Add(inSEClassName);
            tpSchool.Controls.Add(lblSEMeetingDays);
            tpSchool.Controls.Add(lblSEEndTimeDate);
            tpSchool.Controls.Add(lblSEStartTimeDate);
            tpSchool.Controls.Add(lblSEClassID);
            tpSchool.Controls.Add(lblSEClass);
            tpSchool.Location=new Point(4, 24);
            tpSchool.Name="tpSchool";
            tpSchool.Padding=new Padding(3);
            tpSchool.Size=new Size(219, 258);
            tpSchool.TabIndex=2;
            tpSchool.Text="School";
            tpSchool.UseVisualStyleBackColor=true;
            // 
            // btnSEUpdate
            // 
            btnSEUpdate.Location=new Point(5, 227);
            btnSEUpdate.Name="btnSEUpdate";
            btnSEUpdate.Size=new Size(102, 25);
            btnSEUpdate.TabIndex=256;
            btnSEUpdate.Text="Update";
            btnSEUpdate.UseVisualStyleBackColor=true;
            btnSEUpdate.Click+=btnSEUpdate_Click;
            // 
            // inSEFriday
            // 
            inSEFriday.AutoSize=true;
            inSEFriday.Location=new Point(30, 175);
            inSEFriday.Name="inSEFriday";
            inSEFriday.Size=new Size(58, 19);
            inSEFriday.TabIndex=253;
            inSEFriday.Text="Friday";
            inSEFriday.UseVisualStyleBackColor=true;
            // 
            // inSEThursday
            // 
            inSEThursday.AutoSize=true;
            inSEThursday.Location=new Point(119, 155);
            inSEThursday.Name="inSEThursday";
            inSEThursday.Size=new Size(74, 19);
            inSEThursday.TabIndex=252;
            inSEThursday.Text="Thursday";
            inSEThursday.UseVisualStyleBackColor=true;
            // 
            // inSEWednesday
            // 
            inSEWednesday.AutoSize=true;
            inSEWednesday.Location=new Point(30, 155);
            inSEWednesday.Name="inSEWednesday";
            inSEWednesday.Size=new Size(87, 19);
            inSEWednesday.TabIndex=251;
            inSEWednesday.Text="Wednesday";
            inSEWednesday.UseVisualStyleBackColor=true;
            // 
            // inSETuesday
            // 
            inSETuesday.AutoSize=true;
            inSETuesday.Location=new Point(119, 135);
            inSETuesday.Name="inSETuesday";
            inSETuesday.Size=new Size(69, 19);
            inSETuesday.TabIndex=250;
            inSETuesday.Text="Tuesday";
            inSETuesday.UseVisualStyleBackColor=true;
            // 
            // inSEMonday
            // 
            inSEMonday.AutoSize=true;
            inSEMonday.Location=new Point(30, 135);
            inSEMonday.Name="inSEMonday";
            inSEMonday.Size=new Size(70, 19);
            inSEMonday.TabIndex=249;
            inSEMonday.Text="Monday";
            inSEMonday.UseVisualStyleBackColor=true;
            // 
            // inSEOnline
            // 
            inSEOnline.AutoSize=true;
            inSEOnline.Location=new Point(7, 199);
            inSEOnline.Name="inSEOnline";
            inSEOnline.Size=new Size(91, 19);
            inSEOnline.TabIndex=254;
            inSEOnline.Text="Online Class";
            inSEOnline.UseVisualStyleBackColor=true;
            inSEOnline.CheckedChanged+=inSEOnline_CheckedChanged;
            // 
            // btnSECancel
            // 
            btnSECancel.Location=new Point(112, 227);
            btnSECancel.Name="btnSECancel";
            btnSECancel.Size=new Size(102, 25);
            btnSECancel.TabIndex=257;
            btnSECancel.Text="Cancel";
            btnSECancel.UseVisualStyleBackColor=true;
            btnSECancel.Click+=btnSECancel_Click;
            // 
            // btnSECreate
            // 
            btnSECreate.Location=new Point(5, 227);
            btnSECreate.Name="btnSECreate";
            btnSECreate.Size=new Size(102, 25);
            btnSECreate.TabIndex=255;
            btnSECreate.Text="Create";
            btnSECreate.UseVisualStyleBackColor=true;
            btnSECreate.Click+=btnSECreate_Click;
            // 
            // inSEStartTimeDate
            // 
            inSEStartTimeDate.Format=DateTimePickerFormat.Custom;
            inSEStartTimeDate.Location=new Point(70, 30);
            inSEStartTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inSEStartTimeDate.Name="inSEStartTimeDate";
            inSEStartTimeDate.Size=new Size(144, 23);
            inSEStartTimeDate.TabIndex=243;
            inSEStartTimeDate.ValueChanged+=inSEStartTimeDate_ValueChanged;
            // 
            // inSEEndTimeDate
            // 
            inSEEndTimeDate.Format=DateTimePickerFormat.Custom;
            inSEEndTimeDate.Location=new Point(70, 60);
            inSEEndTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inSEEndTimeDate.Name="inSEEndTimeDate";
            inSEEndTimeDate.Size=new Size(144, 23);
            inSEEndTimeDate.TabIndex=245;
            // 
            // inSEClassID
            // 
            inSEClassID.Location=new Point(59, 93);
            inSEClassID.MaxLength=50;
            inSEClassID.Multiline=false;
            inSEClassID.Name="inSEClassID";
            inSEClassID.Size=new Size(77, 20);
            inSEClassID.TabIndex=247;
            inSEClassID.Text="";
            // 
            // inSEClassName
            // 
            inSEClassName.Location=new Point(44, 6);
            inSEClassName.MaxLength=50;
            inSEClassName.Multiline=false;
            inSEClassName.Name="inSEClassName";
            inSEClassName.Size=new Size(170, 20);
            inSEClassName.TabIndex=241;
            inSEClassName.Text="";
            // 
            // lblSEMeetingDays
            // 
            lblSEMeetingDays.AutoSize=true;
            lblSEMeetingDays.Location=new Point(6, 116);
            lblSEMeetingDays.Name="lblSEMeetingDays";
            lblSEMeetingDays.Size=new Size(82, 15);
            lblSEMeetingDays.TabIndex=248;
            lblSEMeetingDays.Text="Meeting Days:";
            // 
            // lblSEEndTimeDate
            // 
            lblSEEndTimeDate.AutoSize=true;
            lblSEEndTimeDate.Location=new Point(5, 64);
            lblSEEndTimeDate.Name="lblSEEndTimeDate";
            lblSEEndTimeDate.Size=new Size(59, 15);
            lblSEEndTimeDate.TabIndex=244;
            lblSEEndTimeDate.Text="End Time:";
            // 
            // lblSEStartTimeDate
            // 
            lblSEStartTimeDate.AutoSize=true;
            lblSEStartTimeDate.Location=new Point(5, 34);
            lblSEStartTimeDate.Name="lblSEStartTimeDate";
            lblSEStartTimeDate.Size=new Size(63, 15);
            lblSEStartTimeDate.TabIndex=242;
            lblSEStartTimeDate.Text="Start Time:";
            // 
            // lblSEClassID
            // 
            lblSEClassID.AutoSize=true;
            lblSEClassID.Location=new Point(5, 94);
            lblSEClassID.Name="lblSEClassID";
            lblSEClassID.Size=new Size(48, 15);
            lblSEClassID.TabIndex=246;
            lblSEClassID.Text="ClassID:";
            // 
            // lblSEClass
            // 
            lblSEClass.AutoSize=true;
            lblSEClass.Location=new Point(5, 8);
            lblSEClass.Name="lblSEClass";
            lblSEClass.Size=new Size(37, 15);
            lblSEClass.TabIndex=240;
            lblSEClass.Text="Class:";
            // 
            // btnTAdd
            // 
            btnTAdd.Location=new Point(505, 307);
            btnTAdd.Name="btnTAdd";
            btnTAdd.Size=new Size(176, 23);
            btnTAdd.TabIndex=1;
            btnTAdd.Text="&Add";
            btnTAdd.UseVisualStyleBackColor=true;
            btnTAdd.Click+=btnTAdd_Click;
            // 
            // btnTEdit
            // 
            btnTEdit.Enabled=false;
            btnTEdit.Location=new Point(505, 334);
            btnTEdit.Name="btnTEdit";
            btnTEdit.Size=new Size(176, 23);
            btnTEdit.TabIndex=2;
            btnTEdit.Text="&Edit";
            btnTEdit.UseVisualStyleBackColor=true;
            btnTEdit.Click+=btnTEdit_Click;
            // 
            // btnTFinish
            // 
            btnTFinish.Enabled=false;
            btnTFinish.Location=new Point(505, 363);
            btnTFinish.Name="btnTFinish";
            btnTFinish.Size=new Size(176, 23);
            btnTFinish.TabIndex=3;
            btnTFinish.Text="&Finish";
            btnTFinish.UseVisualStyleBackColor=true;
            btnTFinish.Click+=btnTFinish_Click;
            // 
            // btnCancelCreateTodo
            // 
            btnCancelCreateTodo.Location=new Point(505, 494);
            btnCancelCreateTodo.Name="btnCancelCreateTodo";
            btnCancelCreateTodo.Size=new Size(176, 23);
            btnCancelCreateTodo.TabIndex=12;
            btnCancelCreateTodo.Text="Cancel";
            btnCancelCreateTodo.UseVisualStyleBackColor=true;
            btnCancelCreateTodo.Visible=false;
            btnCancelCreateTodo.Click+=btnCancelCreateTodo_Click;
            // 
            // btnUpdateTodo
            // 
            btnUpdateTodo.Location=new Point(505, 465);
            btnUpdateTodo.Name="btnUpdateTodo";
            btnUpdateTodo.Size=new Size(176, 23);
            btnUpdateTodo.TabIndex=11;
            btnUpdateTodo.Text="&Update";
            btnUpdateTodo.UseVisualStyleBackColor=true;
            btnUpdateTodo.Visible=false;
            btnUpdateTodo.Click+=btnUpdateTodo_Click;
            // 
            // btnEDelete
            // 
            btnEDelete.Enabled=false;
            btnEDelete.Location=new Point(12, 494);
            btnEDelete.Name="btnEDelete";
            btnEDelete.Size=new Size(227, 23);
            btnEDelete.TabIndex=103;
            btnEDelete.Text="Delete";
            btnEDelete.UseVisualStyleBackColor=true;
            btnEDelete.Click+=btnEDelete_Click;
            // 
            // btnEEdit
            // 
            btnEEdit.Enabled=false;
            btnEEdit.Location=new Point(12, 465);
            btnEEdit.Name="btnEEdit";
            btnEEdit.Size=new Size(227, 23);
            btnEEdit.TabIndex=102;
            btnEEdit.Text="Edit";
            btnEEdit.UseVisualStyleBackColor=true;
            btnEEdit.Click+=btnEEdit_Click;
            // 
            // btnEAdd
            // 
            btnEAdd.Location=new Point(12, 436);
            btnEAdd.Name="btnEAdd";
            btnEAdd.Size=new Size(227, 23);
            btnEAdd.TabIndex=101;
            btnEAdd.Text="Add";
            btnEAdd.UseVisualStyleBackColor=true;
            btnEAdd.Click+=btnEAdd_Click;
            // 
            // timer1
            // 
            timer1.Enabled=true;
            timer1.Interval=500;
            timer1.Tick+=timer1_Tick;
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize=true;
            lblMainLabel.Font=new Font("Share Tech Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainLabel.Location=new Point(12, 12);
            lblMainLabel.Name="lblMainLabel";
            lblMainLabel.Size=new Size(257, 39);
            lblMainLabel.TabIndex=104;
            lblMainLabel.Text="lblMainLabel";
            // 
            // lblTime
            // 
            lblTime.AutoSize=true;
            lblTime.Location=new Point(245, 57);
            lblTime.Name="lblTime";
            lblTime.Size=new Size(34, 15);
            lblTime.TabIndex=105;
            lblTime.Text="12:00";
            // 
            // pbTodoProgress
            // 
            pbTodoProgress.ForeColor=SystemColors.WindowText;
            pbTodoProgress.Location=new Point(506, 494);
            pbTodoProgress.Name="pbTodoProgress";
            pbTodoProgress.Size=new Size(175, 23);
            pbTodoProgress.Step=1;
            pbTodoProgress.TabIndex=300;
            // 
            // lblTodoPB
            // 
            lblTodoPB.AutoSize=true;
            lblTodoPB.Location=new Point(544, 469);
            lblTodoPB.Name="lblTodoPB";
            lblTodoPB.Size=new Size(105, 15);
            lblTodoPB.TabIndex=301;
            lblTodoPB.Text="Todo List Progress:";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(693, 529);
            Controls.Add(lblTodoPB);
            Controls.Add(pbTodoProgress);
            Controls.Add(lblTime);
            Controls.Add(lblMainLabel);
            Controls.Add(btnEDelete);
            Controls.Add(btnEEdit);
            Controls.Add(btnEAdd);
            Controls.Add(btnUpdateTodo);
            Controls.Add(btnCancelCreateTodo);
            Controls.Add(btnTFinish);
            Controls.Add(btnTEdit);
            Controls.Add(btnTAdd);
            Controls.Add(tcCreateEvents);
            Controls.Add(btnCreateTodo);
            Controls.Add(inItemDescription);
            Controls.Add(inImportanceLevel);
            Controls.Add(inItemName);
            Controls.Add(lblImportanceLevel);
            Controls.Add(lblItemDescription);
            Controls.Add(lblItemName);
            Controls.Add(lbSelectedDayEvents);
            Controls.Add(lbTODOlisting);
            Controls.Add(monthCalendar1);
            Name="Form1";
            Text="ToDo";
            ((System.ComponentModel.ISupportInitialize)inImportanceLevel).EndInit();
            tcCreateEvents.ResumeLayout(false);
            tpPersonal.ResumeLayout(false);
            tpPersonal.PerformLayout();
            tpWork.ResumeLayout(false);
            tpWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inWWage).EndInit();
            tpSchool.ResumeLayout(false);
            tpSchool.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ListBox lbTODOlisting;
        private ListBox lbSelectedDayEvents;
        private Label lblItemName;
        private Label lblItemDescription;
        private Label lblImportanceLevel;
        private RichTextBox inItemName;
        private NumericUpDown inImportanceLevel;
        private RichTextBox inItemDescription;
        private Button btnCreateTodo;
        private TabControl tcCreateEvents;
        private TabPage tpPersonal;
        private TabPage tpWork;
        private TabPage tpSchool;
        private Button btnTAdd;
        private Button btnTEdit;
        private Button btnTFinish;
        private Button btnCancelCreateTodo;
        private Button btnUpdateTodo;
        private Label lblPEName;
        private Label lblPEStartTime;
        private Label lblPEEndTime;
        private DateTimePicker inPEStartTimeDate;
        private RichTextBox inPEName;
        private Label lblPEDescription;
        private Button btnPECancel;
        private Button btnPECreate;
        private RichTextBox inPEDescription;
        private DateTimePicker inPEEndTimeDate;
        private Button btnEDelete;
        private Button btnEEdit;
        private Button btnEAdd;
        private Label lblWEndTimeDate;
        private Label lblWStartTimeDate;
        private Label lblWWage;
        private Label lblWName;
        private Label lblWCompany;
        private NumericUpDown inWWage;
        private RichTextBox inWCompany;
        private RichTextBox inWJobName;
        private DateTimePicker inWStartTimeDate;
        private Button btnWECancel;
        private Button btnWECreate;
        private DateTimePicker inWEndTimeDate;
        private Label lblSEClassID;
        private Label lblSEClass;
        private Label lblSEEndTimeDate;
        private Label lblSEStartTimeDate;
        private Label lblSEMeetingDays;
        private DateTimePicker inSEStartTimeDate;
        private DateTimePicker inSEEndTimeDate;
        private RichTextBox inSEClassID;
        private RichTextBox inSEClassName;
        private Button btnSECancel;
        private Button btnSECreate;
        private CheckBox inSEOnline;
        private CheckBox inSEFriday;
        private CheckBox inSEThursday;
        private CheckBox inSEWednesday;
        private CheckBox inSETuesday;
        private CheckBox inSEMonday;
        private Button btnPEUpdate;
        private Button btnWEUpdate;
        private Button btnSEUpdate;
        private System.Windows.Forms.Timer timer1;
        private Label lblMainLabel;
        private Label lblTime;
        private ProgressBar pbTodoProgress;
        private Label lblTodoPB;
    }
}