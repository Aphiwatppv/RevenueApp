
namespace DailyRecordRevenueApp
{
    partial class Main
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
            panelTop = new Panel();
            label8 = new Label();
            btnMinimize = new Button();
            btnExit = new Button();
            panelBottom = new Panel();
            MonthlyCurrenttxt = new Label();
            DialyCurrentDaytxt = new Label();
            labeldatetime = new Label();
            panelMain = new Panel();
            panel2 = new Panel();
            buttonAddDetail = new Button();
            txtdetail = new TextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtTypes = new TextBox();
            panel1 = new Panel();
            buttonUpdate = new Button();
            buttonRemove = new Button();
            buttonAdd = new Button();
            comboBoxIncomeExpense = new ComboBox();
            label7 = new Label();
            textBoxValue = new TextBox();
            label6 = new Label();
            comboBoxDetail = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDetailRecordId = new TextBox();
            textBoxTypeRecord = new TextBox();
            textBoxAccount = new TextBox();
            dataGridViewRecord = new DataGridView();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelMain.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(47, 47, 47);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(btnMinimize);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1452, 37);
            panelTop.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(615, 6);
            label8.Name = "label8";
            label8.Size = new Size(191, 21);
            label8.TabIndex = 2;
            label8.Text = "Expense Income Record";
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1302, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(75, 37);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1377, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 37);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(47, 47, 47);
            panelBottom.Controls.Add(MonthlyCurrenttxt);
            panelBottom.Controls.Add(DialyCurrentDaytxt);
            panelBottom.Controls.Add(labeldatetime);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 668);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1452, 37);
            panelBottom.TabIndex = 1;
            // 
            // MonthlyCurrenttxt
            // 
            MonthlyCurrenttxt.AutoSize = true;
            MonthlyCurrenttxt.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            MonthlyCurrenttxt.ForeColor = SystemColors.ButtonHighlight;
            MonthlyCurrenttxt.Location = new Point(615, 7);
            MonthlyCurrenttxt.Name = "MonthlyCurrenttxt";
            MonthlyCurrenttxt.Size = new Size(90, 21);
            MonthlyCurrenttxt.TabIndex = 2;
            MonthlyCurrenttxt.Text = "CurrentDay";
            // 
            // DialyCurrentDaytxt
            // 
            DialyCurrentDaytxt.AutoSize = true;
            DialyCurrentDaytxt.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            DialyCurrentDaytxt.ForeColor = SystemColors.ButtonHighlight;
            DialyCurrentDaytxt.Location = new Point(12, 7);
            DialyCurrentDaytxt.Name = "DialyCurrentDaytxt";
            DialyCurrentDaytxt.Size = new Size(90, 21);
            DialyCurrentDaytxt.TabIndex = 1;
            DialyCurrentDaytxt.Text = "CurrentDay";
            // 
            // labeldatetime
            // 
            labeldatetime.AutoSize = true;
            labeldatetime.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            labeldatetime.ForeColor = SystemColors.ButtonHighlight;
            labeldatetime.Location = new Point(1267, 7);
            labeldatetime.Name = "labeldatetime";
            labeldatetime.Size = new Size(48, 21);
            labeldatetime.TabIndex = 0;
            labeldatetime.Text = "Clock";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(dataGridViewRecord);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 37);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1452, 631);
            panelMain.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAddDetail);
            panel2.Controls.Add(txtdetail);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtTypes);
            panel2.Location = new Point(1222, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 185);
            panel2.TabIndex = 2;
            // 
            // buttonAddDetail
            // 
            buttonAddDetail.BackColor = Color.FromArgb(192, 255, 192);
            buttonAddDetail.FlatAppearance.BorderSize = 0;
            buttonAddDetail.FlatStyle = FlatStyle.Flat;
            buttonAddDetail.ForeColor = Color.FromArgb(47, 47, 47);
            buttonAddDetail.Location = new Point(22, 125);
            buttonAddDetail.Name = "buttonAddDetail";
            buttonAddDetail.Size = new Size(166, 37);
            buttonAddDetail.TabIndex = 15;
            buttonAddDetail.Text = "Add";
            buttonAddDetail.UseVisualStyleBackColor = false;
            buttonAddDetail.Click += buttonAddDetail_Click;
            // 
            // txtdetail
            // 
            txtdetail.Location = new Point(71, 46);
            txtdetail.Name = "txtdetail";
            txtdetail.Size = new Size(121, 23);
            txtdetail.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 10);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 8;
            label10.Text = "Add Category";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 91);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 6;
            label12.Text = "Type :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 54);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 5;
            label13.Text = "Detail :";
            // 
            // txtTypes
            // 
            txtTypes.Location = new Point(71, 81);
            txtTypes.Name = "txtTypes";
            txtTypes.Size = new Size(121, 23);
            txtTypes.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(comboBoxIncomeExpense);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxValue);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxDetail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDetailRecordId);
            panel1.Controls.Add(textBoxTypeRecord);
            panel1.Controls.Add(textBoxAccount);
            panel1.Location = new Point(915, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 425);
            panel1.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(255, 255, 128);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = Color.FromArgb(47, 47, 47);
            buttonUpdate.Location = new Point(160, 306);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(119, 37);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(255, 128, 128);
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.ForeColor = Color.FromArgb(47, 47, 47);
            buttonRemove.Location = new Point(22, 306);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(119, 37);
            buttonRemove.TabIndex = 15;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.FromArgb(47, 47, 47);
            buttonAdd.Location = new Point(22, 254);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(257, 37);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxIncomeExpense
            // 
            comboBoxIncomeExpense.FormattingEnabled = true;
            comboBoxIncomeExpense.Location = new Point(129, 75);
            comboBoxIncomeExpense.Name = "comboBoxIncomeExpense";
            comboBoxIncomeExpense.Size = new Size(121, 23);
            comboBoxIncomeExpense.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 83);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 12;
            label7.Text = "Income/Expense :";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(108, 191);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(142, 23);
            textBoxValue.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 199);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Value :";
            // 
            // comboBoxDetail
            // 
            comboBoxDetail.FormattingEnabled = true;
            comboBoxDetail.Location = new Point(129, 104);
            comboBoxDetail.Name = "comboBoxDetail";
            comboBoxDetail.Size = new Size(121, 23);
            comboBoxDetail.TabIndex = 9;
            comboBoxDetail.SelectedIndexChanged += comboBoxDetail_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 10);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 8;
            label5.Text = "Record Income&Expense";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 141);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Detail Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 170);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Detail : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Account :";
            // 
            // textBoxDetailRecordId
            // 
            textBoxDetailRecordId.Location = new Point(129, 133);
            textBoxDetailRecordId.Name = "textBoxDetailRecordId";
            textBoxDetailRecordId.Size = new Size(121, 23);
            textBoxDetailRecordId.TabIndex = 3;
            // 
            // textBoxTypeRecord
            // 
            textBoxTypeRecord.Location = new Point(108, 162);
            textBoxTypeRecord.Name = "textBoxTypeRecord";
            textBoxTypeRecord.Size = new Size(142, 23);
            textBoxTypeRecord.TabIndex = 2;
            // 
            // textBoxAccount
            // 
            textBoxAccount.Location = new Point(129, 46);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.Size = new Size(121, 23);
            textBoxAccount.TabIndex = 0;
            // 
            // dataGridViewRecord
            // 
            dataGridViewRecord.BackgroundColor = Color.White;
            dataGridViewRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecord.Location = new Point(12, 29);
            dataGridViewRecord.Name = "dataGridViewRecord";
            dataGridViewRecord.Size = new Size(897, 596);
            dataGridViewRecord.TabIndex = 0;
            dataGridViewRecord.CellClick += dataGridViewRecord_CellClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 705);
            Controls.Add(panelMain);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revenue Income Expense Invest App";
            Load += Main_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelTop;
        private Button btnMinimize;
        private Button btnExit;
        private Panel panelBottom;
        private Panel panelMain;
        private Panel panel1;
        private DataGridView dataGridViewRecord;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDetailRecordId;
        private TextBox textBoxTypeRecord;
        private TextBox textBoxAccount;
        private ComboBox comboBoxIncomeExpense;
        private Label label7;
        private TextBox textBoxValue;
        private Label label6;
        private ComboBox comboBoxDetail;
        private Panel panel2;
        private TextBox txtdetail;
        private Label label10;
        private Label label12;
        private Label label13;
        private TextBox txtTypes;
        private Button buttonUpdate;
        private Button buttonRemove;
        private Button buttonAdd;
        private Button buttonAddDetail;
        private Label labeldatetime;
        private Label label8;
        private Label DialyCurrentDaytxt;
        private Label MonthlyCurrenttxt;
    }
}
