namespace Ak.ComPort.Test.App
{
    partial class MainForm
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
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.ComPortNumber = new System.Windows.Forms.NumericUpDown();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataTxt = new System.Windows.Forms.TextBox();
            this.RunBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComPortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(13, 13);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(55, 13);
            this.ComPortLabel.TabIndex = 0;
            this.ComPortLabel.Text = "COM port:";
            // 
            // ComPortNumber
            // 
            this.ComPortNumber.Location = new System.Drawing.Point(130, 11);
            this.ComPortNumber.Name = "ComPortNumber";
            this.ComPortNumber.Size = new System.Drawing.Size(194, 20);
            this.ComPortNumber.TabIndex = 1;
            this.ComPortNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(13, 46);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(33, 13);
            this.DataLabel.TabIndex = 2;
            this.DataLabel.Text = "Data:";
            // 
            // DataTxt
            // 
            this.DataTxt.Location = new System.Drawing.Point(130, 43);
            this.DataTxt.Name = "DataTxt";
            this.DataTxt.Size = new System.Drawing.Size(194, 20);
            this.DataTxt.TabIndex = 3;
            this.DataTxt.Text = "#CMD  R00 1 *";
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(130, 81);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(194, 23);
            this.RunBtn.TabIndex = 4;
            this.RunBtn.Text = "Send data";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 116);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.DataTxt);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.ComPortNumber);
            this.Controls.Add(this.ComPortLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "COM port test application";
            ((System.ComponentModel.ISupportInitialize)(this.ComPortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.NumericUpDown ComPortNumber;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TextBox DataTxt;
        private System.Windows.Forms.Button RunBtn;
    }
}

