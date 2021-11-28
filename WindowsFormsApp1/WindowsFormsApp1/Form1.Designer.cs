namespace WindowsFormsApp1
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
            this.Stofnaam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SW_waarde = new System.Windows.Forms.TextBox();
            this.Massa = new System.Windows.Forms.TextBox();
            this.Temp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Uitkomst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stofnaam
            // 
            this.Stofnaam.FormattingEnabled = true;
            this.Stofnaam.Location = new System.Drawing.Point(33, 33);
            this.Stofnaam.Name = "Stofnaam";
            this.Stofnaam.Size = new System.Drawing.Size(147, 21);
            this.Stofnaam.TabIndex = 0;
            this.Stofnaam.SelectedIndexChanged += new System.EventHandler(this.Stofnaam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materiaal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soortelijke warmte";
            // 
            // SW_waarde
            // 
            this.SW_waarde.Location = new System.Drawing.Point(33, 111);
            this.SW_waarde.Name = "SW_waarde";
            this.SW_waarde.Size = new System.Drawing.Size(147, 20);
            this.SW_waarde.TabIndex = 3;
            // 
            // Massa
            // 
            this.Massa.Location = new System.Drawing.Point(200, 33);
            this.Massa.Name = "Massa";
            this.Massa.Size = new System.Drawing.Size(147, 20);
            this.Massa.TabIndex = 4;
            this.Massa.TextChanged += new System.EventHandler(this.Massa_TextChanged);
            // 
            // Temp
            // 
            this.Temp.Location = new System.Drawing.Point(200, 72);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(147, 20);
            this.Temp.TabIndex = 5;
            this.Temp.TextChanged += new System.EventHandler(this.Temp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Massa [kg]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temp [K]";
            // 
            // Uitkomst
            // 
            this.Uitkomst.Location = new System.Drawing.Point(200, 110);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(147, 20);
            this.Uitkomst.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uitkomst [J]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 154);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Massa);
            this.Controls.Add(this.SW_waarde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stofnaam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Q=MCdT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Stofnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SW_waarde;
        private System.Windows.Forms.TextBox Massa;
        private System.Windows.Forms.TextBox Temp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Uitkomst;
        private System.Windows.Forms.Label label5;
    }
}

