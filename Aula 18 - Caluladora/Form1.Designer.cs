﻿namespace Aula_18___Caluladora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btsoma = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btresult = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.MaskedTextBox();
            this.txthistorico = new System.Windows.Forms.MaskedTextBox();
            this.btapagar = new System.Windows.Forms.Button();
            this.btponto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnegativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(37, 127);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(67, 28);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(107, 127);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(67, 28);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(177, 127);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(67, 28);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btsoma
            // 
            this.btsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsoma.Location = new System.Drawing.Point(247, 251);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(67, 28);
            this.btsoma.TabIndex = 4;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.operadores);
            // 
            // btsub
            // 
            this.btsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsub.Location = new System.Drawing.Point(247, 220);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(67, 28);
            this.btsub.TabIndex = 8;
            this.btsub.Text = "-";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(177, 158);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(67, 28);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(107, 158);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(67, 28);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(37, 158);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(67, 28);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btdiv
            // 
            this.btdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiv.Location = new System.Drawing.Point(247, 158);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(67, 28);
            this.btdiv.TabIndex = 12;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.operadores);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(177, 189);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(67, 28);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(107, 189);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(67, 28);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(37, 189);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(67, 28);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btmult
            // 
            this.btmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmult.Location = new System.Drawing.Point(247, 189);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(67, 28);
            this.btmult.TabIndex = 16;
            this.btmult.Text = "x";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.operadores);
            // 
            // btresult
            // 
            this.btresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btresult.Location = new System.Drawing.Point(177, 251);
            this.btresult.Name = "btresult";
            this.btresult.Size = new System.Drawing.Size(67, 28);
            this.btresult.TabIndex = 15;
            this.btresult.Text = "=";
            this.btresult.UseVisualStyleBackColor = true;
            this.btresult.Click += new System.EventHandler(this.btresult_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(107, 220);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(67, 28);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(37, 251);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(67, 28);
            this.btlimpar.TabIndex = 13;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtresult.Location = new System.Drawing.Point(37, 64);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(277, 29);
            this.txtresult.TabIndex = 17;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txthistorico
            // 
            this.txthistorico.Enabled = false;
            this.txthistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistorico.Location = new System.Drawing.Point(37, 39);
            this.txthistorico.Name = "txthistorico";
            this.txthistorico.Size = new System.Drawing.Size(277, 26);
            this.txthistorico.TabIndex = 18;
            this.txthistorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btapagar
            // 
            this.btapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btapagar.Location = new System.Drawing.Point(247, 127);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(67, 28);
            this.btapagar.TabIndex = 22;
            this.btapagar.Text = "←";
            this.btapagar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btapagar.UseVisualStyleBackColor = true;
            // 
            // btponto
            // 
            this.btponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btponto.Location = new System.Drawing.Point(177, 220);
            this.btponto.Name = "btponto";
            this.btponto.Size = new System.Drawing.Size(67, 28);
            this.btponto.TabIndex = 21;
            this.btponto.Text = ",";
            this.btponto.UseVisualStyleBackColor = true;
            this.btponto.Click += new System.EventHandler(this.gerarnumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(107, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "mod";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operadores);
            // 
            // btnegativo
            // 
            this.btnegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnegativo.Location = new System.Drawing.Point(37, 220);
            this.btnegativo.Name = "btnegativo";
            this.btnegativo.Size = new System.Drawing.Size(67, 28);
            this.btnegativo.TabIndex = 19;
            this.btnegativo.Text = "+/-";
            this.btnegativo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 338);
            this.Controls.Add(this.btapagar);
            this.Controls.Add(this.btponto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnegativo);
            this.Controls.Add(this.txthistorico);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btresult);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btsub;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btresult;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.MaskedTextBox txtresult;
        private System.Windows.Forms.MaskedTextBox txthistorico;
        private System.Windows.Forms.Button btapagar;
        private System.Windows.Forms.Button btponto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnegativo;
    }
}

