namespace HiPot
{
    partial class HiPot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiPot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.minimized = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbCiTab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmp = new System.Windows.Forms.Button();
            this.ListPz = new System.Windows.Forms.ListBox();
            this.pnconf = new System.Windows.Forms.Panel();
            this.canconf = new System.Windows.Forms.Button();
            this.bntconf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraseCon = new System.Windows.Forms.TextBox();
            this.UsuarioCon = new System.Windows.Forms.TextBox();
            this.ArduinCon = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha_Hora = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFall = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnconect = new System.Windows.Forms.Button();
            this.pbconec = new System.Windows.Forms.PictureBox();
            this.piboxStatus = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnconf.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbconec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piboxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.minimized);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Magneto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "HiPot";
            // 
            // minimized
            // 
            this.minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimized.Image = global::HiPot.Properties.Resources.negative__2_;
            this.minimized.Location = new System.Drawing.Point(710, 0);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(32, 30);
            this.minimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimized.TabIndex = 15;
            this.minimized.TabStop = false;
            this.minimized.Click += new System.EventHandler(this.minimized_Click);
            this.minimized.MouseLeave += new System.EventHandler(this.minimized_MouseLeave);
            this.minimized.MouseHover += new System.EventHandler(this.minimized_MouseHover);
            this.minimized.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minimized_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HiPot.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(748, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 24);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(73)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.wIPToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // wIPToolStripMenuItem
            // 
            this.wIPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wIPToolStripMenuItem.Name = "wIPToolStripMenuItem";
            this.wIPToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.wIPToolStripMenuItem.Text = "WIP";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.progressBar1.Location = new System.Drawing.Point(327, 327);
            this.progressBar1.Maximum = 68;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(441, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 2;
            // 
            // tbCiTab
            // 
            this.tbCiTab.Location = new System.Drawing.Point(12, 110);
            this.tbCiTab.Name = "tbCiTab";
            this.tbCiTab.Size = new System.Drawing.Size(247, 20);
            this.tbCiTab.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etiqueta";
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(159, 152);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(100, 30);
            this.btnEmp.TabIndex = 6;
            this.btnEmp.Text = "Empezar";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // ListPz
            // 
            this.ListPz.FormattingEnabled = true;
            this.ListPz.Location = new System.Drawing.Point(327, 76);
            this.ListPz.Name = "ListPz";
            this.ListPz.Size = new System.Drawing.Size(441, 251);
            this.ListPz.TabIndex = 7;
            // 
            // pnconf
            // 
            this.pnconf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnconf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnconf.Controls.Add(this.canconf);
            this.pnconf.Controls.Add(this.bntconf);
            this.pnconf.Controls.Add(this.label3);
            this.pnconf.Controls.Add(this.label2);
            this.pnconf.Controls.Add(this.ContraseCon);
            this.pnconf.Controls.Add(this.UsuarioCon);
            this.pnconf.Location = new System.Drawing.Point(277, 110);
            this.pnconf.Name = "pnconf";
            this.pnconf.Size = new System.Drawing.Size(214, 137);
            this.pnconf.TabIndex = 8;
            // 
            // canconf
            // 
            this.canconf.Location = new System.Drawing.Point(27, 99);
            this.canconf.Name = "canconf";
            this.canconf.Size = new System.Drawing.Size(77, 23);
            this.canconf.TabIndex = 4;
            this.canconf.Text = "Cancelar";
            this.canconf.UseVisualStyleBackColor = true;
            this.canconf.Click += new System.EventHandler(this.canconf_Click);
            // 
            // bntconf
            // 
            this.bntconf.Location = new System.Drawing.Point(106, 98);
            this.bntconf.Name = "bntconf";
            this.bntconf.Size = new System.Drawing.Size(77, 24);
            this.bntconf.TabIndex = 3;
            this.bntconf.Text = "Entrar";
            this.bntconf.UseVisualStyleBackColor = true;
            this.bntconf.Click += new System.EventHandler(this.bntconf_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // ContraseCon
            // 
            this.ContraseCon.Location = new System.Drawing.Point(27, 72);
            this.ContraseCon.Name = "ContraseCon";
            this.ContraseCon.Size = new System.Drawing.Size(156, 20);
            this.ContraseCon.TabIndex = 1;
            this.ContraseCon.UseSystemPasswordChar = true;
            this.ContraseCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseCon_KeyPress);
            // 
            // UsuarioCon
            // 
            this.UsuarioCon.Location = new System.Drawing.Point(27, 35);
            this.UsuarioCon.Name = "UsuarioCon";
            this.UsuarioCon.Size = new System.Drawing.Size(156, 20);
            this.UsuarioCon.TabIndex = 0;
            this.UsuarioCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioCon_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-20, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-20, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(-20, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label4";
            // 
            // fecha_Hora
            // 
            this.fecha_Hora.Tick += new System.EventHandler(this.fecha_Hora_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblfecha.Location = new System.Drawing.Point(698, 410);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(34, 13);
            this.lblfecha.TabIndex = 11;
            this.lblfecha.Text = "fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(12, 410);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(28, 13);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.ForeColor = System.Drawing.Color.Chartreuse;
            this.label7.Location = new System.Drawing.Point(589, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pasadas :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(680, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Falladas :";
            // 
            // lblFall
            // 
            this.lblFall.AutoSize = true;
            this.lblFall.CausesValidation = false;
            this.lblFall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFall.Location = new System.Drawing.Point(738, 60);
            this.lblFall.Name = "lblFall";
            this.lblFall.Size = new System.Drawing.Size(0, 13);
            this.lblFall.TabIndex = 13;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.CausesValidation = false;
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPass.Location = new System.Drawing.Point(643, 60);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(0, 13);
            this.lblPass.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnconect);
            this.groupBox1.Controls.Add(this.pbconec);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 68);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunicacion Arduino";
            // 
            // btnconect
            // 
            this.btnconect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnconect.Location = new System.Drawing.Point(6, 21);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 28);
            this.btnconect.TabIndex = 8;
            this.btnconect.Text = "Conectar";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // pbconec
            // 
            this.pbconec.Image = global::HiPot.Properties.Resources.declined;
            this.pbconec.Location = new System.Drawing.Point(99, 21);
            this.pbconec.Name = "pbconec";
            this.pbconec.Size = new System.Drawing.Size(29, 28);
            this.pbconec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbconec.TabIndex = 7;
            this.pbconec.TabStop = false;
            // 
            // piboxStatus
            // 
            this.piboxStatus.Location = new System.Drawing.Point(200, 276);
            this.piboxStatus.Name = "piboxStatus";
            this.piboxStatus.Size = new System.Drawing.Size(59, 61);
            this.piboxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piboxStatus.TabIndex = 15;
            this.piboxStatus.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(513, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(556, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 17;
            // 
            // HiPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(780, 432);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.piboxStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblFall);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnconf);
            this.Controls.Add(this.ListPz);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCiTab);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HiPot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiPot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HiPot_FormClosed);
            this.Load += new System.EventHandler(this.HiPot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnconf.ResumeLayout(false);
            this.pnconf.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbconec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piboxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wIPToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbCiTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.ListBox ListPz;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Panel pnconf;
        private System.Windows.Forms.Button bntconf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraseCon;
        private System.Windows.Forms.TextBox UsuarioCon;
        private System.Windows.Forms.Button canconf;
        private System.IO.Ports.SerialPort ArduinCon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer fecha_Hora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFall;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox minimized;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbconec;
        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.PictureBox piboxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}