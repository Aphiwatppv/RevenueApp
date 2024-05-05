
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelTop = new Panel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            btnMinimize = new Button();
            btnExit = new Button();
            panelBottom = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            labeldatetime = new Label();
            MonthlyCurrenttxt = new Label();
            DialyCurrentDaytxt = new Label();
            panelMain = new Panel();
            panel4 = new Panel();
            statusLabel = new Label();
            panel3 = new Panel();
            dgvSummary = new DataGridView();
            panel2 = new Panel();
            dgvdetail = new DataGridView();
            btnRemoveDetail = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdetail).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(47, 47, 47);
            panelTop.Controls.Add(pictureBox2);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(btnMinimize);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1659, 60);
            panelTop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(98, 9);
            label8.Name = "label8";
            label8.Size = new Size(286, 32);
            label8.TabIndex = 2;
            label8.Text = "Expense Income Record";
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 15F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1509, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(75, 60);
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
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1584, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 60);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(51, 51, 51);
            panelBottom.Controls.Add(label9);
            panelBottom.Controls.Add(pictureBox1);
            panelBottom.Controls.Add(labeldatetime);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 698);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1659, 37);
            panelBottom.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1347, 7);
            label9.Name = "label9";
            label9.Size = new Size(237, 21);
            label9.TabIndex = 4;
            label9.Text = "Developed by Aphiwat Company";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1594, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labeldatetime
            // 
            labeldatetime.AutoSize = true;
            labeldatetime.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            labeldatetime.ForeColor = Color.White;
            labeldatetime.Location = new Point(12, 7);
            labeldatetime.Name = "labeldatetime";
            labeldatetime.Size = new Size(48, 21);
            labeldatetime.TabIndex = 0;
            labeldatetime.Text = "Clock";
            // 
            // MonthlyCurrenttxt
            // 
            MonthlyCurrenttxt.AutoSize = true;
            MonthlyCurrenttxt.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            MonthlyCurrenttxt.ForeColor = SystemColors.ButtonHighlight;
            MonthlyCurrenttxt.Location = new Point(532, 7);
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
            DialyCurrentDaytxt.Location = new Point(7, 7);
            DialyCurrentDaytxt.Name = "DialyCurrentDaytxt";
            DialyCurrentDaytxt.Size = new Size(90, 21);
            DialyCurrentDaytxt.TabIndex = 1;
            DialyCurrentDaytxt.Text = "CurrentDay";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(dgvSummary);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(dataGridViewRecord);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1659, 638);
            panelMain.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(47, 47, 47);
            panel4.Controls.Add(statusLabel);
            panel4.Location = new Point(999, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 41);
            panel4.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            statusLabel.ForeColor = SystemColors.ButtonHighlight;
            statusLabel.Location = new Point(14, 8);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 21);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Status";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(47, 47, 47);
            panel3.Controls.Add(DialyCurrentDaytxt);
            panel3.Controls.Add(MonthlyCurrenttxt);
            panel3.Location = new Point(5, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 41);
            panel3.TabIndex = 4;
            // 
            // dgvSummary
            // 
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(999, 54);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.Size = new Size(358, 578);
            dgvSummary.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 47, 47);
            panel2.Controls.Add(dgvdetail);
            panel2.Controls.Add(btnRemoveDetail);
            panel2.Controls.Add(buttonAddDetail);
            panel2.Controls.Add(txtdetail);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtTypes);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(1364, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 263);
            panel2.TabIndex = 2;
            // 
            // dgvdetail
            // 
            dgvdetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdetail.Location = new Point(12, 28);
            dgvdetail.Name = "dgvdetail";
            dgvdetail.Size = new Size(271, 144);
            dgvdetail.TabIndex = 17;
            dgvdetail.CellClick += dgvdetail_CellClick;
            // 
            // btnRemoveDetail
            // 
            btnRemoveDetail.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoveDetail.FlatAppearance.BorderSize = 0;
            btnRemoveDetail.FlatStyle = FlatStyle.Flat;
            btnRemoveDetail.ForeColor = Color.FromArgb(47, 47, 47);
            btnRemoveDetail.Location = new Point(178, 236);
            btnRemoveDetail.Name = "btnRemoveDetail";
            btnRemoveDetail.Size = new Size(105, 23);
            btnRemoveDetail.TabIndex = 16;
            btnRemoveDetail.Text = "Remove";
            btnRemoveDetail.UseVisualStyleBackColor = false;
            btnRemoveDetail.Click += btnRemoveDetail_Click;
            // 
            // buttonAddDetail
            // 
            buttonAddDetail.BackColor = Color.FromArgb(192, 255, 192);
            buttonAddDetail.FlatAppearance.BorderSize = 0;
            buttonAddDetail.FlatStyle = FlatStyle.Flat;
            buttonAddDetail.ForeColor = Color.FromArgb(47, 47, 47);
            buttonAddDetail.Location = new Point(178, 178);
            buttonAddDetail.Name = "buttonAddDetail";
            buttonAddDetail.Size = new Size(105, 52);
            buttonAddDetail.TabIndex = 15;
            buttonAddDetail.Text = "Add";
            buttonAddDetail.UseVisualStyleBackColor = false;
            buttonAddDetail.Click += buttonAddDetail_Click;
            // 
            // txtdetail
            // 
            txtdetail.Location = new Point(69, 178);
            txtdetail.Name = "txtdetail";
            txtdetail.Size = new Size(105, 23);
            txtdetail.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            label10.ForeColor = Color.White;
            label10.Location = new Point(105, 0);
            label10.Name = "label10";
            label10.Size = new Size(115, 21);
            label10.TabIndex = 8;
            label10.Text = "Add Category";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(30, 215);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 6;
            label12.Text = "Type :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(24, 186);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 5;
            label13.Text = "Detail :";
            // 
            // txtTypes
            // 
            txtTypes.Location = new Point(69, 207);
            txtTypes.Name = "txtTypes";
            txtTypes.Size = new Size(105, 23);
            txtTypes.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
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
            panel1.Location = new Point(1363, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 360);
            panel1.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(255, 255, 128);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = Color.FromArgb(47, 47, 47);
            buttonUpdate.Location = new Point(22, 310);
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
            buttonRemove.Location = new Point(160, 310);
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
            label7.ForeColor = Color.White;
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
            label6.ForeColor = Color.White;
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
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 10);
            label5.Name = "label5";
            label5.Size = new Size(187, 21);
            label5.TabIndex = 8;
            label5.Text = "Record Income&Expense";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 141);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Detail Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 170);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Detail : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
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
            dataGridViewRecord.Location = new Point(3, 54);
            dataGridViewRecord.Name = "dataGridViewRecord";
            dataGridViewRecord.Size = new Size(990, 578);
            dataGridViewRecord.TabIndex = 0;
            dataGridViewRecord.CellClick += dataGridViewRecord_CellClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 735);
            Controls.Add(panelMain);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revenue Income Expense Invest App";
            Load += Main_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdetail).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvSummary;
        private Panel panel3;
        private Panel panel4;
        private Label statusLabel;
        private Label label9;
        private DataGridView dgvdetail;
        private Button btnRemoveDetail;
    }
}
