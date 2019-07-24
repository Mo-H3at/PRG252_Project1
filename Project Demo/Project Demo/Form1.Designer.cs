namespace Project_Demo
{
    partial class lblFuel
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
            this.lblJet1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Obstacle2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.lblFuelTank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnScout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJet1
            // 
            this.lblJet1.AutoSize = true;
            this.lblJet1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJet1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJet1.Location = new System.Drawing.Point(643, 32);
            this.lblJet1.Name = "lblJet1";
            this.lblJet1.Size = new System.Drawing.Size(46, 15);
            this.lblJet1.TabIndex = 0;
            this.lblJet1.Text = "Air Craft";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obstacle";
            // 
            // Obstacle2
            // 
            this.Obstacle2.AutoSize = true;
            this.Obstacle2.BackColor = System.Drawing.Color.Red;
            this.Obstacle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Obstacle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obstacle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Obstacle2.Location = new System.Drawing.Point(183, 150);
            this.Obstacle2.Name = "Obstacle2";
            this.Obstacle2.Size = new System.Drawing.Size(94, 26);
            this.Obstacle2.TabIndex = 2;
            this.Obstacle2.Text = "Obstacle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed: 2042 km/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height: 8000 feet";
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(183, 359);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(100, 20);
            this.txtFuel.TabIndex = 5;
            // 
            // lblFuelTank
            // 
            this.lblFuelTank.AutoSize = true;
            this.lblFuelTank.Location = new System.Drawing.Point(180, 389);
            this.lblFuelTank.Name = "lblFuelTank";
            this.lblFuelTank.Size = new System.Drawing.Size(0, 13);
            this.lblFuelTank.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter amount of fuel ( litres)";
            // 
            // btnScout
            // 
            this.btnScout.Location = new System.Drawing.Point(300, 357);
            this.btnScout.Name = "btnScout";
            this.btnScout.Size = new System.Drawing.Size(75, 23);
            this.btnScout.TabIndex = 8;
            this.btnScout.Text = "Scout";
            this.btnScout.UseVisualStyleBackColor = true;
            this.btnScout.Click += new System.EventHandler(this.btnScout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fuel:";
            // 
            // lblFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnScout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFuelTank);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Obstacle2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJet1);
            this.Name = "lblFuel";
            this.Text = "Enter amount of fuel (litres)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJet1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Obstacle2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.Label lblFuelTank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnScout;
        private System.Windows.Forms.Label label4;
    }
}

