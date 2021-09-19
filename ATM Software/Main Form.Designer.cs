
namespace ATM_Software
{
    partial class Form1
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
            this.InsertCardPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CardNumbertextBox = new System.Windows.Forms.TextBox();
            this.panelPIN = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PINtextBox = new System.Windows.Forms.TextBox();
            this.InsertCardPanel.SuspendLayout();
            this.panelPIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertCardPanel
            // 
            this.InsertCardPanel.Controls.Add(this.CardNumbertextBox);
            this.InsertCardPanel.Controls.Add(this.label1);
            this.InsertCardPanel.Location = new System.Drawing.Point(3, 3);
            this.InsertCardPanel.Name = "InsertCardPanel";
            this.InsertCardPanel.Size = new System.Drawing.Size(1015, 522);
            this.InsertCardPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERT CARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CardNumbertextBox
            // 
            this.CardNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumbertextBox.Location = new System.Drawing.Point(349, 268);
            this.CardNumbertextBox.Multiline = true;
            this.CardNumbertextBox.Name = "CardNumbertextBox";
            this.CardNumbertextBox.Size = new System.Drawing.Size(356, 26);
            this.CardNumbertextBox.TabIndex = 1;
            this.CardNumbertextBox.TextChanged += new System.EventHandler(this.CardNumbertextBox_TextChanged);
            this.CardNumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumbertextBox_KeyPress);
            // 
            // panelPIN
            // 
            this.panelPIN.Controls.Add(this.InsertCardPanel);
            this.panelPIN.Controls.Add(this.PINtextBox);
            this.panelPIN.Controls.Add(this.label2);
            this.panelPIN.Location = new System.Drawing.Point(134, 50);
            this.panelPIN.Name = "panelPIN";
            this.panelPIN.Size = new System.Drawing.Size(1015, 516);
            this.panelPIN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 115);
            this.label2.TabIndex = 0;
            this.label2.Text = "INPUT PIN";
            // 
            // PINtextBox
            // 
            this.PINtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINtextBox.Location = new System.Drawing.Point(428, 266);
            this.PINtextBox.Multiline = true;
            this.PINtextBox.Name = "PINtextBox";
            this.PINtextBox.PasswordChar = '*';
            this.PINtextBox.Size = new System.Drawing.Size(159, 49);
            this.PINtextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 578);
            this.ControlBox = false;
            this.Controls.Add(this.panelPIN);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.InsertCardPanel.ResumeLayout(false);
            this.InsertCardPanel.PerformLayout();
            this.panelPIN.ResumeLayout(false);
            this.panelPIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InsertCardPanel;
        private System.Windows.Forms.TextBox CardNumbertextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPIN;
        private System.Windows.Forms.TextBox PINtextBox;
        private System.Windows.Forms.Label label2;
    }
}

