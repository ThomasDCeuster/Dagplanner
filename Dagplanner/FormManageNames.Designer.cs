namespace Dagplanner
{
    partial class FormManageNames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxFull = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPart = new System.Windows.Forms.ListBox();
            this.buttonRemoveFull = new System.Windows.Forms.Button();
            this.buttonRemovePart = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxStag = new System.Windows.Forms.ListBox();
            this.labelDaysLeft = new System.Windows.Forms.Label();
            this.textBoxDaysLeft = new System.Windows.Forms.TextBox();
            this.buttonRemoveStag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFull
            // 
            this.listBoxFull.FormattingEnabled = true;
            this.listBoxFull.HorizontalScrollbar = true;
            this.listBoxFull.ItemHeight = 15;
            this.listBoxFull.Location = new System.Drawing.Point(12, 27);
            this.listBoxFull.Name = "listBoxFull";
            this.listBoxFull.Size = new System.Drawing.Size(162, 139);
            this.listBoxFull.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fulltime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parttime:";
            // 
            // listBoxPart
            // 
            this.listBoxPart.FormattingEnabled = true;
            this.listBoxPart.HorizontalScrollbar = true;
            this.listBoxPart.ItemHeight = 15;
            this.listBoxPart.Location = new System.Drawing.Point(12, 223);
            this.listBoxPart.Name = "listBoxPart";
            this.listBoxPart.Size = new System.Drawing.Size(162, 139);
            this.listBoxPart.TabIndex = 3;
            // 
            // buttonRemoveFull
            // 
            this.buttonRemoveFull.Location = new System.Drawing.Point(31, 172);
            this.buttonRemoveFull.Name = "buttonRemoveFull";
            this.buttonRemoveFull.Size = new System.Drawing.Size(84, 23);
            this.buttonRemoveFull.TabIndex = 4;
            this.buttonRemoveFull.Text = "verwijderen";
            this.buttonRemoveFull.UseVisualStyleBackColor = true;
            this.buttonRemoveFull.Click += new System.EventHandler(this.buttonRemoveFull_Click);
            // 
            // buttonRemovePart
            // 
            this.buttonRemovePart.Location = new System.Drawing.Point(31, 368);
            this.buttonRemovePart.Name = "buttonRemovePart";
            this.buttonRemovePart.Size = new System.Drawing.Size(84, 23);
            this.buttonRemovePart.TabIndex = 5;
            this.buttonRemovePart.Text = "Verwijderen";
            this.buttonRemovePart.UseVisualStyleBackColor = true;
            this.buttonRemovePart.Click += new System.EventHandler(this.buttonRemovePart_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(415, 193);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(122, 27);
            this.buttonAddEmployee.TabIndex = 6;
            this.buttonAddEmployee.Text = "Toevoegen";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voornaam";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(416, 27);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(121, 23);
            this.textBoxFirst.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(453, 361);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(93, 36);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Verversen";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Fulltime",
            "Parttime",
            "Stagaire"});
            this.comboBoxType.Location = new System.Drawing.Point(416, 115);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Achternaam";
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(416, 71);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(121, 23);
            this.textBoxLast.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stagaire:";
            // 
            // listBoxStag
            // 
            this.listBoxStag.FormattingEnabled = true;
            this.listBoxStag.HorizontalScrollbar = true;
            this.listBoxStag.ItemHeight = 15;
            this.listBoxStag.Location = new System.Drawing.Point(232, 27);
            this.listBoxStag.Name = "listBoxStag";
            this.listBoxStag.Size = new System.Drawing.Size(163, 139);
            this.listBoxStag.TabIndex = 18;
            // 
            // labelDaysLeft
            // 
            this.labelDaysLeft.AutoSize = true;
            this.labelDaysLeft.Location = new System.Drawing.Point(416, 141);
            this.labelDaysLeft.Name = "labelDaysLeft";
            this.labelDaysLeft.Size = new System.Drawing.Size(80, 15);
            this.labelDaysLeft.TabIndex = 19;
            this.labelDaysLeft.Text = "Aantal dagen:";
            // 
            // textBoxDaysLeft
            // 
            this.textBoxDaysLeft.Location = new System.Drawing.Point(416, 159);
            this.textBoxDaysLeft.Name = "textBoxDaysLeft";
            this.textBoxDaysLeft.Size = new System.Drawing.Size(121, 23);
            this.textBoxDaysLeft.TabIndex = 20;
            // 
            // buttonRemoveStag
            // 
            this.buttonRemoveStag.Location = new System.Drawing.Point(249, 172);
            this.buttonRemoveStag.Name = "buttonRemoveStag";
            this.buttonRemoveStag.Size = new System.Drawing.Size(127, 23);
            this.buttonRemoveStag.TabIndex = 21;
            this.buttonRemoveStag.Text = "verwijderen";
            this.buttonRemoveStag.UseVisualStyleBackColor = true;
            this.buttonRemoveStag.Click += new System.EventHandler(this.buttonRemoveStag_Click);
            // 
            // FormManageNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 417);
            this.Controls.Add(this.buttonRemoveStag);
            this.Controls.Add(this.textBoxDaysLeft);
            this.Controls.Add(this.labelDaysLeft);
            this.Controls.Add(this.listBoxStag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonRemovePart);
            this.Controls.Add(this.buttonRemoveFull);
            this.Controls.Add(this.listBoxPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFull);
            this.Name = "FormManageNames";
            this.Text = "Naambeheer";
            this.Load += new System.EventHandler(this.FormManageNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxFull;
        private Label label1;
        private Label label2;
        private ListBox listBoxPart;
        private Button buttonRemoveFull;
        private Button buttonRemovePart;
        private Button buttonAddEmployee;
        private Label label3;
        private TextBox textBoxFirst;
        private Button buttonRefresh;
        private ComboBox comboBoxType;
        private Label label4;
        private Label label5;
        private TextBox textBoxLast;
        private Label label6;
        private ListBox listBoxStag;
        private Label labelDaysLeft;
        private TextBox textBoxDaysLeft;
        private Button buttonRemoveStag;
    }
}