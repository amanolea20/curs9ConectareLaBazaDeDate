
namespace curs9ConectareLaBazaDeDate
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
            this.butonConectare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtJud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butonConectare
            // 
            this.butonConectare.BackColor = System.Drawing.Color.Yellow;
            this.butonConectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonConectare.ForeColor = System.Drawing.Color.Red;
            this.butonConectare.Location = new System.Drawing.Point(636, 387);
            this.butonConectare.Name = "butonConectare";
            this.butonConectare.Size = new System.Drawing.Size(203, 94);
            this.butonConectare.TabIndex = 0;
            this.butonConectare.Text = "Conectare la BD";
            this.butonConectare.UseVisualStyleBackColor = false;
            this.butonConectare.Click += new System.EventHandler(this.butonConectare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod localitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Localitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Judet";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(357, 64);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(236, 38);
            this.txtCod.TabIndex = 4;
            // 
            // txtLoc
            // 
            this.txtLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.Location = new System.Drawing.Point(357, 131);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(236, 38);
            this.txtLoc.TabIndex = 5;
            // 
            // txtJud
            // 
            this.txtJud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJud.Location = new System.Drawing.Point(357, 199);
            this.txtJud.Name = "txtJud";
            this.txtJud.Size = new System.Drawing.Size(236, 38);
            this.txtJud.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 538);
            this.Controls.Add(this.txtJud);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonConectare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonConectare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtJud;
    }
}

