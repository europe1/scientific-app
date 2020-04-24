using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using MigraDoc.Rendering;
using System;

namespace Calculus
{
    public partial class Form1 : Form
    {
        int i = 1;
        double sumW = 0;
        double lastAddedW;
        List<double> prevT = new List<double>();
        List<double> prevU = new List<double>();

        ExportDocument document;
        double docU0;
        string docH;
        string docMs;
        string docMv;
        string docV;

        public Form1()
        {
            InitializeComponent();

            tableHeader.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableValues.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableValues.RowStyles.Clear();
            tableValues.RowCount = 0;

            prevT.Add(0);

            document = new ExportDocument();

            GenerateHeaders();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                return;
            }

            tableHeader.Visible = false;
            tableValues.Visible = false;

            tableValues.Left = 7;
            tableHeader.Width = Width - 28;
            tableHeader.Left = tableValues.Left;

            int maxHeight = Height - 86 - tableValues.Top;
            tableValues.MaximumSize = new Size(Width - 28, maxHeight);

            if (!btnSave.Visible)
            {
                btnSave.Visible = true;
                label10.Visible = true;
                tbT0.Visible = true;
                btnCalculate.Width -= 30 + DefaultMargin.Right;
                btnCalculate.Text = "Продолжить";
                btnUndo.Width = 30;

                tbMv.Enabled = false;
                tbMs.Enabled = false;
                tbH.Enabled = false;
                tbV.Enabled = false;

                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
            }

            docH = tbH.Text;
            docV = tbV.Text;
            docMs = tbMs.Text;
            docMv = tbMv.Text;

            double T = double.Parse(tbT.Text);
            double V = double.Parse(tbV.Text);
            double H = double.Parse(tbH.Text) * 0.001;
            double t1 = double.Parse(tbt1.Text);
            double t2 = double.Parse(tbt2.Text);
            double phi1 = double.Parse(tbphi1.Text) * 0.01;
            double phi2 = double.Parse(tbphi2.Text) * 0.01;
            double Mv = double.Parse(tbMv.Text) * 0.001;
            double Ms = double.Parse(tbMs.Text) * 0.001;

            double G = CalcG(V);
            double Vs = CalcVs(H);
            double Pn1 = CalcPn(t1);
            double Pn2 = CalcPn(t2);
            double x1 = CalcX(phi1, Pn1);
            double x2 = CalcX(phi2, Pn2);
            double Wl = CalcWl(G, x1, x2);
            double deltaT = (T - prevT[prevT.Count - 1]) * 60;
            double W = CalcW(Wl, deltaT);
            sumW += W;
            lastAddedW = W;
            double u = CalcU(Mv, Ms, sumW) - 1;

            double deltaU;
            if (prevU.Count == 0)
            {
                double u0 = (Mv - Ms) / Ms;
                docU0 = u0;
                deltaU = u0 - u;
            } else
            {
                deltaU = prevU[prevU.Count - 1] - u;
            }

            double N = deltaU / deltaT;
            double I1 = CalcI(x1, t1);
            double I2 = CalcI(x2, t2);
            double x1nas = CalcXnas(I1);
            double x2nas = CalcXnas(I2);
            double deltaX1 = x1nas - x1;
            double deltaX2 = x2nas - x2;

            double deltaXl = Math.Max(deltaX1, deltaX2);
            double deltaXs = Math.Min(deltaX1, deltaX2);
            double deltaXavg = CalcXavg(deltaXl, deltaXs);
            double Bv = CalcBv(N, Ms, Vs, deltaXavg);

            prevU.Add(u);
            prevT.Add(T);

            AddValues(i++, T, t1, phi1, t2, phi2, W, u, N, Bv);

            tableHeader.Visible = true;
            tableValues.Visible = true;
        }

        private double CalcG(double v)
        {
            return v / 3600 * 1.2;
        }

        private double CalcVs(double h)
        {
            return 0.0032 * h;
        }

        private double CalcPn(double t)
        {
            return 0.0139 - 0.0006447 * t + 0.00005501 * t * t - 0.0000005527 * t * t * t + 0.00000001068 * t * t * t * t;
        }

        private double CalcX(double phi, double pn)
        {
            return 0.622 * (phi * pn / (1 - phi * pn));
        }

        private double CalcWl(double g, double x1, double x2)
        {
            return g * (x2 - x1);
        }

        private double CalcW(double w, double t)
        {
            return w * t;
        }

        double CalcU(double mv, double ms, double sumw)
        {

            return (mv - sumw) / ms;
        }

        double CalcI(double x, double t)
        {
            return (1.01 + 1.97 * x) * t + 2493 * x;
        }

        double CalcXnas(double i)
        {
            return 0.001355 + 0.000205 * i + 0.000000595 * i * i;
        }

        double CalcBv(double n, double ms, double vs, double deltax)
        {
            return n * ms / (vs * deltax);
        }

        private double CalcXavg(double dxl, double dxs)
        {
            return (dxl - dxs) / Math.Log(Math.Abs(dxl / dxs), Math.E);
        }

        private bool CheckFields()
        {
            bool ok = true;
            Control[] fields = { tbMs, tbMv, tbH, tbphi1, tbphi2, tbT, tbt1, tbt2, tbV };

            foreach (Control field in fields)
            {
                if (!double.TryParse(field.Text, out double d))
                {
                    field.BackColor = Color.Pink;
                    ok = false;
                }

                if (field.Name == tbT.Name && tbT.Text == prevT[prevT.Count - 1].ToString())
                {
                    field.BackColor = Color.Pink;
                    ok = false;
                }
            }

            return ok;
        }

        private void AddValues(int row, double T, double x1, double phi1, double x2, double phi2,
            double W, double u, double N, double Bv)
        {
            tableValues.Visible = false;

            tableValues.RowCount++;

            Label text = new Label()
            {
                Text = row.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = T.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = x1.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = phi1.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = x2.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = phi2.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = W.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = u.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = N == double.NaN ? "-" : N.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            text = new Label()
            {
                Text = Bv == double.NaN ? "-" : Bv.ToString(),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableValues.Controls.Add(text);

            tableValues.Visible = true;

            document.LoadVars(new double[] { row, T, x1, phi1, x2, phi2, W, u, N, Bv });
        }

        private void GenerateHeaders()
        {
            Label label = new Label()
            {
                Text = "№",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "τ, мин.",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "t1, °C",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "φ1, %",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "t2, °C",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "φ2, %",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "W",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "u",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "N",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);

            label = new Label()
            {
                Text = "βv",
                TextAlign = ContentAlignment.MiddleCenter
            };
            tableHeader.Controls.Add(label);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (tableValues.Controls.Count < 10)
            {
                return;
            }

            tableValues.Visible = false;

            for (int i = 10; i > 0; i--)
            {
                tableValues.Controls.RemoveAt(tableValues.Controls.Count - i);
            }

            prevU.RemoveAt(prevU.Count - 1);
            prevT.RemoveAt(prevT.Count - 1);
            i--;
            sumW -= lastAddedW;

            document.RemoveLastVars();

            tableValues.RowCount--;

            if (tableValues.Controls.Count < 10)
            {
                btnUndo.Width = 0;
                btnCalculate.Width = 145;
                btnSave.Visible = false;
                label10.Visible = false;
                tbT0.Visible = false;
                btnCalculate.Text = "Начать";
            }

            tableValues.Visible = true;
        }

        private void tbMs_TextChanged(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor == Color.Pink)
            {
                ((Control)sender).BackColor = DefaultBackColor;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream w = File.Open(Path.GetFullPath(saveFileDialog1.FileName), 
                    FileMode.OpenOrCreate);
                document.CreateHead(tbT0.Text, docU0, docH, docMs, docMv, docV);
                document.Export(w);
            }
        }
    }

    public class ExportDocument
    {
        public MigraDoc.DocumentObjectModel.Document Document;
        public List<double[]> Values = new List<double[]>();

        private MigraDoc.DocumentObjectModel.Style Style;
        private MigraDoc.DocumentObjectModel.Section FirstSection;

        public ExportDocument()
        {
            Document = new MigraDoc.DocumentObjectModel.Document();

            Style = Document.Styles["Normal"];
            Style.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 10);

            Style = Document.Styles.AddStyle("Footer", "Normal");
            Style.Font.Size = 8;

            FirstSection = Document.AddSection();
        }

        private void PrepareToExport()
        {
            bool firstPage = true;
            bool nextPage = true;
            int count = Values.Count;
            int start = 0;

            while (nextPage)
            {
                MigraDoc.DocumentObjectModel.Section section;

                int pageElem = 52;
                if (firstPage)
                {
                    pageElem = 47;
                    firstPage = false;
                    section = FirstSection;
                } else
                {
                    section = Document.AddSection();
                }

                if (pageElem > count)
                {
                    pageElem = count;
                    nextPage = false;
                }
                else
                {
                    count -= pageElem;
                }

                MigraDoc.DocumentObjectModel.Tables.Table table = section.AddTable();
                CreateTable(table);
                FillTable(table, start, pageElem);

                start += pageElem;
            }
        }

        public void CreateHead(string T0, double u, string H, string ms, string mv, string V)
        {
            MigraDoc.DocumentObjectModel.Tables.Table head = FirstSection.AddTable();

            head.Columns.Clear();
            head.Rows.Clear();

            head.Borders.Color = MigraDoc.DocumentObjectModel.Colors.Black;
            head.Borders.Width = 0.5;

            head.AddColumn("2.5cm");
            head.AddColumn("2.5cm");
            head.AddColumn("11.3cm");

            MigraDoc.DocumentObjectModel.Tables.Row row = head.AddRow();
            row.Cells[0].AddParagraph(string.Format("{0}°C | u = {1:0.00} | H = {2}", T0, u, H));
            row.Cells[0].MergeRight = 2;
            row.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
            row.Format.Font.Bold = true;

            row = head.AddRow();
            row.Cells[0].AddParagraph("m1, гр");
            row.Cells[1].AddParagraph(ms);
            row.Cells[2].AddParagraph("Масса сухого материала");

            row = head.AddRow();
            row.Cells[0].AddParagraph("m2, гр");
            row.Cells[1].AddParagraph(mv);
            row.Cells[2].AddParagraph("Масса влажного материала");

            row = head.AddRow();
            row.Cells[0].AddParagraph("H, мм");
            row.Cells[1].AddParagraph(H);
            row.Cells[2].AddParagraph("Высота слоя");

            row = head.AddRow();
            row.Cells[0].AddParagraph("Расход, м³/ч");
            row.Cells[1].AddParagraph(V);
            row.Cells[2].AddParagraph("Объёмный расход воздуха");
        }

        private void CreateTable(MigraDoc.DocumentObjectModel.Tables.Table table)
        {
            table.Columns.Clear();
            table.Rows.Clear();

            table.Borders.Color = MigraDoc.DocumentObjectModel.Colors.Black;
            table.Borders.Width = 0.5;

            MigraDoc.DocumentObjectModel.Tables.Column column;
            column = table.AddColumn("1cm");

            for (int i = 0; i < 5; i++)
            {
                column = table.AddColumn("1.3cm");
                column.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
            }

            for (int i = 0; i < 4; i++)
            {
                column = table.AddColumn("2.2cm");
                column.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
            }

            MigraDoc.DocumentObjectModel.Tables.Row row = table.AddRow();
            row.Format.Font.Bold = true;
            row.Format.SpaceBefore = "0.1cm";
            row.Format.SpaceAfter = "0.1cm";
            row.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

            row.Cells[0].AddParagraph("№");
            row.Cells[1].AddParagraph("τ, мин.");
            row.Cells[2].AddParagraph("t1, °C");
            row.Cells[3].AddParagraph("φ1, %");
            row.Cells[4].AddParagraph("t2, °C");
            row.Cells[5].AddParagraph("φ2, %");
            row.Cells[6].AddParagraph("W");
            row.Cells[7].AddParagraph("u");
            row.Cells[8].AddParagraph("N");
            row.Cells[9].AddParagraph("βv");
        }

        private void FillTable(MigraDoc.DocumentObjectModel.Tables.Table table, int start, int count)
        {
            foreach (double[] rowData in Values.GetRange(start, count))
            {
                MigraDoc.DocumentObjectModel.Tables.Row row = table.AddRow();
                row.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

                int j = 0;
                foreach (double value in rowData)
                {
                    if (j > 5)
                    {
                        row.Cells[j++].AddParagraph(String.Format("{0:0.0000000}", value));
                    }
                    else
                    {
                        row.Cells[j++].AddParagraph(value.ToString());
                    }
                }
            }
        }

        public void RemoveLastVars()
        {
            Values.RemoveAt(Values.Count - 1);
        }

        public void LoadVars(double[] vars)
        {
            Values.Add(vars);
        }

        public void Export(Stream stream)
        {
            PrepareToExport();

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true)
            {
                Document = Document
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(stream, true);
        }
    }
}
