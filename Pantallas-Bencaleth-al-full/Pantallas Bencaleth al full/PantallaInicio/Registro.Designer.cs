﻿namespace PantallaInicio
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_mant = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_vol = new System.Windows.Forms.Button();
            this.btn_empresas = new System.Windows.Forms.Button();
            this.btn_alcancias = new System.Windows.Forms.Button();
            this.btn_pad = new System.Windows.Forms.Button();
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_niños = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.btn_mant);
            this.splitContainer1.Panel2.Controls.Add(this.btn_menu);
            this.splitContainer1.Panel2.Controls.Add(this.btn_vol);
            this.splitContainer1.Panel2.Controls.Add(this.btn_empresas);
            this.splitContainer1.Panel2.Controls.Add(this.btn_alcancias);
            this.splitContainer1.Panel2.Controls.Add(this.btn_pad);
            this.splitContainer1.Panel2.Controls.Add(this.btn_emp);
            this.splitContainer1.Panel2.Controls.Add(this.btn_niños);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1276, 733);
            this.splitContainer1.SplitterDistance = 877;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_mant
            // 
            this.btn_mant.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_mant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mant.Location = new System.Drawing.Point(150, 527);
            this.btn_mant.Name = "btn_mant";
            this.btn_mant.Size = new System.Drawing.Size(150, 45);
            this.btn_mant.TabIndex = 13;
            this.btn_mant.Text = "Mantenimiento";
            this.btn_mant.UseVisualStyleBackColor = false;
            this.btn_mant.Click += new System.EventHandler(this.btn_mant_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu.Location = new System.Drawing.Point(150, 590);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(150, 45);
            this.btn_menu.TabIndex = 12;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_vol
            // 
            this.btn_vol.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_vol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_vol.Location = new System.Drawing.Point(150, 228);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(150, 45);
            this.btn_vol.TabIndex = 11;
            this.btn_vol.Text = "Voluntarios";
            this.btn_vol.UseVisualStyleBackColor = false;
            this.btn_vol.Click += new System.EventHandler(this.btn_vol_Click);
            // 
            // btn_empresas
            // 
            this.btn_empresas.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_empresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_empresas.Location = new System.Drawing.Point(150, 417);
            this.btn_empresas.Name = "btn_empresas";
            this.btn_empresas.Size = new System.Drawing.Size(150, 45);
            this.btn_empresas.TabIndex = 10;
            this.btn_empresas.Text = "Empresas";
            this.btn_empresas.UseVisualStyleBackColor = false;
            this.btn_empresas.Click += new System.EventHandler(this.btn_empresas_Click);
            // 
            // btn_alcancias
            // 
            this.btn_alcancias.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_alcancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alcancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alcancias.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_alcancias.Location = new System.Drawing.Point(150, 356);
            this.btn_alcancias.Name = "btn_alcancias";
            this.btn_alcancias.Size = new System.Drawing.Size(150, 45);
            this.btn_alcancias.TabIndex = 9;
            this.btn_alcancias.Text = "Alcancias";
            this.btn_alcancias.UseVisualStyleBackColor = false;
            this.btn_alcancias.Click += new System.EventHandler(this.btn_alcancias_Click);
            // 
            // btn_pad
            // 
            this.btn_pad.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_pad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pad.Location = new System.Drawing.Point(150, 290);
            this.btn_pad.Name = "btn_pad";
            this.btn_pad.Size = new System.Drawing.Size(150, 45);
            this.btn_pad.TabIndex = 8;
            this.btn_pad.Text = "Padrinos";
            this.btn_pad.UseVisualStyleBackColor = false;
            this.btn_pad.Click += new System.EventHandler(this.btn_pad_Click);
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_emp.Location = new System.Drawing.Point(150, 165);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(150, 45);
            this.btn_emp.TabIndex = 7;
            this.btn_emp.Text = "Empleados";
            this.btn_emp.UseVisualStyleBackColor = false;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // btn_niños
            // 
            this.btn_niños.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_niños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_niños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_niños.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_niños.Location = new System.Drawing.Point(150, 100);
            this.btn_niños.Name = "btn_niños";
            this.btn_niños.Size = new System.Drawing.Size(150, 45);
            this.btn_niños.TabIndex = 6;
            this.btn_niños.Text = "Niños";
            this.btn_niños.UseVisualStyleBackColor = false;
            this.btn_niños.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_vol;
        private System.Windows.Forms.Button btn_empresas;
        private System.Windows.Forms.Button btn_alcancias;
        private System.Windows.Forms.Button btn_pad;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Button btn_niños;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_mant;
    }
}