namespace EQ_Service_Killer_v1
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
            this.spooler_Status = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.startServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spooler_Status
            // 
            this.spooler_Status.Location = new System.Drawing.Point(93, 71);
            this.spooler_Status.Name = "spooler_Status";
            this.spooler_Status.Size = new System.Drawing.Size(75, 23);
            this.spooler_Status.TabIndex = 0;
            this.spooler_Status.Text = "Status";
            this.spooler_Status.UseVisualStyleBackColor = true;
            this.spooler_Status.Click += new System.EventHandler(this.spooler_Status_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "EQ Service Killer v1 by CptJesusH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spooler";
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.Location = new System.Drawing.Point(12, 100);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(75, 23);
            this.stopServiceButton.TabIndex = 4;
            this.stopServiceButton.Text = "Stop";
            this.stopServiceButton.UseVisualStyleBackColor = true;
            this.stopServiceButton.Click += new System.EventHandler(this.stopServiceButton_Click);
            // 
            // startServiceButton
            // 
            this.startServiceButton.Location = new System.Drawing.Point(12, 71);
            this.startServiceButton.Name = "startServiceButton";
            this.startServiceButton.Size = new System.Drawing.Size(75, 23);
            this.startServiceButton.TabIndex = 5;
            this.startServiceButton.Text = "Start";
            this.startServiceButton.UseVisualStyleBackColor = true;
            this.startServiceButton.Click += new System.EventHandler(this.startServiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 483);
            this.Controls.Add(this.startServiceButton);
            this.Controls.Add(this.stopServiceButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.spooler_Status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spooler_Status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopServiceButton;
        private System.Windows.Forms.Button startServiceButton;
    }
}

