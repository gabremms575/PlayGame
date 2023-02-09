namespace FirstGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton1 = new System.Windows.Forms.Button();
            this.countdownLabel3 = new System.Windows.Forms.Label();
            this.countdownLabel2 = new System.Windows.Forms.Label();
            this.countdownLabel1 = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.ClickToStartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton1
            // 
            this.startButton1.BackColor = System.Drawing.Color.Black;
            this.startButton1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton1.ForeColor = System.Drawing.Color.White;
            this.startButton1.Location = new System.Drawing.Point(219, 164);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(175, 131);
            this.startButton1.TabIndex = 0;
            this.startButton1.Text = "Start";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // countdownLabel3
            // 
            this.countdownLabel3.BackColor = System.Drawing.Color.Black;
            this.countdownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel3.ForeColor = System.Drawing.Color.White;
            this.countdownLabel3.Location = new System.Drawing.Point(214, 214);
            this.countdownLabel3.Name = "countdownLabel3";
            this.countdownLabel3.Size = new System.Drawing.Size(40, 40);
            this.countdownLabel3.TabIndex = 1;
            this.countdownLabel3.Text = "3";
            this.countdownLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel3.Visible = false;
            // 
            // countdownLabel2
            // 
            this.countdownLabel2.BackColor = System.Drawing.Color.Black;
            this.countdownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel2.ForeColor = System.Drawing.Color.White;
            this.countdownLabel2.Location = new System.Drawing.Point(285, 214);
            this.countdownLabel2.Name = "countdownLabel2";
            this.countdownLabel2.Size = new System.Drawing.Size(40, 40);
            this.countdownLabel2.TabIndex = 2;
            this.countdownLabel2.Text = "2";
            this.countdownLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel2.Visible = false;
            // 
            // countdownLabel1
            // 
            this.countdownLabel1.BackColor = System.Drawing.Color.Black;
            this.countdownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel1.ForeColor = System.Drawing.Color.White;
            this.countdownLabel1.Location = new System.Drawing.Point(354, 214);
            this.countdownLabel1.Name = "countdownLabel1";
            this.countdownLabel1.Size = new System.Drawing.Size(40, 40);
            this.countdownLabel1.TabIndex = 3;
            this.countdownLabel1.Text = "1";
            this.countdownLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel1.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.BackColor = System.Drawing.Color.Lime;
            this.goLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.Location = new System.Drawing.Point(265, 214);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(83, 45);
            this.goLabel.TabIndex = 4;
            this.goLabel.Text = "GO!";
            this.goLabel.Visible = false;
            // 
            // ClickToStartLabel
            // 
            this.ClickToStartLabel.AutoSize = true;
            this.ClickToStartLabel.BackColor = System.Drawing.Color.Black;
            this.ClickToStartLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickToStartLabel.ForeColor = System.Drawing.Color.White;
            this.ClickToStartLabel.Location = new System.Drawing.Point(223, 109);
            this.ClickToStartLabel.Name = "ClickToStartLabel";
            this.ClickToStartLabel.Size = new System.Drawing.Size(171, 25);
            this.ClickToStartLabel.TabIndex = 5;
            this.ClickToStartLabel.Text = "CLICK TO START";
            this.ClickToStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClickToStartLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 423);
            this.Controls.Add(this.ClickToStartLabel);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdownLabel1);
            this.Controls.Add(this.countdownLabel2);
            this.Controls.Add(this.countdownLabel3);
            this.Controls.Add(this.startButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.Label countdownLabel3;
        private System.Windows.Forms.Label countdownLabel2;
        private System.Windows.Forms.Label countdownLabel1;
        private System.Windows.Forms.Label goLabel;
        private System.Windows.Forms.Label ClickToStartLabel;
    }
}

