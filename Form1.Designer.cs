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
            monthCalendar1.Location=new Point(18, 18);
            monthCalendar1.Name="monthCalendar1";
            monthCalendar1.TabIndex=0;
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
            lbSelectedDayEvents.Location=new Point(272, 16);
            lbSelectedDayEvents.Name="lbSelectedDayEvents";
            lbSelectedDayEvents.Size=new Size(227, 244);
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
            inImportanceLevel.ValueChanged+=numericUpDown1_ValueChanged;
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
            tcCreateEvents.Location=new Point(18, 281);
            tcCreateEvents.Name="tcCreateEvents";
            tcCreateEvents.SelectedIndex=0;
            tcCreateEvents.Size=new Size(351, 233);
            tcCreateEvents.TabIndex=10;
            tcCreateEvents.Visible=false;
            // 
            // tpPersonal
            // 
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
            tpPersonal.Size=new Size(343, 205);
            tpPersonal.TabIndex=0;
            tpPersonal.Text="Personal";
            tpPersonal.UseVisualStyleBackColor=true;
            // 
            // btnPECancel
            // 
            btnPECancel.Location=new Point(172, 176);
            btnPECancel.Name="btnPECancel";
            btnPECancel.Size=new Size(165, 25);
            btnPECancel.TabIndex=109;
            btnPECancel.Text="Cancel";
            btnPECancel.UseVisualStyleBackColor=true;
            btnPECancel.Click+=btnPECancel_Click;
            // 
            // btnPECreate
            // 
            btnPECreate.Location=new Point(6, 176);
            btnPECreate.Name="btnPECreate";
            btnPECreate.Size=new Size(165, 25);
            btnPECreate.TabIndex=108;
            btnPECreate.Text="Create";
            btnPECreate.UseVisualStyleBackColor=true;
            btnPECreate.Click+=btnPECreate_Click;
            // 
            // inPEDescription
            // 
            inPEDescription.Location=new Point(80, 88);
            inPEDescription.MaxLength=1000;
            inPEDescription.Multiline=false;
            inPEDescription.Name="inPEDescription";
            inPEDescription.Size=new Size(255, 85);
            inPEDescription.TabIndex=107;
            inPEDescription.Text="";
            // 
            // inPEEndTimeDate
            // 
            inPEEndTimeDate.Format=DateTimePickerFormat.Custom;
            inPEEndTimeDate.Location=new Point(95, 60);
            inPEEndTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inPEEndTimeDate.Name="inPEEndTimeDate";
            inPEEndTimeDate.Size=new Size(240, 23);
            inPEEndTimeDate.TabIndex=106;
            // 
            // inPEStartTimeDate
            // 
            inPEStartTimeDate.Format=DateTimePickerFormat.Custom;
            inPEStartTimeDate.Location=new Point(95, 30);
            inPEStartTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inPEStartTimeDate.Name="inPEStartTimeDate";
            inPEStartTimeDate.Size=new Size(240, 23);
            inPEStartTimeDate.TabIndex=101;
            // 
            // inPEName
            // 
            inPEName.Location=new Point(82, 6);
            inPEName.MaxLength=40;
            inPEName.Multiline=false;
            inPEName.Name="inPEName";
            inPEName.Size=new Size(253, 20);
            inPEName.TabIndex=105;
            inPEName.Text="";
            // 
            // lblPEDescription
            // 
            lblPEDescription.AutoSize=true;
            lblPEDescription.Location=new Point(5, 91);
            lblPEDescription.Name="lblPEDescription";
            lblPEDescription.Size=new Size(70, 15);
            lblPEDescription.TabIndex=104;
            lblPEDescription.Text="Description:";
            // 
            // lblPEEndTime
            // 
            lblPEEndTime.AutoSize=true;
            lblPEEndTime.Location=new Point(5, 64);
            lblPEEndTime.Name="lblPEEndTime";
            lblPEEndTime.Size=new Size(88, 15);
            lblPEEndTime.TabIndex=103;
            lblPEEndTime.Text="End Time/Date:";
            // 
            // lblPEStartTime
            // 
            lblPEStartTime.AutoSize=true;
            lblPEStartTime.Location=new Point(5, 34);
            lblPEStartTime.Name="lblPEStartTime";
            lblPEStartTime.Size=new Size(92, 15);
            lblPEStartTime.TabIndex=102;
            lblPEStartTime.Text="Start Time/Date:";
            // 
            // lblPEName
            // 
            lblPEName.AutoSize=true;
            lblPEName.Location=new Point(5, 8);
            lblPEName.Name="lblPEName";
            lblPEName.Size=new Size(74, 15);
            lblPEName.TabIndex=101;
            lblPEName.Text="Event Name:";
            // 
            // tpWork
            // 
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
            tpWork.Size=new Size(343, 205);
            tpWork.TabIndex=1;
            tpWork.Text="Work";
            tpWork.UseVisualStyleBackColor=true;
            // 
            // btnWECancel
            // 
            btnWECancel.Location=new Point(172, 176);
            btnWECancel.Name="btnWECancel";
            btnWECancel.Size=new Size(165, 25);
            btnWECancel.TabIndex=110;
            btnWECancel.Text="Cancel";
            btnWECancel.UseVisualStyleBackColor=true;
            btnWECancel.Click+=btnWECancel_Click;
            // 
            // btnWECreate
            // 
            btnWECreate.Location=new Point(6, 176);
            btnWECreate.Name="btnWECreate";
            btnWECreate.Size=new Size(165, 25);
            btnWECreate.TabIndex=109;
            btnWECreate.Text="Create";
            btnWECreate.UseVisualStyleBackColor=true;
            btnWECreate.Click+=btnWECreate_Click;
            // 
            // inWEndTimeDate
            // 
            inWEndTimeDate.Format=DateTimePickerFormat.Custom;
            inWEndTimeDate.Location=new Point(95, 60);
            inWEndTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inWEndTimeDate.Name="inWEndTimeDate";
            inWEndTimeDate.Size=new Size(240, 23);
            inWEndTimeDate.TabIndex=108;
            // 
            // inWStartTimeDate
            // 
            inWStartTimeDate.Format=DateTimePickerFormat.Custom;
            inWStartTimeDate.Location=new Point(95, 30);
            inWStartTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inWStartTimeDate.Name="inWStartTimeDate";
            inWStartTimeDate.Size=new Size(240, 23);
            inWStartTimeDate.TabIndex=107;
            // 
            // inWWage
            // 
            inWWage.DecimalPlaces=2;
            inWWage.Increment=new decimal(new int[] { 1, 0, 0, 131072 });
            inWWage.Location=new Point(56, 115);
            inWWage.Name="inWWage";
            inWWage.Size=new Size(88, 23);
            inWWage.TabIndex=106;
            // 
            // inWCompany
            // 
            inWCompany.Location=new Point(73, 88);
            inWCompany.MaxLength=50;
            inWCompany.Multiline=false;
            inWCompany.Name="inWCompany";
            inWCompany.Size=new Size(262, 21);
            inWCompany.TabIndex=105;
            inWCompany.Text="";
            // 
            // inWJobName
            // 
            inWJobName.Location=new Point(73, 6);
            inWJobName.MaxLength=50;
            inWJobName.Multiline=false;
            inWJobName.Name="inWJobName";
            inWJobName.Size=new Size(262, 20);
            inWJobName.TabIndex=104;
            inWJobName.Text="";
            // 
            // lblWCompany
            // 
            lblWCompany.AutoSize=true;
            lblWCompany.Location=new Point(5, 91);
            lblWCompany.Name="lblWCompany";
            lblWCompany.Size=new Size(62, 15);
            lblWCompany.TabIndex=4;
            lblWCompany.Text="Company:";
            // 
            // lblWEndTimeDate
            // 
            lblWEndTimeDate.AutoSize=true;
            lblWEndTimeDate.Location=new Point(5, 64);
            lblWEndTimeDate.Name="lblWEndTimeDate";
            lblWEndTimeDate.Size=new Size(88, 15);
            lblWEndTimeDate.TabIndex=3;
            lblWEndTimeDate.Text="End Time/Date:";
            // 
            // lblWStartTimeDate
            // 
            lblWStartTimeDate.AutoSize=true;
            lblWStartTimeDate.Location=new Point(5, 34);
            lblWStartTimeDate.Name="lblWStartTimeDate";
            lblWStartTimeDate.Size=new Size(92, 15);
            lblWStartTimeDate.TabIndex=2;
            lblWStartTimeDate.Text="Start Time/Date:";
            // 
            // lblWWage
            // 
            lblWWage.AutoSize=true;
            lblWWage.Location=new Point(5, 119);
            lblWWage.Name="lblWWage";
            lblWWage.Size=new Size(49, 15);
            lblWWage.TabIndex=1;
            lblWWage.Text="Wage: $";
            // 
            // lblWName
            // 
            lblWName.AutoSize=true;
            lblWName.Location=new Point(5, 8);
            lblWName.Name="lblWName";
            lblWName.Size=new Size(63, 15);
            lblWName.TabIndex=0;
            lblWName.Text="Job Name:";
            // 
            // tpSchool
            // 
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
            tpSchool.Size=new Size(343, 205);
            tpSchool.TabIndex=2;
            tpSchool.Text="School";
            tpSchool.UseVisualStyleBackColor=true;
            // 
            // inSEFriday
            // 
            inSEFriday.AutoSize=true;
            inSEFriday.Location=new Point(87, 127);
            inSEFriday.Name="inSEFriday";
            inSEFriday.Size=new Size(58, 19);
            inSEFriday.TabIndex=118;
            inSEFriday.Text="Friday";
            inSEFriday.UseVisualStyleBackColor=true;
            // 
            // inSEThursday
            // 
            inSEThursday.AutoSize=true;
            inSEThursday.Location=new Point(172, 109);
            inSEThursday.Name="inSEThursday";
            inSEThursday.Size=new Size(74, 19);
            inSEThursday.TabIndex=117;
            inSEThursday.Text="Thursday";
            inSEThursday.UseVisualStyleBackColor=true;
            // 
            // inSEWednesday
            // 
            inSEWednesday.AutoSize=true;
            inSEWednesday.Location=new Point(87, 109);
            inSEWednesday.Name="inSEWednesday";
            inSEWednesday.Size=new Size(87, 19);
            inSEWednesday.TabIndex=116;
            inSEWednesday.Text="Wednesday";
            inSEWednesday.UseVisualStyleBackColor=true;
            // 
            // inSETuesday
            // 
            inSETuesday.AutoSize=true;
            inSETuesday.Location=new Point(172, 91);
            inSETuesday.Name="inSETuesday";
            inSETuesday.Size=new Size(69, 19);
            inSETuesday.TabIndex=115;
            inSETuesday.Text="Tuesday";
            inSETuesday.UseVisualStyleBackColor=true;
            // 
            // inSEMonday
            // 
            inSEMonday.AutoSize=true;
            inSEMonday.Location=new Point(87, 91);
            inSEMonday.Name="inSEMonday";
            inSEMonday.Size=new Size(70, 19);
            inSEMonday.TabIndex=114;
            inSEMonday.Text="Monday";
            inSEMonday.UseVisualStyleBackColor=true;
            // 
            // inSEOnline
            // 
            inSEOnline.AutoSize=true;
            inSEOnline.Location=new Point(8, 154);
            inSEOnline.Name="inSEOnline";
            inSEOnline.Size=new Size(91, 19);
            inSEOnline.TabIndex=113;
            inSEOnline.Text="Online Class";
            inSEOnline.UseVisualStyleBackColor=true;
            inSEOnline.CheckedChanged+=inSEOnline_CheckedChanged;
            // 
            // btnSECancel
            // 
            btnSECancel.Location=new Point(172, 176);
            btnSECancel.Name="btnSECancel";
            btnSECancel.Size=new Size(165, 25);
            btnSECancel.TabIndex=112;
            btnSECancel.Text="Cancel";
            btnSECancel.UseVisualStyleBackColor=true;
            btnSECancel.Click+=btnSECancel_Click;
            // 
            // btnSECreate
            // 
            btnSECreate.Location=new Point(6, 176);
            btnSECreate.Name="btnSECreate";
            btnSECreate.Size=new Size(165, 25);
            btnSECreate.TabIndex=111;
            btnSECreate.Text="Create";
            btnSECreate.UseVisualStyleBackColor=true;
            btnSECreate.Click+=btnSECreate_Click;
            // 
            // inSEStartTimeDate
            // 
            inSEStartTimeDate.Format=DateTimePickerFormat.Custom;
            inSEStartTimeDate.Location=new Point(95, 30);
            inSEStartTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inSEStartTimeDate.Name="inSEStartTimeDate";
            inSEStartTimeDate.Size=new Size(240, 23);
            inSEStartTimeDate.TabIndex=109;
            // 
            // inSEEndTimeDate
            // 
            inSEEndTimeDate.Format=DateTimePickerFormat.Custom;
            inSEEndTimeDate.Location=new Point(95, 60);
            inSEEndTimeDate.MaxDate=new DateTime(2200, 12, 31, 0, 0, 0, 0);
            inSEEndTimeDate.Name="inSEEndTimeDate";
            inSEEndTimeDate.Size=new Size(240, 23);
            inSEEndTimeDate.TabIndex=108;
            // 
            // inSEClassID
            // 
            inSEClassID.Location=new Point(258, 6);
            inSEClassID.MaxLength=50;
            inSEClassID.Multiline=false;
            inSEClassID.Name="inSEClassID";
            inSEClassID.Size=new Size(77, 20);
            inSEClassID.TabIndex=106;
            inSEClassID.Text="";
            // 
            // inSEClassName
            // 
            inSEClassName.Location=new Point(44, 6);
            inSEClassName.MaxLength=50;
            inSEClassName.Multiline=false;
            inSEClassName.Name="inSEClassName";
            inSEClassName.Size=new Size(164, 20);
            inSEClassName.TabIndex=105;
            inSEClassName.Text="";
            // 
            // lblSEMeetingDays
            // 
            lblSEMeetingDays.AutoSize=true;
            lblSEMeetingDays.Location=new Point(5, 91);
            lblSEMeetingDays.Name="lblSEMeetingDays";
            lblSEMeetingDays.Size=new Size(82, 15);
            lblSEMeetingDays.TabIndex=6;
            lblSEMeetingDays.Text="Meeting Days:";
            // 
            // lblSEEndTimeDate
            // 
            lblSEEndTimeDate.AutoSize=true;
            lblSEEndTimeDate.Location=new Point(5, 64);
            lblSEEndTimeDate.Name="lblSEEndTimeDate";
            lblSEEndTimeDate.Size=new Size(88, 15);
            lblSEEndTimeDate.TabIndex=4;
            lblSEEndTimeDate.Text="End Time/Date:";
            // 
            // lblSEStartTimeDate
            // 
            lblSEStartTimeDate.AutoSize=true;
            lblSEStartTimeDate.Location=new Point(5, 34);
            lblSEStartTimeDate.Name="lblSEStartTimeDate";
            lblSEStartTimeDate.Size=new Size(92, 15);
            lblSEStartTimeDate.TabIndex=3;
            lblSEStartTimeDate.Text="Start Time/Date:";
            // 
            // lblSEClassID
            // 
            lblSEClassID.AutoSize=true;
            lblSEClassID.Location=new Point(208, 8);
            lblSEClassID.Name="lblSEClassID";
            lblSEClassID.Size=new Size(48, 15);
            lblSEClassID.TabIndex=2;
            lblSEClassID.Text="ClassID:";
            lblSEClassID.Click+=label1_Click;
            // 
            // lblSEClass
            // 
            lblSEClass.AutoSize=true;
            lblSEClass.Location=new Point(5, 8);
            lblSEClass.Name="lblSEClass";
            lblSEClass.Size=new Size(37, 15);
            lblSEClass.TabIndex=1;
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
            btnEDelete.Location=new Point(258, 281);
            btnEDelete.Name="btnEDelete";
            btnEDelete.Size=new Size(176, 23);
            btnEDelete.TabIndex=103;
            btnEDelete.Text="Delete";
            btnEDelete.UseVisualStyleBackColor=true;
            btnEDelete.Click+=btnEDelete_Click;
            // 
            // btnEEdit
            // 
            btnEEdit.Enabled=false;
            btnEEdit.Location=new Point(258, 252);
            btnEEdit.Name="btnEEdit";
            btnEEdit.Size=new Size(176, 23);
            btnEEdit.TabIndex=102;
            btnEEdit.Text="Edit";
            btnEEdit.UseVisualStyleBackColor=true;
            btnEEdit.Click+=btnEEdit_Click;
            // 
            // btnEAdd
            // 
            btnEAdd.Location=new Point(258, 225);
            btnEAdd.Name="btnEAdd";
            btnEAdd.Size=new Size(176, 23);
            btnEAdd.TabIndex=101;
            btnEAdd.Text="Add";
            btnEAdd.UseVisualStyleBackColor=true;
            btnEAdd.Click+=btnEAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(693, 529);
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
    }
}