
namespace Semana_5_controles_de_formularios_grupo_2
{
    partial class menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baceptar = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.bSi_No = new System.Windows.Forms.Button();
            this.bexclamacion = new System.Windows.Forms.Button();
            this.binterrogacion = new System.Windows.Forms.Button();
            this.berror = new System.Windows.Forms.Button();
            this.menu_princ = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroDeDialogoAceptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_princ.SuspendLayout();
            this.SuspendLayout();
            // 
            // baceptar
            // 
            this.baceptar.BackColor = System.Drawing.Color.Aqua;
            this.baceptar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baceptar.Location = new System.Drawing.Point(70, 166);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(210, 70);
            this.baceptar.TabIndex = 0;
            this.baceptar.Text = "Aceptar";
            this.baceptar.UseVisualStyleBackColor = false;
            this.baceptar.Click += new System.EventHandler(this.baceptar_Click);
            // 
            // bcancel
            // 
            this.bcancel.BackColor = System.Drawing.Color.Aqua;
            this.bcancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bcancel.Location = new System.Drawing.Point(328, 166);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(210, 70);
            this.bcancel.TabIndex = 1;
            this.bcancel.Text = "Aceptar/Cancelar";
            this.bcancel.UseVisualStyleBackColor = false;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // bSi_No
            // 
            this.bSi_No.BackColor = System.Drawing.Color.Aqua;
            this.bSi_No.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSi_No.Location = new System.Drawing.Point(586, 166);
            this.bSi_No.Name = "bSi_No";
            this.bSi_No.Size = new System.Drawing.Size(210, 70);
            this.bSi_No.TabIndex = 2;
            this.bSi_No.Text = "Si / No";
            this.bSi_No.UseVisualStyleBackColor = false;
            this.bSi_No.Click += new System.EventHandler(this.bSi_No_Click);
            // 
            // bexclamacion
            // 
            this.bexclamacion.BackColor = System.Drawing.Color.Aqua;
            this.bexclamacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bexclamacion.Location = new System.Drawing.Point(70, 263);
            this.bexclamacion.Name = "bexclamacion";
            this.bexclamacion.Size = new System.Drawing.Size(210, 70);
            this.bexclamacion.TabIndex = 3;
            this.bexclamacion.Text = "Exclamacion";
            this.bexclamacion.UseVisualStyleBackColor = false;
            this.bexclamacion.Click += new System.EventHandler(this.bexclamacion_Click);
            // 
            // binterrogacion
            // 
            this.binterrogacion.BackColor = System.Drawing.Color.Aqua;
            this.binterrogacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binterrogacion.Location = new System.Drawing.Point(328, 263);
            this.binterrogacion.Name = "binterrogacion";
            this.binterrogacion.Size = new System.Drawing.Size(210, 70);
            this.binterrogacion.TabIndex = 4;
            this.binterrogacion.Text = "Interrogacion";
            this.binterrogacion.UseVisualStyleBackColor = false;
            this.binterrogacion.Click += new System.EventHandler(this.binterrogacion_Click);
            // 
            // berror
            // 
            this.berror.BackColor = System.Drawing.Color.Aqua;
            this.berror.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.berror.Location = new System.Drawing.Point(586, 263);
            this.berror.Name = "berror";
            this.berror.Size = new System.Drawing.Size(210, 70);
            this.berror.TabIndex = 5;
            this.berror.Text = "Error";
            this.berror.UseVisualStyleBackColor = false;
            this.berror.Click += new System.EventHandler(this.berror_Click);
            // 
            // menu_princ
            // 
            this.menu_princ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu_princ.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_princ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem1,
            this.ayudaToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menu_princ.Location = new System.Drawing.Point(0, 0);
            this.menu_princ.Name = "menu_princ";
            this.menu_princ.Size = new System.Drawing.Size(882, 31);
            this.menu_princ.TabIndex = 6;
            this.menu_princ.Text = "SistemaInformatico";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadroDeDialogoAceptarToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.acercaDeToolStripMenuItem.Text = "Menu1";
            // 
            // cuadroDeDialogoAceptarToolStripMenuItem
            // 
            this.cuadroDeDialogoAceptarToolStripMenuItem.Name = "cuadroDeDialogoAceptarToolStripMenuItem";
            this.cuadroDeDialogoAceptarToolStripMenuItem.Size = new System.Drawing.Size(332, 28);
            this.cuadroDeDialogoAceptarToolStripMenuItem.Text = "Cuadro de Dialogo Aceptar";
            this.cuadroDeDialogoAceptarToolStripMenuItem.Click += new System.EventHandler(this.cuadroDeDialogoAceptarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.ayudaToolStripMenuItem.Text = "Menu2";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(132, 27);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(79, 27);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.berror);
            this.Controls.Add(this.binterrogacion);
            this.Controls.Add(this.bexclamacion);
            this.Controls.Add(this.bSi_No);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.baceptar);
            this.Controls.Add(this.menu_princ);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_princ;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles de formularios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_princ.ResumeLayout(false);
            this.menu_princ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Button bSi_No;
        private System.Windows.Forms.Button bexclamacion;
        private System.Windows.Forms.Button binterrogacion;
        private System.Windows.Forms.Button berror;
        private System.Windows.Forms.MenuStrip menu_princ;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroDeDialogoAceptarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

