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
    public class TriangleDlg : Form
    {
        private Button button2;
        private Button button1;
        private NumericUpDown txtBasis;
        private NumericUpDown hY;
        private NumericUpDown hX;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown hHoogte;
        private NumericUpDown txtHoek;
        private Label label5;
        private Label label4;

        public Figuur Generate()
        {
            Rechthoek c = new Rechthoek();
            c.Positie = new Positie { X = (int)hX.Value, Y = (int)hY.Value };
            c.Hoogte = (int)hHoogte.Value;
            c.Breedte = (int)txtBasis.Value;
            return c;
        }
        public TriangleDlg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBasis = new System.Windows.Forms.NumericUpDown();
            this.hY = new System.Windows.Forms.NumericUpDown();
            this.hX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hHoogte = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoek = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hHoogte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoek)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(282, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(363, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBasis
            // 
            this.txtBasis.Location = new System.Drawing.Point(99, 117);
            this.txtBasis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtBasis.Name = "txtBasis";
            this.txtBasis.Size = new System.Drawing.Size(120, 23);
            this.txtBasis.TabIndex = 13;
            // 
            // hY
            // 
            this.hY.Location = new System.Drawing.Point(99, 58);
            this.hY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hY.Name = "hY";
            this.hY.Size = new System.Drawing.Size(120, 23);
            this.hY.TabIndex = 12;
            // 
            // hX
            // 
            this.hX.Location = new System.Drawing.Point(99, 12);
            this.hX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hX.Name = "hX";
            this.hX.Size = new System.Drawing.Size(120, 23);
            this.hX.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basis";
            // 
            // hHoogte
            // 
            this.hHoogte.Location = new System.Drawing.Point(99, 156);
            this.hHoogte.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hHoogte.Name = "hHoogte";
            this.hHoogte.Size = new System.Drawing.Size(120, 23);
            this.hHoogte.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hoogte";
            // 
            // txtHoek
            // 
            this.txtHoek.Location = new System.Drawing.Point(99, 199);
            this.txtHoek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtHoek.Name = "txtHoek";
            this.txtHoek.Size = new System.Drawing.Size(120, 23);
            this.txtHoek.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hoek";
            // 
            // TriangleDlg
            // 
            this.ClientSize = new System.Drawing.Size(450, 296);
            this.Controls.Add(this.txtHoek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hHoogte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBasis);
            this.Controls.Add(this.hY);
            this.Controls.Add(this.hX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TriangleDlg";
            this.Text = "TriangleDlg";
            ((System.ComponentModel.ISupportInitialize)(this.txtBasis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hHoogte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
