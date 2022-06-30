using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TekenProgramma;

namespace Gravies
{
    public class CirkelDlg : Form
    {
        public Figuur Generate()
        {
            Cirkel c = new Cirkel();
            c.Positie = new Positie { X = (int)hX.Value, Y = (int)hY.Value };
            c.Straal = (int)hRadius.Value;
            return c;
        }
        public CirkelDlg()
        {
            InitializeComponent();
        }

         private System.ComponentModel.IContainer components = null;

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
            this.hX = new System.Windows.Forms.NumericUpDown();
            this.hY = new System.Windows.Forms.NumericUpDown();
            this.hRadius = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Straal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // hX
            // 
            this.hX.Location = new System.Drawing.Point(102, 19);
            this.hX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hX.Name = "hX";
            this.hX.Size = new System.Drawing.Size(120, 23);
            this.hX.TabIndex = 3;
            // 
            // hY
            // 
            this.hY.Location = new System.Drawing.Point(102, 65);
            this.hY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hY.Name = "hY";
            this.hY.Size = new System.Drawing.Size(120, 23);
            this.hY.TabIndex = 4;
            // 
            // hRadius
            // 
            this.hRadius.Location = new System.Drawing.Point(102, 124);
            this.hRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hRadius.Name = "hRadius";
            this.hRadius.Size = new System.Drawing.Size(120, 23);
            this.hRadius.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(352, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(271, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CirkelDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hRadius);
            this.Controls.Add(this.hY);
            this.Controls.Add(this.hX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CirkelDlg";
            this.Text = "CirkelDlg";
            ((System.ComponentModel.ISupportInitialize)(this.hX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hX;
        private System.Windows.Forms.NumericUpDown hY;
        private System.Windows.Forms.NumericUpDown hRadius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
