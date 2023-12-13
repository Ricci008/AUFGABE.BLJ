namespace WürfelAufgabe
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
            this.WuerfelnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WurfLable = new System.Windows.Forms.Label();
            this.letzterWurfLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WuerfelnButton
            // 
            this.WuerfelnButton.Location = new System.Drawing.Point(111, 65);
            this.WuerfelnButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.WuerfelnButton.Name = "WuerfelnButton";
            this.WuerfelnButton.Size = new System.Drawing.Size(779, 222);
            this.WuerfelnButton.TabIndex = 0;
            this.WuerfelnButton.Text = "Würfeln";
            this.WuerfelnButton.UseVisualStyleBackColor = true;
            this.WuerfelnButton.Click += new System.EventHandler(this.WuerfelnButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Letzter Wurf: ";
            // 
            // WurfLable
            // 
            this.WurfLable.AutoSize = true;
            this.WurfLable.Location = new System.Drawing.Point(1188, 159);
            this.WurfLable.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.WurfLable.Name = "WurfLable";
            this.WurfLable.Size = new System.Drawing.Size(35, 37);
            this.WurfLable.TabIndex = 2;
            this.WurfLable.Text = "0";
            // 
            // letzterWurfLable
            // 
            this.letzterWurfLable.AutoSize = true;
            this.letzterWurfLable.Location = new System.Drawing.Point(535, 370);
            this.letzterWurfLable.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.letzterWurfLable.Name = "letzterWurfLable";
            this.letzterWurfLable.Size = new System.Drawing.Size(35, 37);
            this.letzterWurfLable.TabIndex = 3;
            this.letzterWurfLable.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 1061);
            this.Controls.Add(this.letzterWurfLable);
            this.Controls.Add(this.WurfLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WuerfelnButton);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WuerfelnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WurfLable;
        private System.Windows.Forms.Label letzterWurfLable;
    }
}

