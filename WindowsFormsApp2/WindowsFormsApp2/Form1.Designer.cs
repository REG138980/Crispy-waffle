
namespace WindowsFormsApp2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.TextBox();
            this.Mol = new System.Windows.Forms.TextBox();
            this.Volume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Uitkomst = new System.Windows.Forms.TextBox();
            this.Gasconstante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Uitkomst [Pa]";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Temp [K]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mol [n]";
            // 
            // Temp
            // 
            this.Temp.Location = new System.Drawing.Point(33, 111);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(147, 20);
            this.Temp.TabIndex = 15;
            this.Temp.TextChanged += new System.EventHandler(this.Temp_TextChanged);
            // 
            // Mol
            // 
            this.Mol.Location = new System.Drawing.Point(33, 72);
            this.Mol.Name = "Mol";
            this.Mol.Size = new System.Drawing.Size(147, 20);
            this.Mol.TabIndex = 14;
            this.Mol.TextChanged += new System.EventHandler(this.Mol_TextChanged);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(33, 33);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(147, 20);
            this.Volume.TabIndex = 13;
            this.Volume.TextChanged += new System.EventHandler(this.Volume_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume [m³]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Uitkomst
            // 
            this.Uitkomst.Location = new System.Drawing.Point(200, 72);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(147, 20);
            this.Uitkomst.TabIndex = 20;
            this.Uitkomst.TextChanged += new System.EventHandler(this.Uitkomst_TextChanged);
            // 
            // Gasconstante
            // 
            this.Gasconstante.Location = new System.Drawing.Point(200, 33);
            this.Gasconstante.Name = "Gasconstante";
            this.Gasconstante.Size = new System.Drawing.Size(147, 20);
            this.Gasconstante.TabIndex = 21;
            this.Gasconstante.Text = "8.3144598";
            this.Gasconstante.TextChanged += new System.EventHandler(this.Gasconstante_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gasconstante [R]";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(200, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gasconstante);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Mol);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "P=NRT/V";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Temp;
        private System.Windows.Forms.TextBox Mol;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Uitkomst;
        private System.Windows.Forms.TextBox Gasconstante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

