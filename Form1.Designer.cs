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
            tabControl1=new TabControl();
            tabPage1=new TabPage();
            tabPage2=new TabPage();
            tabPage3=new TabPage();
            btnTAdd=new Button();
            btnTEdit=new Button();
            btnTFinish=new Button();
            btnCancelCreateTodo=new Button();
            btnUpdateTodo=new Button();
            ((System.ComponentModel.ISupportInitialize)inImportanceLevel).BeginInit();
            tabControl1.SuspendLayout();
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
            lbSelectedDayEvents.Location=new Point(18, 269);
            lbSelectedDayEvents.Name="lbSelectedDayEvents";
            lbSelectedDayEvents.Size=new Size(227, 244);
            lbSelectedDayEvents.TabIndex=100;
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
            btnCreateTodo.Text="Create";
            btnCreateTodo.UseVisualStyleBackColor=true;
            btnCreateTodo.Visible=false;
            btnCreateTodo.Click+=button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location=new Point(251, 301);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(232, 216);
            tabControl1.TabIndex=10;
            // 
            // tabPage1
            // 
            tabPage1.Location=new Point(4, 24);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new Padding(3);
            tabPage1.Size=new Size(224, 188);
            tabPage1.TabIndex=0;
            tabPage1.Text="tabPage1";
            tabPage1.UseVisualStyleBackColor=true;
            // 
            // tabPage2
            // 
            tabPage2.Location=new Point(4, 24);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(3);
            tabPage2.Size=new Size(224, 188);
            tabPage2.TabIndex=1;
            tabPage2.Text="tabPage2";
            tabPage2.UseVisualStyleBackColor=true;
            // 
            // tabPage3
            // 
            tabPage3.Location=new Point(4, 24);
            tabPage3.Name="tabPage3";
            tabPage3.Padding=new Padding(3);
            tabPage3.Size=new Size(224, 188);
            tabPage3.TabIndex=2;
            tabPage3.Text="tabPage3";
            tabPage3.UseVisualStyleBackColor=true;
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
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(693, 529);
            Controls.Add(btnUpdateTodo);
            Controls.Add(btnCancelCreateTodo);
            Controls.Add(btnTFinish);
            Controls.Add(btnTEdit);
            Controls.Add(btnTAdd);
            Controls.Add(tabControl1);
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
            tabControl1.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnTAdd;
        private Button btnTEdit;
        private Button btnTFinish;
        private Button btnCancelCreateTodo;
        private Button btnUpdateTodo;
    }
}