
namespace htooncase2
{
    partial class Form3
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelName = new System.Windows.Forms.Button();
            this.bDelNum = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.bDelAdr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.bDelVib = new System.Windows.Forms.Button();
            this.lBox = new System.Windows.Forms.ListBox();
            this.bDelTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bAdd.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bAdd.Location = new System.Drawing.Point(438, 286);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(87, 58);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelName
            // 
            this.bDelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bDelName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bDelName.Location = new System.Drawing.Point(563, 286);
            this.bDelName.Name = "bDelName";
            this.bDelName.Size = new System.Drawing.Size(87, 58);
            this.bDelName.TabIndex = 2;
            this.bDelName.Text = "Удалить Ф.И.О";
            this.bDelName.UseVisualStyleBackColor = false;
            this.bDelName.Click += new System.EventHandler(this.bDelName_Click);
            // 
            // bDelNum
            // 
            this.bDelNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bDelNum.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDelNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bDelNum.Location = new System.Drawing.Point(438, 375);
            this.bDelNum.Name = "bDelNum";
            this.bDelNum.Size = new System.Drawing.Size(87, 58);
            this.bDelNum.TabIndex = 3;
            this.bDelNum.Text = "Удалить  номер";
            this.bDelNum.UseVisualStyleBackColor = false;
            this.bDelNum.Click += new System.EventHandler(this.bDelNum_Click);
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bReset.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bReset.Location = new System.Drawing.Point(30, 121);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(104, 46);
            this.bReset.TabIndex = 4;
            this.bReset.Text = "Удалить всё";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Записная книжка";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(48, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ф.И.О";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(48, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 321);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(173, 365);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 23);
            this.txtNum.TabIndex = 10;
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // bDelAdr
            // 
            this.bDelAdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bDelAdr.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDelAdr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bDelAdr.Location = new System.Drawing.Point(563, 375);
            this.bDelAdr.Name = "bDelAdr";
            this.bDelAdr.Size = new System.Drawing.Size(87, 58);
            this.bDelAdr.TabIndex = 11;
            this.bDelAdr.Text = "Удалить адрес";
            this.bDelAdr.UseVisualStyleBackColor = false;
            this.bDelAdr.Click += new System.EventHandler(this.bDelAdr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(48, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Адрес";
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(173, 410);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(100, 23);
            this.txtAdr.TabIndex = 13;
            this.txtAdr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdr_KeyDown);
            this.txtAdr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdr_KeyPress);
            // 
            // bDelVib
            // 
            this.bDelVib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bDelVib.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDelVib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bDelVib.Location = new System.Drawing.Point(30, 182);
            this.bDelVib.Name = "bDelVib";
            this.bDelVib.Size = new System.Drawing.Size(104, 48);
            this.bDelVib.TabIndex = 14;
            this.bDelVib.Text = "Удалить выбранное";
            this.bDelVib.UseVisualStyleBackColor = false;
            this.bDelVib.Click += new System.EventHandler(this.bDelVib_Click);
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 15;
            this.lBox.Location = new System.Drawing.Point(164, 76);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(509, 184);
            this.lBox.TabIndex = 15;
            // 
            // bDelTxt
            // 
            this.bDelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bDelTxt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bDelTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bDelTxt.Location = new System.Drawing.Point(680, 330);
            this.bDelTxt.Name = "bDelTxt";
            this.bDelTxt.Size = new System.Drawing.Size(87, 58);
            this.bDelTxt.TabIndex = 16;
            this.bDelTxt.Text = "Удалить данные ввода";
            this.bDelTxt.UseVisualStyleBackColor = false;
            this.bDelTxt.Click += new System.EventHandler(this.bDelTxt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.bDelTxt);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.bDelVib);
            this.Controls.Add(this.txtAdr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bDelAdr);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bDelNum);
            this.Controls.Add(this.bDelName);
            this.Controls.Add(this.bAdd);
            this.Name = "Form3";
            this.Text = "записная книжка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelName;
        private System.Windows.Forms.Button bDelNum;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button bDelAdr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.Button bDelVib;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Button bDelTxt;
    }
}