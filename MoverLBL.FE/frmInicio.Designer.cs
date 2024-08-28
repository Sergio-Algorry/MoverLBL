namespace MoverLBL.FE
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
            this.btInicio = new System.Windows.Forms.Button();
            this.lblCubo = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btInicio
            // 
            this.btInicio.Location = new System.Drawing.Point(224, 136);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(75, 23);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "Inicio";
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // lblCubo
            // 
            this.lblCubo.BackColor = System.Drawing.Color.Red;
            this.lblCubo.Location = new System.Drawing.Point(21, 181);
            this.lblCubo.Name = "lblCubo";
            this.lblCubo.Size = new System.Drawing.Size(20, 20);
            this.lblCubo.TabIndex = 1;
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(12, 136);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(100, 20);
            this.txt_X.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y Inicio";
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(118, 136);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(100, 20);
            this.txt_Y.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.lblCubo);
            this.Controls.Add(this.btInicio);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Label lblCubo;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Y;
    }
}