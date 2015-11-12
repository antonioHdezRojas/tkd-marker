namespace Marcador
{
    partial class frmInicio
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
            this.btnInicioCombate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updwRouds = new System.Windows.Forms.NumericUpDown();
            this.updwMin = new System.Windows.Forms.NumericUpDown();
            this.updwSeg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updwSegD = new System.Windows.Forms.NumericUpDown();
            this.updwMinD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updwRouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwSegD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwMinD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicioCombate
            // 
            this.btnInicioCombate.Location = new System.Drawing.Point(12, 12);
            this.btnInicioCombate.Name = "btnInicioCombate";
            this.btnInicioCombate.Size = new System.Drawing.Size(75, 48);
            this.btnInicioCombate.TabIndex = 0;
            this.btnInicioCombate.Text = "Iniciar combate";
            this.btnInicioCombate.UseVisualStyleBackColor = true;
            this.btnInicioCombate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rounds por pelea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo por round";
            // 
            // updwRouds
            // 
            this.updwRouds.Location = new System.Drawing.Point(109, 71);
            this.updwRouds.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updwRouds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updwRouds.Name = "updwRouds";
            this.updwRouds.ReadOnly = true;
            this.updwRouds.Size = new System.Drawing.Size(31, 20);
            this.updwRouds.TabIndex = 5;
            this.updwRouds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updwRouds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updwMin
            // 
            this.updwMin.Location = new System.Drawing.Point(32, 127);
            this.updwMin.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.updwMin.Name = "updwMin";
            this.updwMin.ReadOnly = true;
            this.updwMin.Size = new System.Drawing.Size(45, 20);
            this.updwMin.TabIndex = 6;
            this.updwMin.ValueChanged += new System.EventHandler(this.updwMin_ValueChanged);
            // 
            // updwSeg
            // 
            this.updwSeg.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updwSeg.Location = new System.Drawing.Point(109, 127);
            this.updwSeg.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updwSeg.Name = "updwSeg";
            this.updwSeg.ReadOnly = true;
            this.updwSeg.Size = new System.Drawing.Size(42, 20);
            this.updwSeg.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Segundos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Minutos";
            // 
            // updwSegD
            // 
            this.updwSegD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updwSegD.Location = new System.Drawing.Point(109, 216);
            this.updwSegD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.updwSegD.Name = "updwSegD";
            this.updwSegD.ReadOnly = true;
            this.updwSegD.Size = new System.Drawing.Size(42, 20);
            this.updwSegD.TabIndex = 12;
            // 
            // updwMinD
            // 
            this.updwMinD.Location = new System.Drawing.Point(32, 216);
            this.updwMinD.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.updwMinD.Name = "updwMinD";
            this.updwMinD.ReadOnly = true;
            this.updwMinD.Size = new System.Drawing.Size(45, 20);
            this.updwMinD.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiempo descanso";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updwSegD);
            this.Controls.Add(this.updwMinD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updwSeg);
            this.Controls.Add(this.updwMin);
            this.Controls.Add(this.updwRouds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicioCombate);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updwRouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwSegD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updwMinD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicioCombate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updwRouds;
        private System.Windows.Forms.NumericUpDown updwMin;
        private System.Windows.Forms.NumericUpDown updwSeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updwSegD;
        private System.Windows.Forms.NumericUpDown updwMinD;
        private System.Windows.Forms.Label label7;
    }
}