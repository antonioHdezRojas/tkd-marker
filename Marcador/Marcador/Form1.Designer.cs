namespace Marcador
{
    partial class frmCombate
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPuntoRojo = new System.Windows.Forms.Button();
            this.btnPuntoAzul = new System.Windows.Forms.Button();
            this.txtHong = new System.Windows.Forms.TextBox();
            this.txtChong = new System.Windows.Forms.TextBox();
            this.txtHongKiongo1 = new System.Windows.Forms.TextBox();
            this.txtHongKiongo5 = new System.Windows.Forms.TextBox();
            this.txtHongKiongo2 = new System.Windows.Forms.TextBox();
            this.txtHongKiongo3 = new System.Windows.Forms.TextBox();
            this.txtHongKiongo4 = new System.Windows.Forms.TextBox();
            this.txtChongKiongo4 = new System.Windows.Forms.TextBox();
            this.txtChongKiongo3 = new System.Windows.Forms.TextBox();
            this.txtChongKiongo2 = new System.Windows.Forms.TextBox();
            this.txtChongKiongo5 = new System.Windows.Forms.TextBox();
            this.txtChongKiongo1 = new System.Windows.Forms.TextBox();
            this.btnKiongoRojo = new System.Windows.Forms.Button();
            this.btnKiongoAzul = new System.Windows.Forms.Button();
            this.txtCronometro = new System.Windows.Forms.TextBox();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.Detener = new System.Windows.Forms.Button();
            this.btnTiempoMedico = new System.Windows.Forms.Button();
            this.tmrRound = new System.Windows.Forms.Timer(this.components);
            this.btnQuitaKiongoR = new System.Windows.Forms.Button();
            this.btnQuitaPuntoR = new System.Windows.Forms.Button();
            this.btnQuitaKiongoA = new System.Windows.Forms.Button();
            this.btnQuitaPuntoA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJuez1R = new System.Windows.Forms.TextBox();
            this.txtJuez2R = new System.Windows.Forms.TextBox();
            this.txtJuez3R = new System.Windows.Forms.TextBox();
            this.txtJuez3A = new System.Windows.Forms.TextBox();
            this.txtJuez2A = new System.Windows.Forms.TextBox();
            this.txtJuez1A = new System.Windows.Forms.TextBox();
            this.pnlGanadorAzul = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGanadorRojo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTiempoMenos = new System.Windows.Forms.Button();
            this.btnTiempoMas = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.pnlGanadorAzul.SuspendLayout();
            this.pnlGanadorRojo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPuntoRojo
            // 
            this.btnPuntoRojo.Location = new System.Drawing.Point(89, 387);
            this.btnPuntoRojo.Name = "btnPuntoRojo";
            this.btnPuntoRojo.Size = new System.Drawing.Size(75, 23);
            this.btnPuntoRojo.TabIndex = 2;
            this.btnPuntoRojo.TabStop = false;
            this.btnPuntoRojo.Text = "Punto +";
            this.btnPuntoRojo.UseVisualStyleBackColor = true;
            this.btnPuntoRojo.Click += new System.EventHandler(this.btnPuntoRojo_Click);
            // 
            // btnPuntoAzul
            // 
            this.btnPuntoAzul.Location = new System.Drawing.Point(771, 387);
            this.btnPuntoAzul.Name = "btnPuntoAzul";
            this.btnPuntoAzul.Size = new System.Drawing.Size(75, 23);
            this.btnPuntoAzul.TabIndex = 3;
            this.btnPuntoAzul.TabStop = false;
            this.btnPuntoAzul.Text = "Punto +";
            this.btnPuntoAzul.UseVisualStyleBackColor = true;
            this.btnPuntoAzul.Click += new System.EventHandler(this.btnPuntoAzul_Click);
            // 
            // txtHong
            // 
            this.txtHong.BackColor = System.Drawing.Color.Red;
            this.txtHong.Enabled = false;
            this.txtHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHong.Location = new System.Drawing.Point(12, 47);
            this.txtHong.Multiline = true;
            this.txtHong.Name = "txtHong";
            this.txtHong.Size = new System.Drawing.Size(303, 271);
            this.txtHong.TabIndex = 4;
            this.txtHong.TabStop = false;
            this.txtHong.Text = "0";
            this.txtHong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChong
            // 
            this.txtChong.BackColor = System.Drawing.Color.Blue;
            this.txtChong.Enabled = false;
            this.txtChong.Font = new System.Drawing.Font("Microsoft Sans Serif", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChong.Location = new System.Drawing.Point(715, 47);
            this.txtChong.Multiline = true;
            this.txtChong.Name = "txtChong";
            this.txtChong.Size = new System.Drawing.Size(303, 271);
            this.txtChong.TabIndex = 5;
            this.txtChong.TabStop = false;
            this.txtChong.Text = "0";
            this.txtChong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChong.TextChanged += new System.EventHandler(this.txtChong_TextChanged);
            // 
            // txtHongKiongo1
            // 
            this.txtHongKiongo1.BackColor = System.Drawing.Color.Yellow;
            this.txtHongKiongo1.Enabled = false;
            this.txtHongKiongo1.Location = new System.Drawing.Point(33, 324);
            this.txtHongKiongo1.Multiline = true;
            this.txtHongKiongo1.Name = "txtHongKiongo1";
            this.txtHongKiongo1.Size = new System.Drawing.Size(35, 50);
            this.txtHongKiongo1.TabIndex = 6;
            this.txtHongKiongo1.Visible = false;
            // 
            // txtHongKiongo5
            // 
            this.txtHongKiongo5.BackColor = System.Drawing.Color.Yellow;
            this.txtHongKiongo5.Enabled = false;
            this.txtHongKiongo5.Location = new System.Drawing.Point(258, 324);
            this.txtHongKiongo5.Multiline = true;
            this.txtHongKiongo5.Name = "txtHongKiongo5";
            this.txtHongKiongo5.Size = new System.Drawing.Size(35, 50);
            this.txtHongKiongo5.TabIndex = 7;
            this.txtHongKiongo5.TabStop = false;
            this.txtHongKiongo5.Visible = false;
            this.txtHongKiongo5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHongKiongo2
            // 
            this.txtHongKiongo2.BackColor = System.Drawing.Color.Yellow;
            this.txtHongKiongo2.Enabled = false;
            this.txtHongKiongo2.Location = new System.Drawing.Point(89, 324);
            this.txtHongKiongo2.Multiline = true;
            this.txtHongKiongo2.Name = "txtHongKiongo2";
            this.txtHongKiongo2.Size = new System.Drawing.Size(35, 50);
            this.txtHongKiongo2.TabIndex = 8;
            this.txtHongKiongo2.TabStop = false;
            this.txtHongKiongo2.Visible = false;
            // 
            // txtHongKiongo3
            // 
            this.txtHongKiongo3.BackColor = System.Drawing.Color.Yellow;
            this.txtHongKiongo3.Enabled = false;
            this.txtHongKiongo3.Location = new System.Drawing.Point(146, 324);
            this.txtHongKiongo3.Multiline = true;
            this.txtHongKiongo3.Name = "txtHongKiongo3";
            this.txtHongKiongo3.Size = new System.Drawing.Size(35, 50);
            this.txtHongKiongo3.TabIndex = 9;
            this.txtHongKiongo3.TabStop = false;
            this.txtHongKiongo3.Visible = false;
            // 
            // txtHongKiongo4
            // 
            this.txtHongKiongo4.BackColor = System.Drawing.Color.Yellow;
            this.txtHongKiongo4.Enabled = false;
            this.txtHongKiongo4.Location = new System.Drawing.Point(202, 324);
            this.txtHongKiongo4.Multiline = true;
            this.txtHongKiongo4.Name = "txtHongKiongo4";
            this.txtHongKiongo4.Size = new System.Drawing.Size(35, 50);
            this.txtHongKiongo4.TabIndex = 10;
            this.txtHongKiongo4.TabStop = false;
            this.txtHongKiongo4.Visible = false;
            // 
            // txtChongKiongo4
            // 
            this.txtChongKiongo4.BackColor = System.Drawing.Color.Yellow;
            this.txtChongKiongo4.Enabled = false;
            this.txtChongKiongo4.Location = new System.Drawing.Point(905, 324);
            this.txtChongKiongo4.Multiline = true;
            this.txtChongKiongo4.Name = "txtChongKiongo4";
            this.txtChongKiongo4.Size = new System.Drawing.Size(35, 50);
            this.txtChongKiongo4.TabIndex = 15;
            this.txtChongKiongo4.TabStop = false;
            this.txtChongKiongo4.Visible = false;
            // 
            // txtChongKiongo3
            // 
            this.txtChongKiongo3.BackColor = System.Drawing.Color.Yellow;
            this.txtChongKiongo3.Enabled = false;
            this.txtChongKiongo3.Location = new System.Drawing.Point(849, 324);
            this.txtChongKiongo3.Multiline = true;
            this.txtChongKiongo3.Name = "txtChongKiongo3";
            this.txtChongKiongo3.Size = new System.Drawing.Size(35, 50);
            this.txtChongKiongo3.TabIndex = 14;
            this.txtChongKiongo3.TabStop = false;
            this.txtChongKiongo3.Visible = false;
            // 
            // txtChongKiongo2
            // 
            this.txtChongKiongo2.BackColor = System.Drawing.Color.Yellow;
            this.txtChongKiongo2.Enabled = false;
            this.txtChongKiongo2.Location = new System.Drawing.Point(792, 324);
            this.txtChongKiongo2.Multiline = true;
            this.txtChongKiongo2.Name = "txtChongKiongo2";
            this.txtChongKiongo2.Size = new System.Drawing.Size(35, 50);
            this.txtChongKiongo2.TabIndex = 13;
            this.txtChongKiongo2.TabStop = false;
            this.txtChongKiongo2.Visible = false;
            // 
            // txtChongKiongo5
            // 
            this.txtChongKiongo5.BackColor = System.Drawing.Color.Yellow;
            this.txtChongKiongo5.Enabled = false;
            this.txtChongKiongo5.Location = new System.Drawing.Point(961, 324);
            this.txtChongKiongo5.Multiline = true;
            this.txtChongKiongo5.Name = "txtChongKiongo5";
            this.txtChongKiongo5.Size = new System.Drawing.Size(35, 50);
            this.txtChongKiongo5.TabIndex = 12;
            this.txtChongKiongo5.TabStop = false;
            this.txtChongKiongo5.Visible = false;
            // 
            // txtChongKiongo1
            // 
            this.txtChongKiongo1.BackColor = System.Drawing.Color.Yellow;
            this.txtChongKiongo1.Enabled = false;
            this.txtChongKiongo1.Location = new System.Drawing.Point(736, 324);
            this.txtChongKiongo1.Multiline = true;
            this.txtChongKiongo1.Name = "txtChongKiongo1";
            this.txtChongKiongo1.Size = new System.Drawing.Size(35, 50);
            this.txtChongKiongo1.TabIndex = 11;
            this.txtChongKiongo1.TabStop = false;
            this.txtChongKiongo1.Visible = false;
            // 
            // btnKiongoRojo
            // 
            this.btnKiongoRojo.Location = new System.Drawing.Point(183, 387);
            this.btnKiongoRojo.Name = "btnKiongoRojo";
            this.btnKiongoRojo.Size = new System.Drawing.Size(75, 23);
            this.btnKiongoRojo.TabIndex = 16;
            this.btnKiongoRojo.TabStop = false;
            this.btnKiongoRojo.Text = "Kiongo +";
            this.btnKiongoRojo.UseVisualStyleBackColor = true;
            this.btnKiongoRojo.Click += new System.EventHandler(this.btnKiongoRojo_Click);
            // 
            // btnKiongoAzul
            // 
            this.btnKiongoAzul.Location = new System.Drawing.Point(865, 387);
            this.btnKiongoAzul.Name = "btnKiongoAzul";
            this.btnKiongoAzul.Size = new System.Drawing.Size(75, 23);
            this.btnKiongoAzul.TabIndex = 17;
            this.btnKiongoAzul.TabStop = false;
            this.btnKiongoAzul.Text = "Kiongo +";
            this.btnKiongoAzul.UseVisualStyleBackColor = true;
            this.btnKiongoAzul.Click += new System.EventHandler(this.btnKiongoAzul_Click);
            // 
            // txtCronometro
            // 
            this.txtCronometro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCronometro.CausesValidation = false;
            this.txtCronometro.Enabled = false;
            this.txtCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCronometro.ForeColor = System.Drawing.Color.Black;
            this.txtCronometro.Location = new System.Drawing.Point(321, 47);
            this.txtCronometro.Multiline = true;
            this.txtCronometro.Name = "txtCronometro";
            this.txtCronometro.Size = new System.Drawing.Size(388, 168);
            this.txtCronometro.TabIndex = 18;
            this.txtCronometro.TabStop = false;
            this.txtCronometro.Text = "3:00";
            this.txtCronometro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRound
            // 
            this.txtRound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRound.Enabled = false;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRound.ForeColor = System.Drawing.Color.Black;
            this.txtRound.Location = new System.Drawing.Point(470, 207);
            this.txtRound.Multiline = true;
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(82, 122);
            this.txtRound.TabIndex = 19;
            this.txtRound.TabStop = false;
            this.txtRound.Text = "1\r\nRound";
            this.txtRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(402, 387);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 20;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Detener
            // 
            this.Detener.Location = new System.Drawing.Point(553, 387);
            this.Detener.Name = "Detener";
            this.Detener.Size = new System.Drawing.Size(75, 23);
            this.Detener.TabIndex = 21;
            this.Detener.TabStop = false;
            this.Detener.Text = "Detener";
            this.Detener.UseVisualStyleBackColor = true;
            this.Detener.Click += new System.EventHandler(this.Detener_Click);
            // 
            // btnTiempoMedico
            // 
            this.btnTiempoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempoMedico.Location = new System.Drawing.Point(402, 370);
            this.btnTiempoMedico.Name = "btnTiempoMedico";
            this.btnTiempoMedico.Size = new System.Drawing.Size(226, 55);
            this.btnTiempoMedico.TabIndex = 1;
            this.btnTiempoMedico.TabStop = false;
            this.btnTiempoMedico.Text = "Inicio/Detener";
            this.btnTiempoMedico.UseVisualStyleBackColor = true;
            this.btnTiempoMedico.Click += new System.EventHandler(this.btnTiempoMedico_Click);
            // 
            // tmrRound
            // 
            this.tmrRound.Interval = 1000;
            this.tmrRound.Tick += new System.EventHandler(this.tmrRound_Tick);
            // 
            // btnQuitaKiongoR
            // 
            this.btnQuitaKiongoR.Location = new System.Drawing.Point(183, 416);
            this.btnQuitaKiongoR.Name = "btnQuitaKiongoR";
            this.btnQuitaKiongoR.Size = new System.Drawing.Size(75, 23);
            this.btnQuitaKiongoR.TabIndex = 24;
            this.btnQuitaKiongoR.TabStop = false;
            this.btnQuitaKiongoR.Text = "Kiongo -";
            this.btnQuitaKiongoR.UseVisualStyleBackColor = true;
            this.btnQuitaKiongoR.Click += new System.EventHandler(this.btnQuitaKiongoR_Click);
            // 
            // btnQuitaPuntoR
            // 
            this.btnQuitaPuntoR.Location = new System.Drawing.Point(89, 416);
            this.btnQuitaPuntoR.Name = "btnQuitaPuntoR";
            this.btnQuitaPuntoR.Size = new System.Drawing.Size(75, 23);
            this.btnQuitaPuntoR.TabIndex = 23;
            this.btnQuitaPuntoR.TabStop = false;
            this.btnQuitaPuntoR.Text = "Punto -";
            this.btnQuitaPuntoR.UseVisualStyleBackColor = true;
            this.btnQuitaPuntoR.Click += new System.EventHandler(this.btnQuitaPuntoR_Click);
            // 
            // btnQuitaKiongoA
            // 
            this.btnQuitaKiongoA.Location = new System.Drawing.Point(865, 416);
            this.btnQuitaKiongoA.Name = "btnQuitaKiongoA";
            this.btnQuitaKiongoA.Size = new System.Drawing.Size(75, 23);
            this.btnQuitaKiongoA.TabIndex = 26;
            this.btnQuitaKiongoA.TabStop = false;
            this.btnQuitaKiongoA.Text = "Kiongo -";
            this.btnQuitaKiongoA.UseVisualStyleBackColor = true;
            this.btnQuitaKiongoA.Click += new System.EventHandler(this.btnRestaKiongoA_Click);
            // 
            // btnQuitaPuntoA
            // 
            this.btnQuitaPuntoA.Location = new System.Drawing.Point(771, 416);
            this.btnQuitaPuntoA.Name = "btnQuitaPuntoA";
            this.btnQuitaPuntoA.Size = new System.Drawing.Size(75, 23);
            this.btnQuitaPuntoA.TabIndex = 25;
            this.btnQuitaPuntoA.TabStop = false;
            this.btnQuitaPuntoA.Text = "Punto -";
            this.btnQuitaPuntoA.UseVisualStyleBackColor = true;
            this.btnQuitaPuntoA.Click += new System.EventHandler(this.btnRestaPuntoA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Juez 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Juez 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Juez 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Juez 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Juez 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Juez 1";
            // 
            // txtJuez1R
            // 
            this.txtJuez1R.BackColor = System.Drawing.Color.Red;
            this.txtJuez1R.Location = new System.Drawing.Point(109, 21);
            this.txtJuez1R.Name = "txtJuez1R";
            this.txtJuez1R.Size = new System.Drawing.Size(18, 20);
            this.txtJuez1R.TabIndex = 33;
            this.txtJuez1R.Visible = false;
            // 
            // txtJuez2R
            // 
            this.txtJuez2R.BackColor = System.Drawing.Color.Red;
            this.txtJuez2R.Location = new System.Drawing.Point(146, 21);
            this.txtJuez2R.Name = "txtJuez2R";
            this.txtJuez2R.Size = new System.Drawing.Size(18, 20);
            this.txtJuez2R.TabIndex = 34;
            this.txtJuez2R.Visible = false;
            // 
            // txtJuez3R
            // 
            this.txtJuez3R.BackColor = System.Drawing.Color.Red;
            this.txtJuez3R.Location = new System.Drawing.Point(187, 21);
            this.txtJuez3R.Name = "txtJuez3R";
            this.txtJuez3R.Size = new System.Drawing.Size(18, 20);
            this.txtJuez3R.TabIndex = 35;
            this.txtJuez3R.Visible = false;
            // 
            // txtJuez3A
            // 
            this.txtJuez3A.BackColor = System.Drawing.Color.Blue;
            this.txtJuez3A.Location = new System.Drawing.Point(890, 21);
            this.txtJuez3A.Name = "txtJuez3A";
            this.txtJuez3A.Size = new System.Drawing.Size(18, 20);
            this.txtJuez3A.TabIndex = 38;
            this.txtJuez3A.Visible = false;
            // 
            // txtJuez2A
            // 
            this.txtJuez2A.BackColor = System.Drawing.Color.Blue;
            this.txtJuez2A.Location = new System.Drawing.Point(849, 21);
            this.txtJuez2A.Name = "txtJuez2A";
            this.txtJuez2A.Size = new System.Drawing.Size(18, 20);
            this.txtJuez2A.TabIndex = 37;
            this.txtJuez2A.Visible = false;
            // 
            // txtJuez1A
            // 
            this.txtJuez1A.BackColor = System.Drawing.Color.Blue;
            this.txtJuez1A.Location = new System.Drawing.Point(812, 21);
            this.txtJuez1A.Name = "txtJuez1A";
            this.txtJuez1A.Size = new System.Drawing.Size(18, 20);
            this.txtJuez1A.TabIndex = 36;
            this.txtJuez1A.Visible = false;
            // 
            // pnlGanadorAzul
            // 
            this.pnlGanadorAzul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlGanadorAzul.Controls.Add(this.label8);
            this.pnlGanadorAzul.Location = new System.Drawing.Point(12, 47);
            this.pnlGanadorAzul.Name = "pnlGanadorAzul";
            this.pnlGanadorAzul.Size = new System.Drawing.Size(697, 327);
            this.pnlGanadorAzul.TabIndex = 39;
            this.pnlGanadorAzul.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 108);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ganador";
            // 
            // pnlGanadorRojo
            // 
            this.pnlGanadorRojo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlGanadorRojo.Controls.Add(this.label7);
            this.pnlGanadorRojo.Location = new System.Drawing.Point(321, 47);
            this.pnlGanadorRojo.Name = "pnlGanadorRojo";
            this.pnlGanadorRojo.Size = new System.Drawing.Size(697, 327);
            this.pnlGanadorRojo.TabIndex = 40;
            this.pnlGanadorRojo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(417, 108);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ganador";
            // 
            // btnTiempoMenos
            // 
            this.btnTiempoMenos.Location = new System.Drawing.Point(432, 24);
            this.btnTiempoMenos.Name = "btnTiempoMenos";
            this.btnTiempoMenos.Size = new System.Drawing.Size(23, 23);
            this.btnTiempoMenos.TabIndex = 41;
            this.btnTiempoMenos.Text = "-";
            this.btnTiempoMenos.UseVisualStyleBackColor = true;
            this.btnTiempoMenos.Click += new System.EventHandler(this.btnTiempoMenos_Click);
            // 
            // btnTiempoMas
            // 
            this.btnTiempoMas.Location = new System.Drawing.Point(465, 24);
            this.btnTiempoMas.Name = "btnTiempoMas";
            this.btnTiempoMas.Size = new System.Drawing.Size(23, 23);
            this.btnTiempoMas.TabIndex = 42;
            this.btnTiempoMas.Text = "+";
            this.btnTiempoMas.UseVisualStyleBackColor = true;
            this.btnTiempoMas.Click += new System.EventHandler(this.btnTiempoMas_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(634, 402);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 43;
            this.btnMedico.Text = "Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // frmCombate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 522);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.pnlGanadorAzul);
            this.Controls.Add(this.pnlGanadorRojo);
            this.Controls.Add(this.btnTiempoMas);
            this.Controls.Add(this.btnTiempoMenos);
            this.Controls.Add(this.txtJuez3A);
            this.Controls.Add(this.txtJuez2A);
            this.Controls.Add(this.txtJuez1A);
            this.Controls.Add(this.txtJuez3R);
            this.Controls.Add(this.txtJuez2R);
            this.Controls.Add(this.txtJuez1R);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitaKiongoA);
            this.Controls.Add(this.btnQuitaPuntoA);
            this.Controls.Add(this.btnQuitaKiongoR);
            this.Controls.Add(this.btnQuitaPuntoR);
            this.Controls.Add(this.btnTiempoMedico);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtCronometro);
            this.Controls.Add(this.btnKiongoAzul);
            this.Controls.Add(this.btnKiongoRojo);
            this.Controls.Add(this.txtChongKiongo4);
            this.Controls.Add(this.txtChongKiongo3);
            this.Controls.Add(this.txtChongKiongo2);
            this.Controls.Add(this.txtChongKiongo5);
            this.Controls.Add(this.txtChongKiongo1);
            this.Controls.Add(this.txtHongKiongo4);
            this.Controls.Add(this.txtHongKiongo3);
            this.Controls.Add(this.txtHongKiongo2);
            this.Controls.Add(this.txtHongKiongo5);
            this.Controls.Add(this.txtHongKiongo1);
            this.Controls.Add(this.btnPuntoAzul);
            this.Controls.Add(this.btnPuntoRojo);
            this.Controls.Add(this.Detener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtChong);
            this.Controls.Add(this.txtHong);
            this.Name = "frmCombate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Kyorugui";
            this.Activated += new System.EventHandler(this.frmCombate_Activated);
            this.Deactivate += new System.EventHandler(this.frmCombate_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCombate_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCombate_KeyPress);
            this.pnlGanadorAzul.ResumeLayout(false);
            this.pnlGanadorAzul.PerformLayout();
            this.pnlGanadorRojo.ResumeLayout(false);
            this.pnlGanadorRojo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPuntoRojo;
        private System.Windows.Forms.Button btnPuntoAzul;
        private System.Windows.Forms.TextBox txtHong;
        private System.Windows.Forms.TextBox txtChong;
        private System.Windows.Forms.TextBox txtHongKiongo1;
        private System.Windows.Forms.TextBox txtHongKiongo5;
        private System.Windows.Forms.TextBox txtHongKiongo2;
        private System.Windows.Forms.TextBox txtHongKiongo3;
        private System.Windows.Forms.TextBox txtHongKiongo4;
        private System.Windows.Forms.TextBox txtChongKiongo4;
        private System.Windows.Forms.TextBox txtChongKiongo3;
        private System.Windows.Forms.TextBox txtChongKiongo2;
        private System.Windows.Forms.TextBox txtChongKiongo5;
        private System.Windows.Forms.TextBox txtChongKiongo1;
        private System.Windows.Forms.Button btnKiongoRojo;
        private System.Windows.Forms.Button btnKiongoAzul;
        private System.Windows.Forms.TextBox txtCronometro;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button Detener;
        private System.Windows.Forms.Button btnTiempoMedico;
        private System.Windows.Forms.Timer tmrRound;
        private System.Windows.Forms.Button btnQuitaKiongoR;
        private System.Windows.Forms.Button btnQuitaPuntoR;
        private System.Windows.Forms.Button btnQuitaKiongoA;
        private System.Windows.Forms.Button btnQuitaPuntoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJuez1R;
        private System.Windows.Forms.TextBox txtJuez2R;
        private System.Windows.Forms.TextBox txtJuez3R;
        private System.Windows.Forms.TextBox txtJuez3A;
        private System.Windows.Forms.TextBox txtJuez2A;
        private System.Windows.Forms.TextBox txtJuez1A;
        private System.Windows.Forms.Panel pnlGanadorAzul;
        private System.Windows.Forms.Panel pnlGanadorRojo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTiempoMenos;
        private System.Windows.Forms.Button btnTiempoMas;
        private System.Windows.Forms.Button btnMedico;
    }
}

