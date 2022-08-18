
namespace htooncase2
{
    partial class Form4
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
            this.bQuad = new System.Windows.Forms.Button();
            this.bCor = new System.Windows.Forms.Button();
            this.txtFst = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSnd = new System.Windows.Forms.TextBox();
            this.bPls = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bUmn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bQuad
            // 
            this.bQuad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bQuad.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bQuad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bQuad.Location = new System.Drawing.Point(687, 258);
            this.bQuad.Name = "bQuad";
            this.bQuad.Size = new System.Drawing.Size(95, 89);
            this.bQuad.TabIndex = 0;
            this.bQuad.Text = "Квадрат";
            this.bQuad.UseVisualStyleBackColor = false;
            this.bQuad.Click += new System.EventHandler(this.bClckd);
            // 
            // bCor
            // 
            this.bCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bCor.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bCor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCor.Location = new System.Drawing.Point(687, 134);
            this.bCor.Name = "bCor";
            this.bCor.Size = new System.Drawing.Size(95, 87);
            this.bCor.TabIndex = 1;
            this.bCor.Text = "Корень";
            this.bCor.UseVisualStyleBackColor = false;
            this.bCor.Click += new System.EventHandler(this.bClckd);
            // 
            // txtFst
            // 
            this.txtFst.Location = new System.Drawing.Point(231, 139);
            this.txtFst.Name = "txtFst";
            this.txtFst.Size = new System.Drawing.Size(86, 23);
            this.txtFst.TabIndex = 2;
            this.txtFst.TextChanged += new System.EventHandler(this.txtFst_TextChanged);
            this.txtFst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTxt);
            this.txtFst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTxt);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(48, 293);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 23);
            this.txtRes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Первое число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Onyx", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(183, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дополнительный функционал";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(27, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 26);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Назад";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Второе число";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSnd
            // 
            this.txtSnd.Location = new System.Drawing.Point(231, 200);
            this.txtSnd.Name = "txtSnd";
            this.txtSnd.Size = new System.Drawing.Size(86, 23);
            this.txtSnd.TabIndex = 11;
            this.txtSnd.TextChanged += new System.EventHandler(this.txtSnd_TextChanged);
            this.txtSnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTxt);
            this.txtSnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTxt);
            // 
            // bPls
            // 
            this.bPls.BackColor = System.Drawing.Color.Red;
            this.bPls.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bPls.Location = new System.Drawing.Point(384, 134);
            this.bPls.Name = "bPls";
            this.bPls.Size = new System.Drawing.Size(99, 87);
            this.bPls.TabIndex = 12;
            this.bPls.Text = "+";
            this.bPls.UseVisualStyleBackColor = false;
            this.bPls.Click += new System.EventHandler(this.bClckd);
            // 
            // bMin
            // 
            this.bMin.BackColor = System.Drawing.Color.Red;
            this.bMin.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMin.Location = new System.Drawing.Point(536, 134);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(99, 87);
            this.bMin.TabIndex = 13;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = false;
            this.bMin.Click += new System.EventHandler(this.bClckd);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.Red;
            this.bDel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDel.Location = new System.Drawing.Point(536, 258);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(99, 89);
            this.bDel.TabIndex = 14;
            this.bDel.Text = "/";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bClckd);
            // 
            // bUmn
            // 
            this.bUmn.BackColor = System.Drawing.Color.Red;
            this.bUmn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bUmn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bUmn.Location = new System.Drawing.Point(384, 258);
            this.bUmn.Name = "bUmn";
            this.bUmn.Size = new System.Drawing.Size(99, 89);
            this.bUmn.TabIndex = 15;
            this.bUmn.Text = "*";
            this.bUmn.UseVisualStyleBackColor = false;
            this.bUmn.Click += new System.EventHandler(this.bClckd);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(813, 461);
            this.Controls.Add(this.bUmn);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bPls);
            this.Controls.Add(this.txtSnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtFst);
            this.Controls.Add(this.bCor);
            this.Controls.Add(this.bQuad);
            this.Name = "Form4";
            this.Text = "калькулятор (доп)";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bQuad;
        private System.Windows.Forms.Button bCor;
        private System.Windows.Forms.TextBox txtFst;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSnd;
        private System.Windows.Forms.Button bPls;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bUmn;
    }
}