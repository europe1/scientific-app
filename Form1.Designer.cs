namespace Calculus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMv = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbT = new System.Windows.Forms.TextBox();
            this.tbphi2 = new System.Windows.Forms.TextBox();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.tbphi1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.tableValues = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbT0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "PDF Files|*.pdf|All files|*.*";
            // 
            // tableHeader
            // 
            this.tableHeader.ColumnCount = 10;
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableHeader.Location = new System.Drawing.Point(12, 130);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.RowCount = 1;
            this.tableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHeader.Size = new System.Drawing.Size(760, 25);
            this.tableHeader.TabIndex = 20;
            this.tableHeader.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Масса сухого материала, гр:";
            // 
            // tbMs
            // 
            this.tbMs.BackColor = System.Drawing.SystemColors.Control;
            this.tbMs.Location = new System.Drawing.Point(191, 12);
            this.tbMs.Name = "tbMs";
            this.tbMs.Size = new System.Drawing.Size(100, 20);
            this.tbMs.TabIndex = 0;
            this.tbMs.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Масса влажного материала, гр:";
            // 
            // tbMv
            // 
            this.tbMv.BackColor = System.Drawing.SystemColors.Control;
            this.tbMv.Location = new System.Drawing.Point(191, 38);
            this.tbMv.Name = "tbMv";
            this.tbMv.Size = new System.Drawing.Size(100, 20);
            this.tbMv.TabIndex = 1;
            this.tbMv.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // tbH
            // 
            this.tbH.BackColor = System.Drawing.SystemColors.Control;
            this.tbH.Location = new System.Drawing.Point(191, 64);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 20);
            this.tbH.TabIndex = 2;
            this.tbH.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Высота слоя, мм:";
            // 
            // tbV
            // 
            this.tbV.BackColor = System.Drawing.SystemColors.Control;
            this.tbV.Location = new System.Drawing.Point(191, 90);
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(100, 20);
            this.tbV.TabIndex = 3;
            this.tbV.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Объёмный расход воздуха, м³/ч:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "τ, мин.";
            // 
            // tbT
            // 
            this.tbT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbT.BackColor = System.Drawing.SystemColors.Control;
            this.tbT.Location = new System.Drawing.Point(672, 12);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(100, 20);
            this.tbT.TabIndex = 8;
            this.tbT.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // tbphi2
            // 
            this.tbphi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbphi2.BackColor = System.Drawing.SystemColors.Control;
            this.tbphi2.Location = new System.Drawing.Point(494, 90);
            this.tbphi2.Name = "tbphi2";
            this.tbphi2.Size = new System.Drawing.Size(100, 20);
            this.tbphi2.TabIndex = 7;
            this.tbphi2.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // tbt1
            // 
            this.tbt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbt1.BackColor = System.Drawing.SystemColors.Control;
            this.tbt1.Location = new System.Drawing.Point(494, 12);
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(100, 20);
            this.tbt1.TabIndex = 4;
            this.tbt1.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // tbphi1
            // 
            this.tbphi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbphi1.BackColor = System.Drawing.SystemColors.Control;
            this.tbphi1.Location = new System.Drawing.Point(494, 38);
            this.tbphi1.Name = "tbphi1";
            this.tbphi1.Size = new System.Drawing.Size(100, 20);
            this.tbphi1.TabIndex = 5;
            this.tbphi1.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "t1, °C";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "φ1, %";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "t2, °C";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "φ2, %";
            // 
            // tbt2
            // 
            this.tbt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbt2.BackColor = System.Drawing.SystemColors.Control;
            this.tbt2.Location = new System.Drawing.Point(494, 64);
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(100, 20);
            this.tbt2.TabIndex = 6;
            this.tbt2.TextChanged += new System.EventHandler(this.tbMs_TextChanged);
            // 
            // tableValues
            // 
            this.tableValues.AutoScroll = true;
            this.tableValues.AutoSize = true;
            this.tableValues.ColumnCount = 10;
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableValues.Location = new System.Drawing.Point(12, 155);
            this.tableValues.Name = "tableValues";
            this.tableValues.RowCount = 1;
            this.tableValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableValues.Size = new System.Drawing.Size(760, 25);
            this.tableValues.TabIndex = 21;
            this.tableValues.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(627, 80);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 30);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Calculus.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(742, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Image = global::Calculus.Properties.Resources.arrow_undo;
            this.btnUndo.Location = new System.Drawing.Point(742, 80);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(0, 30);
            this.btnUndo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnUndo, "Отмена");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // tbT0
            // 
            this.tbT0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbT0.Location = new System.Drawing.Point(681, 525);
            this.tbT0.Name = "tbT0";
            this.tbT0.Size = new System.Drawing.Size(55, 20);
            this.tbT0.TabIndex = 23;
            this.tbT0.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "t0, °C:";
            this.label10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbT0);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tableValues);
            this.Controls.Add(this.tbt2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbphi1);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.tbphi2);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbMv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 160);
            this.Name = "Form1";
            this.Text = "Скорость сушки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMv;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.TextBox tbphi2;
        private System.Windows.Forms.TextBox tbt1;
        private System.Windows.Forms.TextBox tbphi1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.TableLayoutPanel tableValues;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbT0;
        private System.Windows.Forms.Label label10;
    }
}

