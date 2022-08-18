
namespace htooncase2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFst = new System.Windows.Forms.TextBox();
            this.txtSnd = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.bPls = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bUmn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Onyx", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = " Первое число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Второе число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Swis721 BdOul BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(95, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Результат";
            // 
            // txtFst
            // 
            this.txtFst.Location = new System.Drawing.Point(238, 162);
            this.txtFst.Name = "txtFst";
            this.txtFst.Size = new System.Drawing.Size(100, 23);
            this.txtFst.TabIndex = 4;
            this.txtFst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTxt);
            this.txtFst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTxt);
            // 
            // txtSnd
            // 
            this.txtSnd.Location = new System.Drawing.Point(238, 214);
            this.txtSnd.Name = "txtSnd";
            this.txtSnd.Size = new System.Drawing.Size(100, 23);
            this.txtSnd.TabIndex = 5;
            this.txtSnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownTxt);
            this.txtSnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTxt);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(106, 331);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(110, 23);
            this.txtRes.TabIndex = 6;
            this.txtRes.TextChanged += new System.EventHandler(this.txtRes_TextChanged);
            // 
            // bPls
            // 
            this.bPls.BackColor = System.Drawing.Color.Red;
            this.bPls.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPls.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bPls.Location = new System.Drawing.Point(512, 129);
            this.bPls.Name = "bPls";
            this.bPls.Size = new System.Drawing.Size(93, 91);
            this.bPls.TabIndex = 7;
            this.bPls.Text = "+";
            this.bPls.UseVisualStyleBackColor = false;
            this.bPls.Click += new System.EventHandler(this.bClckd);
            // 
            // bMin
            // 
            this.bMin.BackColor = System.Drawing.Color.Red;
            this.bMin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMin.Location = new System.Drawing.Point(645, 129);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(95, 91);
            this.bMin.TabIndex = 8;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = false;
            this.bMin.Click += new System.EventHandler(this.bClckd);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.Red;
            this.bDel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDel.Location = new System.Drawing.Point(645, 265);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(95, 89);
            this.bDel.TabIndex = 9;
            this.bDel.Text = "/";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bClckd);
            // 
            // bUmn
            // 
            this.bUmn.BackColor = System.Drawing.Color.Red;
            this.bUmn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bUmn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bUmn.Location = new System.Drawing.Point(512, 265);
            this.bUmn.Name = "bUmn";
            this.bUmn.Size = new System.Drawing.Size(93, 89);
            this.bUmn.TabIndex = 10;
            this.bUmn.Text = "*";
            this.bUmn.UseVisualStyleBackColor = false;
            this.bUmn.Click += new System.EventHandler(this.bClckd);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(729, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 21);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Доп. Функционал";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(887, 448);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bUmn);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bPls);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtSnd);
            this.Controls.Add(this.txtFst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "калькулятор (основной)";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFst;
        private System.Windows.Forms.TextBox txtSnd;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button bPls;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bUmn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}