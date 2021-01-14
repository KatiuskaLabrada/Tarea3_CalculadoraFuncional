namespace Tarea3_Calculadora
{
    partial class Calculadora
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
            this.labelVal1 = new System.Windows.Forms.Label();
            this.labelVal2 = new System.Windows.Forms.Label();
            this.labelResul = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelMul = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelDiv = new System.Windows.Forms.Label();
            this.val1 = new System.Windows.Forms.TextBox();
            this.val2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.TextBox();
            this.rest = new System.Windows.Forms.TextBox();
            this.mult = new System.Windows.Forms.TextBox();
            this.div = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVal1
            // 
            this.labelVal1.AutoSize = true;
            this.labelVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVal1.Location = new System.Drawing.Point(103, 110);
            this.labelVal1.Name = "labelVal1";
            this.labelVal1.Size = new System.Drawing.Size(157, 16);
            this.labelVal1.TabIndex = 0;
            this.labelVal1.Text = "Digite el primer valor:";
            // 
            // labelVal2
            // 
            this.labelVal2.AutoSize = true;
            this.labelVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVal2.Location = new System.Drawing.Point(103, 151);
            this.labelVal2.Name = "labelVal2";
            this.labelVal2.Size = new System.Drawing.Size(173, 16);
            this.labelVal2.TabIndex = 1;
            this.labelVal2.Text = "Digite el segundo valor:";
            // 
            // labelResul
            // 
            this.labelResul.AutoSize = true;
            this.labelResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResul.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelResul.Location = new System.Drawing.Point(133, 212);
            this.labelResul.Name = "labelResul";
            this.labelResul.Size = new System.Drawing.Size(116, 16);
            this.labelResul.TabIndex = 2;
            this.labelResul.Text = "El resultado es:";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRes.Location = new System.Drawing.Point(257, 241);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(49, 16);
            this.labelRes.TabIndex = 3;
            this.labelRes.Text = "Resta";
            // 
            // labelMul
            // 
            this.labelMul.AutoSize = true;
            this.labelMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMul.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMul.Location = new System.Drawing.Point(46, 316);
            this.labelMul.Name = "labelMul";
            this.labelMul.Size = new System.Drawing.Size(103, 16);
            this.labelMul.TabIndex = 4;
            this.labelMul.Text = "Multiplicación";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSum.Location = new System.Drawing.Point(69, 241);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(47, 16);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Suma";
            // 
            // labelDiv
            // 
            this.labelDiv.AutoSize = true;
            this.labelDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDiv.Location = new System.Drawing.Point(257, 316);
            this.labelDiv.Name = "labelDiv";
            this.labelDiv.Size = new System.Drawing.Size(64, 16);
            this.labelDiv.TabIndex = 6;
            this.labelDiv.Text = "División";
            // 
            // val1
            // 
            this.val1.Location = new System.Drawing.Point(282, 106);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(97, 20);
            this.val1.TabIndex = 7;
            // 
            // val2
            // 
            this.val2.Location = new System.Drawing.Point(282, 147);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(97, 20);
            this.val2.TabIndex = 8;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(49, 267);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(93, 20);
            this.sum.TabIndex = 9;
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(242, 267);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(93, 20);
            this.rest.TabIndex = 10;
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(49, 344);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(93, 20);
            this.mult.TabIndex = 11;
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(242, 344);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(93, 20);
            this.div.TabIndex = 12;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(450, 151);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 25);
            this.clear.TabIndex = 13;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(450, 212);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(91, 25);
            this.calculate.TabIndex = 14;
            this.calculate.Text = "Calcular";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(450, 267);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 25);
            this.exit.TabIndex = 15;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.calculate);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.div);
            this.panel1.Controls.Add(this.mult);
            this.panel1.Controls.Add(this.rest);
            this.panel1.Controls.Add(this.sum);
            this.panel1.Controls.Add(this.val2);
            this.panel1.Controls.Add(this.val1);
            this.panel1.Controls.Add(this.labelDiv);
            this.panel1.Controls.Add(this.labelSum);
            this.panel1.Controls.Add(this.labelMul);
            this.panel1.Controls.Add(this.labelRes);
            this.panel1.Controls.Add(this.labelResul);
            this.panel1.Controls.Add(this.labelVal2);
            this.panel1.Controls.Add(this.labelVal1);
            this.panel1.Location = new System.Drawing.Point(112, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 401);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea2_Calculadora.Properties.Resources.calculator;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "CALCULADORA BASICA";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVal1;
        private System.Windows.Forms.Label labelVal2;
        private System.Windows.Forms.Label labelResul;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelMul;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelDiv;
        private System.Windows.Forms.TextBox val1;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.TextBox rest;
        private System.Windows.Forms.TextBox mult;
        private System.Windows.Forms.TextBox div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

