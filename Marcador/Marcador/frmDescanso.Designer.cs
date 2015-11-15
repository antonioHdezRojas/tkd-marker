namespace Marcador
{
    partial class frmDescanso
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
            this.txtCronometro = new System.Windows.Forms.TextBox();
            this.tmrDescanso = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtCronometro
            // 
            this.txtCronometro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCronometro.CausesValidation = false;
            this.txtCronometro.Enabled = false;
            this.txtCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCronometro.ForeColor = System.Drawing.Color.Black;
            this.txtCronometro.Location = new System.Drawing.Point(50, 35);
            this.txtCronometro.Multiline = true;
            this.txtCronometro.Name = "txtCronometro";
            this.txtCronometro.Size = new System.Drawing.Size(492, 243);
            this.txtCronometro.TabIndex = 19;
            this.txtCronometro.TabStop = false;
            this.txtCronometro.Text = "3:00";
            this.txtCronometro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrDescanso
            // 
            this.tmrDescanso.Interval = 1000;
            this.tmrDescanso.Tick += new System.EventHandler(this.tmrDescanso_Tick);
            // 
            // frmDescanso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 352);
            this.Controls.Add(this.txtCronometro);
            this.Name = "frmDescanso";
            this.Load += new System.EventHandler(this.frmDescanso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCronometro;
        private System.Windows.Forms.Timer tmrDescanso;
    }
}