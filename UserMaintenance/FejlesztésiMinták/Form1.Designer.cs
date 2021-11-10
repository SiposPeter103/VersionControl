
namespace FejlesztésiMinták
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorChoice = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.boxColorChoice = new System.Windows.Forms.Button();
            this.ribbonColorChoice = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.ribbonColorChoice);
            this.mainPanel.Controls.Add(this.boxColorChoice);
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.colorChoice);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ball";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Car";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next:";
            // 
            // colorChoice
            // 
            this.colorChoice.BackColor = System.Drawing.SystemColors.HotTrack;
            this.colorChoice.Location = new System.Drawing.Point(3, 143);
            this.colorChoice.Name = "colorChoice";
            this.colorChoice.Size = new System.Drawing.Size(75, 23);
            this.colorChoice.TabIndex = 3;
            this.colorChoice.UseVisualStyleBackColor = false;
            this.colorChoice.Click += new System.EventHandler(this.colorChoice_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Present";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // boxColorChoice
            // 
            this.boxColorChoice.BackColor = System.Drawing.SystemColors.HotTrack;
            this.boxColorChoice.Location = new System.Drawing.Point(165, 143);
            this.boxColorChoice.Name = "boxColorChoice";
            this.boxColorChoice.Size = new System.Drawing.Size(75, 23);
            this.boxColorChoice.TabIndex = 5;
            this.boxColorChoice.UseVisualStyleBackColor = false;
            this.boxColorChoice.Click += new System.EventHandler(this.boxColorChoice_Click);
            // 
            // ribbonColorChoice
            // 
            this.ribbonColorChoice.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ribbonColorChoice.Location = new System.Drawing.Point(165, 172);
            this.ribbonColorChoice.Name = "ribbonColorChoice";
            this.ribbonColorChoice.Size = new System.Drawing.Size(75, 23);
            this.ribbonColorChoice.TabIndex = 6;
            this.ribbonColorChoice.UseVisualStyleBackColor = false;
            this.ribbonColorChoice.Click += new System.EventHandler(this.ribbonColorChoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button colorChoice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ribbonColorChoice;
        private System.Windows.Forms.Button boxColorChoice;
    }
}

