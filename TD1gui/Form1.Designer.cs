
using System;

namespace ESIEE_Visual_Studio
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
        
        // Addition
        private void addresult_Click(object sender, EventArgs e)
        {
            AdditionView.result_Click(this.number1, this.number2, this.result, this.errors);
        }

        private void addinit_Click(object sender, EventArgs e)
        {
            AdditionView.init_Click(this.number1, this.number2, this.result, this.errors);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errors = new System.Windows.Forms.Label();
            this.initbutton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errors);
            this.tabPage1.Controls.Add(this.initbutton);
            this.tabPage1.Controls.Add(this.result);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.addbutton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.number2);
            this.tabPage1.Controls.Add(this.number1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Addition";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errors
            // 
            this.errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.errors.Location = new System.Drawing.Point(12, 194);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(346, 64);
            this.errors.TabIndex = 10;
            this.errors.Text = "Erreurs :\r\n";
            // 
            // initbutton
            // 
            this.initbutton.Location = new System.Drawing.Point(537, 141);
            this.initbutton.Name = "initbutton";
            this.initbutton.Size = new System.Drawing.Size(144, 40);
            this.initbutton.TabIndex = 9;
            this.initbutton.Text = "Réinitialiser";
            this.initbutton.UseVisualStyleBackColor = true;
            this.initbutton.Click += new System.EventHandler(this.addinit_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(117, 150);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(71, 31);
            this.result.TabIndex = 8;
            this.result.Text = "-";
            this.result.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Résultat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(537, 76);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(144, 37);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Additionner";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addresult_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(284, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Entier 2 :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entier 1 :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(231, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(284, 87);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(213, 26);
            this.number2.TabIndex = 2;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 87);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(213, 26);
            this.number1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez deux nombres entiers pour les additionner :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label errors;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button initbutton;

        private System.Windows.Forms.Label result;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button addbutton;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox number1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}