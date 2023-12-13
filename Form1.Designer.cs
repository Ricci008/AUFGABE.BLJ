namespace ReiseMond
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectTage = new System.Windows.Forms.RadioButton();
            this.selectStunden = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.berechnenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AusgabeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reisedauer zum Mond berechnen";
            // 
            // selectTage
            // 
            this.selectTage.AutoSize = true;
            this.selectTage.Location = new System.Drawing.Point(35, 95);
            this.selectTage.Name = "selectTage";
            this.selectTage.Size = new System.Drawing.Size(160, 41);
            this.selectTage.TabIndex = 1;
            this.selectTage.TabStop = true;
            this.selectTage.Text = "in Tagen";
            this.selectTage.UseVisualStyleBackColor = true;
            // 
            // selectStunden
            // 
            this.selectStunden.AutoSize = true;
            this.selectStunden.Location = new System.Drawing.Point(263, 95);
            this.selectStunden.Name = "selectStunden";
            this.selectStunden.Size = new System.Drawing.Size(188, 41);
            this.selectStunden.TabIndex = 2;
            this.selectStunden.TabStop = true;
            this.selectStunden.Text = "in Stunden";
            this.selectStunden.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geschwindigkeit km/h";
            // 
            // kmTextBox
            // 
            this.kmTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.kmTextBox.Location = new System.Drawing.Point(413, 172);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(126, 44);
            this.kmTextBox.TabIndex = 4;
            // 
            // berechnenButton
            // 
            this.berechnenButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.berechnenButton.Location = new System.Drawing.Point(35, 250);
            this.berechnenButton.Name = "berechnenButton";
            this.berechnenButton.Size = new System.Drawing.Size(504, 57);
            this.berechnenButton.TabIndex = 5;
            this.berechnenButton.Text = "Reisedauer berechnen";
            this.berechnenButton.UseVisualStyleBackColor = false;
            this.berechnenButton.Click += new System.EventHandler(this.berechnenButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ausgabe Reisedauer";
            // 
            // AusgabeTextBox
            // 
            this.AusgabeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AusgabeTextBox.Location = new System.Drawing.Point(413, 352);
            this.AusgabeTextBox.Name = "AusgabeTextBox";
            this.AusgabeTextBox.Size = new System.Drawing.Size(126, 44);
            this.AusgabeTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.AusgabeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.berechnenButton);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectStunden);
            this.Controls.Add(this.selectTage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton selectTage;
        private System.Windows.Forms.RadioButton selectStunden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.Button berechnenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AusgabeTextBox;
    }
}

