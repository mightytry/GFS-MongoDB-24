namespace GFS_MongoDB
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TryBT = new System.Windows.Forms.Button();
            this.DescriptionLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputLB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HintBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WantedLB = new System.Windows.Forms.Label();
            this.HintLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TriesLB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HintTriesLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TryBT
            // 
            this.TryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TryBT.Location = new System.Drawing.Point(403, 234);
            this.TryBT.Name = "TryBT";
            this.TryBT.Size = new System.Drawing.Size(128, 48);
            this.TryBT.TabIndex = 0;
            this.TryBT.Text = "Versuchen";
            this.TryBT.UseVisualStyleBackColor = true;
            this.TryBT.Click += new System.EventHandler(this.TryBT_Click);
            // 
            // DescriptionLB
            // 
            this.DescriptionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DescriptionLB.Location = new System.Drawing.Point(201, 39);
            this.DescriptionLB.Name = "DescriptionLB";
            this.DescriptionLB.Size = new System.Drawing.Size(349, 76);
            this.DescriptionLB.TabIndex = 2;
            this.DescriptionLB.Text = "Description bla bla bla bla bla bla bla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(57, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beschreibung: ";
            // 
            // InputLB
            // 
            this.InputLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputLB.Location = new System.Drawing.Point(200, 250);
            this.InputLB.Name = "InputLB";
            this.InputLB.Size = new System.Drawing.Size(149, 23);
            this.InputLB.TabIndex = 4;
            this.InputLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputLB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(104, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eingabe:";
            // 
            // HintBT
            // 
            this.HintBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HintBT.Location = new System.Drawing.Point(108, 351);
            this.HintBT.Name = "HintBT";
            this.HintBT.Size = new System.Drawing.Size(129, 56);
            this.HintBT.TabIndex = 6;
            this.HintBT.Text = "Heinweis";
            this.HintBT.UseVisualStyleBackColor = true;
            this.HintBT.Click += new System.EventHandler(this.HintBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Du sollst eingeben:";
            // 
            // WantedLB
            // 
            this.WantedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WantedLB.Location = new System.Drawing.Point(196, 148);
            this.WantedLB.Name = "WantedLB";
            this.WantedLB.Size = new System.Drawing.Size(354, 83);
            this.WantedLB.TabIndex = 8;
            this.WantedLB.Text = "Description bla bla bla bla bla bla bla";
            // 
            // HintLB
            // 
            this.HintLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HintLB.Location = new System.Drawing.Point(243, 341);
            this.HintLB.Name = "HintLB";
            this.HintLB.Size = new System.Drawing.Size(396, 82);
            this.HintLB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(648, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Versuche";
            // 
            // TriesLB
            // 
            this.TriesLB.AutoSize = true;
            this.TriesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriesLB.Location = new System.Drawing.Point(676, 203);
            this.TriesLB.Name = "TriesLB";
            this.TriesLB.Size = new System.Drawing.Size(36, 20);
            this.TriesLB.TabIndex = 11;
            this.TriesLB.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(652, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hinweise";
            // 
            // HintTriesLB
            // 
            this.HintTriesLB.AutoSize = true;
            this.HintTriesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HintTriesLB.Location = new System.Drawing.Point(676, 299);
            this.HintTriesLB.Name = "HintTriesLB";
            this.HintTriesLB.Size = new System.Drawing.Size(36, 20);
            this.HintTriesLB.TabIndex = 13;
            this.HintTriesLB.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(658, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current";
            // 
            // CurrentLB
            // 
            this.CurrentLB.AutoSize = true;
            this.CurrentLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CurrentLB.Location = new System.Drawing.Point(675, 69);
            this.CurrentLB.Name = "CurrentLB";
            this.CurrentLB.Size = new System.Drawing.Size(36, 20);
            this.CurrentLB.TabIndex = 15;
            this.CurrentLB.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HintTriesLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TriesLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HintLB);
            this.Controls.Add(this.WantedLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HintBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionLB);
            this.Controls.Add(this.TryBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TryBT;
        private System.Windows.Forms.Label DescriptionLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HintBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WantedLB;
        private System.Windows.Forms.Label HintLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TriesLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label HintTriesLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentLB;
    }
}

