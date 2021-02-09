namespace SpringfeildNuclear
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
            this.titleLable = new System.Windows.Forms.Label();
            this.Reactor1 = new System.Windows.Forms.Label();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.Reactor1StateLabel = new System.Windows.Forms.Label();
            this.Reactor2StateLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Cheltenhm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(299, 25);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(213, 23);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Nuclear Reactor Control";
            this.titleLable.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Reactor1
            // 
            this.Reactor1.AutoSize = true;
            this.Reactor1.Font = new System.Drawing.Font("Clarendon Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1.Location = new System.Drawing.Point(156, 69);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(64, 14);
            this.Reactor1.TabIndex = 1;
            this.Reactor1.Text = "Reactor 1";
            // 
            // Reactor2
            // 
            this.Reactor2.AutoSize = true;
            this.Reactor2.Font = new System.Drawing.Font("Clarendon Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2.Location = new System.Drawing.Point(581, 69);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(64, 14);
            this.Reactor2.TabIndex = 2;
            this.Reactor2.Text = "Reactor 2";
            // 
            // Reactor1StateLabel
            // 
            this.Reactor1StateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Reactor1StateLabel.Location = new System.Drawing.Point(143, 107);
            this.Reactor1StateLabel.Name = "Reactor1StateLabel";
            this.Reactor1StateLabel.Size = new System.Drawing.Size(87, 144);
            this.Reactor1StateLabel.TabIndex = 3;
            this.Reactor1StateLabel.Click += new System.EventHandler(this.Reactor1StateLable_Click);
            // 
            // Reactor2StateLabel
            // 
            this.Reactor2StateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Reactor2StateLabel.Location = new System.Drawing.Point(572, 107);
            this.Reactor2StateLabel.Name = "Reactor2StateLabel";
            this.Reactor2StateLabel.Size = new System.Drawing.Size(87, 144);
            this.Reactor2StateLabel.TabIndex = 4;
            this.Reactor2StateLabel.Click += new System.EventHandler(this.Reactor2StateLable_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.White;
            this.OutputLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(309, 363);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(189, 18);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Reactor Stable";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLable_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(366, 300);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(868, 502);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Reactor2StateLabel);
            this.Controls.Add(this.Reactor1StateLabel);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.titleLable);
            this.Font = new System.Drawing.Font("Cheltenhm BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Springfeild Power Plant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Label Reactor1StateLabel;
        private System.Windows.Forms.Label Reactor2StateLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button StartButton;
    }
}

