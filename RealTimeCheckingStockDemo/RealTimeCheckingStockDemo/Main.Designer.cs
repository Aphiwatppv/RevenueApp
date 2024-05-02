namespace RealTimeCheckingStockDemo
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
            textBoxSymblo = new TextBox();
            buttonTakePrice = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxSymblo
            // 
            textBoxSymblo.Location = new Point(101, 69);
            textBoxSymblo.Name = "textBoxSymblo";
            textBoxSymblo.Size = new Size(100, 23);
            textBoxSymblo.TabIndex = 0;
            // 
            // buttonTakePrice
            // 
            buttonTakePrice.Location = new Point(101, 98);
            buttonTakePrice.Name = "buttonTakePrice";
            buttonTakePrice.Size = new Size(75, 23);
            buttonTakePrice.TabIndex = 1;
            buttonTakePrice.Text = "Get";
            buttonTakePrice.UseVisualStyleBackColor = true;
            buttonTakePrice.Click += buttonTakePrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 134);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Price:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonTakePrice);
            Controls.Add(textBoxSymblo);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSymblo;
        private Button buttonTakePrice;
        private Label label1;
    }
}
