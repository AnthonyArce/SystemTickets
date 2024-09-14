namespace Sistema_Ticket_s
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVender = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkConComida = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNumAsientos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.grpAsientos = new System.Windows.Forms.GroupBox();
            this.lblAsiento13 = new System.Windows.Forms.Label();
            this.lblAsiento12 = new System.Windows.Forms.Label();
            this.lblAsiento11 = new System.Windows.Forms.Label();
            this.lblAsiento10 = new System.Windows.Forms.Label();
            this.lblAsiento9 = new System.Windows.Forms.Label();
            this.lblAsiento8 = new System.Windows.Forms.Label();
            this.lblAsiento7 = new System.Windows.Forms.Label();
            this.lblAsiento6 = new System.Windows.Forms.Label();
            this.lblAsiento5 = new System.Windows.Forms.Label();
            this.lblAsiento4 = new System.Windows.Forms.Label();
            this.lblAsiento3 = new System.Windows.Forms.Label();
            this.lblAsiento2 = new System.Windows.Forms.Label();
            this.lblAsiento1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.lblPorcentajepgb = new System.Windows.Forms.Label();
            this.prbCapacidad = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCantComida = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalRecauConComida = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalRecauSinComida = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCantAsientoOcup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCantAsientoDisp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpAsientos.SuspendLayout();
            this.grpResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.tabPage1.Controls.Add(this.btnVender);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chkConComida);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboNumAsientos);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(101, 231);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(142, 30);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Incluye comida:";
            // 
            // chkConComida
            // 
            this.chkConComida.AutoSize = true;
            this.chkConComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConComida.ForeColor = System.Drawing.SystemColors.Control;
            this.chkConComida.Location = new System.Drawing.Point(166, 170);
            this.chkConComida.Name = "chkConComida";
            this.chkConComida.Size = new System.Drawing.Size(109, 29);
            this.chkConComida.TabIndex = 5;
            this.chkConComida.Text = " $15000";
            this.chkConComida.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(161, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "$25500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(93, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // cboNumAsientos
            // 
            this.cboNumAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumAsientos.FormattingEnabled = true;
            this.cboNumAsientos.Location = new System.Drawing.Point(166, 77);
            this.cboNumAsientos.Name = "cboNumAsientos";
            this.cboNumAsientos.Size = new System.Drawing.Size(152, 21);
            this.cboNumAsientos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "N° Asientos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Venta de ticket´s";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.grpAsientos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asientos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(49, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Asientos bondi";
            // 
            // grpAsientos
            // 
            this.grpAsientos.Controls.Add(this.lblAsiento13);
            this.grpAsientos.Controls.Add(this.lblAsiento12);
            this.grpAsientos.Controls.Add(this.lblAsiento11);
            this.grpAsientos.Controls.Add(this.lblAsiento10);
            this.grpAsientos.Controls.Add(this.lblAsiento9);
            this.grpAsientos.Controls.Add(this.lblAsiento8);
            this.grpAsientos.Controls.Add(this.lblAsiento7);
            this.grpAsientos.Controls.Add(this.lblAsiento6);
            this.grpAsientos.Controls.Add(this.lblAsiento5);
            this.grpAsientos.Controls.Add(this.lblAsiento4);
            this.grpAsientos.Controls.Add(this.lblAsiento3);
            this.grpAsientos.Controls.Add(this.lblAsiento2);
            this.grpAsientos.Controls.Add(this.lblAsiento1);
            this.grpAsientos.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAsientos.Location = new System.Drawing.Point(89, 77);
            this.grpAsientos.Name = "grpAsientos";
            this.grpAsientos.Size = new System.Drawing.Size(164, 168);
            this.grpAsientos.TabIndex = 0;
            this.grpAsientos.TabStop = false;
            // 
            // lblAsiento13
            // 
            this.lblAsiento13.AutoSize = true;
            this.lblAsiento13.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento13.Location = new System.Drawing.Point(128, 129);
            this.lblAsiento13.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento13.Name = "lblAsiento13";
            this.lblAsiento13.Size = new System.Drawing.Size(30, 24);
            this.lblAsiento13.TabIndex = 13;
            this.lblAsiento13.Text = "13";
            // 
            // lblAsiento12
            // 
            this.lblAsiento12.AutoSize = true;
            this.lblAsiento12.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento12.Location = new System.Drawing.Point(92, 129);
            this.lblAsiento12.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento12.Name = "lblAsiento12";
            this.lblAsiento12.Size = new System.Drawing.Size(30, 24);
            this.lblAsiento12.TabIndex = 12;
            this.lblAsiento12.Text = "12";
            // 
            // lblAsiento11
            // 
            this.lblAsiento11.AutoSize = true;
            this.lblAsiento11.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento11.Location = new System.Drawing.Point(54, 129);
            this.lblAsiento11.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento11.Name = "lblAsiento11";
            this.lblAsiento11.Size = new System.Drawing.Size(30, 24);
            this.lblAsiento11.TabIndex = 11;
            this.lblAsiento11.Text = "11";
            // 
            // lblAsiento10
            // 
            this.lblAsiento10.AutoSize = true;
            this.lblAsiento10.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento10.Location = new System.Drawing.Point(15, 129);
            this.lblAsiento10.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento10.Name = "lblAsiento10";
            this.lblAsiento10.Size = new System.Drawing.Size(30, 24);
            this.lblAsiento10.TabIndex = 10;
            this.lblAsiento10.Text = "10";
            // 
            // lblAsiento9
            // 
            this.lblAsiento9.AutoSize = true;
            this.lblAsiento9.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento9.Location = new System.Drawing.Point(108, 95);
            this.lblAsiento9.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento9.Name = "lblAsiento9";
            this.lblAsiento9.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento9.TabIndex = 9;
            this.lblAsiento9.Text = "9";
            // 
            // lblAsiento8
            // 
            this.lblAsiento8.AutoSize = true;
            this.lblAsiento8.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento8.Location = new System.Drawing.Point(60, 95);
            this.lblAsiento8.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento8.Name = "lblAsiento8";
            this.lblAsiento8.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento8.TabIndex = 8;
            this.lblAsiento8.Text = "8";
            // 
            // lblAsiento7
            // 
            this.lblAsiento7.AutoSize = true;
            this.lblAsiento7.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento7.Location = new System.Drawing.Point(26, 98);
            this.lblAsiento7.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento7.Name = "lblAsiento7";
            this.lblAsiento7.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento7.TabIndex = 7;
            this.lblAsiento7.Text = "7";
            // 
            // lblAsiento6
            // 
            this.lblAsiento6.AutoSize = true;
            this.lblAsiento6.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento6.Location = new System.Drawing.Point(108, 69);
            this.lblAsiento6.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento6.Name = "lblAsiento6";
            this.lblAsiento6.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento6.TabIndex = 6;
            this.lblAsiento6.Text = "6";
            // 
            // lblAsiento5
            // 
            this.lblAsiento5.AutoSize = true;
            this.lblAsiento5.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento5.Location = new System.Drawing.Point(60, 69);
            this.lblAsiento5.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento5.Name = "lblAsiento5";
            this.lblAsiento5.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento5.TabIndex = 5;
            this.lblAsiento5.Text = "5";
            // 
            // lblAsiento4
            // 
            this.lblAsiento4.AutoSize = true;
            this.lblAsiento4.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento4.Location = new System.Drawing.Point(26, 69);
            this.lblAsiento4.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento4.Name = "lblAsiento4";
            this.lblAsiento4.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento4.TabIndex = 4;
            this.lblAsiento4.Text = "4";
            // 
            // lblAsiento3
            // 
            this.lblAsiento3.AutoSize = true;
            this.lblAsiento3.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento3.Location = new System.Drawing.Point(108, 34);
            this.lblAsiento3.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento3.Name = "lblAsiento3";
            this.lblAsiento3.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento3.TabIndex = 3;
            this.lblAsiento3.Text = "3";
            // 
            // lblAsiento2
            // 
            this.lblAsiento2.AutoSize = true;
            this.lblAsiento2.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento2.Location = new System.Drawing.Point(60, 34);
            this.lblAsiento2.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento2.Name = "lblAsiento2";
            this.lblAsiento2.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento2.TabIndex = 2;
            this.lblAsiento2.Text = "2";
            // 
            // lblAsiento1
            // 
            this.lblAsiento1.AutoSize = true;
            this.lblAsiento1.BackColor = System.Drawing.Color.Silver;
            this.lblAsiento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAsiento1.Location = new System.Drawing.Point(26, 34);
            this.lblAsiento1.Margin = new System.Windows.Forms.Padding(3);
            this.lblAsiento1.Name = "lblAsiento1";
            this.lblAsiento1.Size = new System.Drawing.Size(24, 25);
            this.lblAsiento1.TabIndex = 1;
            this.lblAsiento1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistemas de tickets";
            // 
            // grpResumen
            // 
            this.grpResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.grpResumen.Controls.Add(this.lblPorcentajepgb);
            this.grpResumen.Controls.Add(this.prbCapacidad);
            this.grpResumen.Controls.Add(this.label9);
            this.grpResumen.Controls.Add(this.lblCantComida);
            this.grpResumen.Controls.Add(this.label13);
            this.grpResumen.Controls.Add(this.lblTotalRecauConComida);
            this.grpResumen.Controls.Add(this.label11);
            this.grpResumen.Controls.Add(this.lblTotalRecauSinComida);
            this.grpResumen.Controls.Add(this.label12);
            this.grpResumen.Controls.Add(this.lblCantAsientoOcup);
            this.grpResumen.Controls.Add(this.label10);
            this.grpResumen.Controls.Add(this.lblCantAsientoDisp);
            this.grpResumen.Controls.Add(this.label8);
            this.grpResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResumen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpResumen.Location = new System.Drawing.Point(420, 123);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Size = new System.Drawing.Size(251, 273);
            this.grpResumen.TabIndex = 2;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen";
            // 
            // lblPorcentajepgb
            // 
            this.lblPorcentajepgb.AutoSize = true;
            this.lblPorcentajepgb.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentajepgb.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblPorcentajepgb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajepgb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPorcentajepgb.Location = new System.Drawing.Point(143, 196);
            this.lblPorcentajepgb.Name = "lblPorcentajepgb";
            this.lblPorcentajepgb.Size = new System.Drawing.Size(31, 16);
            this.lblPorcentajepgb.TabIndex = 12;
            this.lblPorcentajepgb.Text = "20%";
            // 
            // prbCapacidad
            // 
            this.prbCapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prbCapacidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prbCapacidad.Location = new System.Drawing.Point(32, 215);
            this.prbCapacidad.Name = "prbCapacidad";
            this.prbCapacidad.Size = new System.Drawing.Size(178, 23);
            this.prbCapacidad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCapacidad.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Capacidad";
            // 
            // lblCantComida
            // 
            this.lblCantComida.AutoSize = true;
            this.lblCantComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantComida.Location = new System.Drawing.Point(158, 160);
            this.lblCantComida.Name = "lblCantComida";
            this.lblCantComida.Size = new System.Drawing.Size(79, 16);
            this.lblCantComida.TabIndex = 9;
            this.lblCantComida.Text = "cantComida";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Cant. de comida";
            // 
            // lblTotalRecauConComida
            // 
            this.lblTotalRecauConComida.AutoSize = true;
            this.lblTotalRecauConComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecauConComida.Location = new System.Drawing.Point(158, 132);
            this.lblTotalRecauConComida.Name = "lblTotalRecauConComida";
            this.lblTotalRecauConComida.Size = new System.Drawing.Size(103, 16);
            this.lblTotalRecauConComida.TabIndex = 7;
            this.lblTotalRecauConComida.Text = "CanRecaudado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Recau c/c:";
            // 
            // lblTotalRecauSinComida
            // 
            this.lblTotalRecauSinComida.AutoSize = true;
            this.lblTotalRecauSinComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecauSinComida.Location = new System.Drawing.Point(158, 107);
            this.lblTotalRecauSinComida.Name = "lblTotalRecauSinComida";
            this.lblTotalRecauSinComida.Size = new System.Drawing.Size(103, 16);
            this.lblTotalRecauSinComida.TabIndex = 5;
            this.lblTotalRecauSinComida.Text = "CanRecaudado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total Recau s/c:";
            // 
            // lblCantAsientoOcup
            // 
            this.lblCantAsientoOcup.AutoSize = true;
            this.lblCantAsientoOcup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantAsientoOcup.Location = new System.Drawing.Point(158, 74);
            this.lblCantAsientoOcup.Name = "lblCantAsientoOcup";
            this.lblCantAsientoOcup.Size = new System.Drawing.Size(109, 16);
            this.lblCantAsientoOcup.TabIndex = 3;
            this.lblCantAsientoOcup.Text = "cantAsientoOcup";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "A.Ocupados:";
            // 
            // lblCantAsientoDisp
            // 
            this.lblCantAsientoDisp.AutoSize = true;
            this.lblCantAsientoDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantAsientoDisp.Location = new System.Drawing.Point(158, 46);
            this.lblCantAsientoDisp.Name = "lblCantAsientoDisp";
            this.lblCantAsientoDisp.Size = new System.Drawing.Size(105, 16);
            this.lblCantAsientoDisp.TabIndex = 1;
            this.lblCantAsientoDisp.Text = "cantAsientoDisp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(44, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "A.Disponibles:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(707, 472);
            this.Controls.Add(this.grpResumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "System Ticket\'s";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpAsientos.ResumeLayout(false);
            this.grpAsientos.PerformLayout();
            this.grpResumen.ResumeLayout(false);
            this.grpResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkConComida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNumAsientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.GroupBox grpAsientos;
        private System.Windows.Forms.Label lblAsiento2;
        private System.Windows.Forms.Label lblAsiento1;
        private System.Windows.Forms.Label lblAsiento13;
        private System.Windows.Forms.Label lblAsiento12;
        private System.Windows.Forms.Label lblAsiento11;
        private System.Windows.Forms.Label lblAsiento10;
        private System.Windows.Forms.Label lblAsiento9;
        private System.Windows.Forms.Label lblAsiento8;
        private System.Windows.Forms.Label lblAsiento7;
        private System.Windows.Forms.Label lblAsiento6;
        private System.Windows.Forms.Label lblAsiento5;
        private System.Windows.Forms.Label lblAsiento4;
        private System.Windows.Forms.Label lblAsiento3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.Label lblCantAsientoDisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCantAsientoOcup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCantComida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalRecauConComida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalRecauSinComida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar prbCapacidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPorcentajepgb;
    }
}

