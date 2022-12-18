namespace Dagplanner
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
            this.buttonManageNames = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxToDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonClearTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageNames
            // 
            this.buttonManageNames.Location = new System.Drawing.Point(386, 380);
            this.buttonManageNames.Name = "buttonManageNames";
            this.buttonManageNames.Size = new System.Drawing.Size(79, 58);
            this.buttonManageNames.TabIndex = 1;
            this.buttonManageNames.Text = "Beheer personeel";
            this.buttonManageNames.UseVisualStyleBackColor = true;
            this.buttonManageNames.Click += new System.EventHandler(this.buttonManageNames_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(265, 380);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(115, 58);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Exporteren naar Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // listBoxAll
            // 
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.HorizontalScrollbar = true;
            this.listBoxAll.ItemHeight = 15;
            this.listBoxAll.Location = new System.Drawing.Point(12, 12);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.Size = new System.Drawing.Size(175, 379);
            this.listBoxAll.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(220, 47);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(220, 91);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Starttijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eindtijd";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(10, 407);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(177, 38);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Verversen";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxToDo
            // 
            this.textBoxToDo.Location = new System.Drawing.Point(220, 135);
            this.textBoxToDo.Name = "textBoxToDo";
            this.textBoxToDo.Size = new System.Drawing.Size(200, 23);
            this.textBoxToDo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "TODO:";
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 15;
            this.listBoxTasks.Location = new System.Drawing.Point(221, 193);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(200, 139);
            this.listBoxTasks.TabIndex = 11;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(220, 164);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(200, 23);
            this.buttonAddTask.TabIndex = 12;
            this.buttonAddTask.Text = "Toevoegen";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonClearTasks
            // 
            this.buttonClearTasks.Location = new System.Drawing.Point(221, 338);
            this.buttonClearTasks.Name = "buttonClearTasks";
            this.buttonClearTasks.Size = new System.Drawing.Size(200, 23);
            this.buttonClearTasks.TabIndex = 13;
            this.buttonClearTasks.Text = "Leegmaken";
            this.buttonClearTasks.UseVisualStyleBackColor = true;
            this.buttonClearTasks.Click += new System.EventHandler(this.buttonClearTasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.buttonClearTasks);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxToDo);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.listBoxAll);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonManageNames);
            this.Name = "Form1";
            this.Text = "Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonManageNames;
        private Button buttonExport;
        private ListBox listBoxAll;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label1;
        private Label label2;
        private Button buttonRefresh;
        private TextBox textBoxToDo;
        private Label label3;
        private ListBox listBoxTasks;
        private Button buttonAddTask;
        private Button buttonClearTasks;
    }
}