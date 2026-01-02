using DXFReaderNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXFReaderNET;
using DXFReaderNET.Entities;

namespace DXFCoords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ReadDXF(@"..\..\surface.dxf");
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.ZoomCenter();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            dataGridViewCoords.Rows.Clear();
            dataGridViewCoords.Columns.Clear();

            DataGridViewTextBoxColumn NumberColumn = new DataGridViewTextBoxColumn();
            NumberColumn.HeaderText = "#";
            NumberColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCoords.Columns.Add(NumberColumn);

            DataGridViewTextBoxColumn XColumn = new DataGridViewTextBoxColumn();
            XColumn.HeaderText = "x";
            XColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCoords.Columns.Add(XColumn);

            

            DataGridViewTextBoxColumn YColumn = new DataGridViewTextBoxColumn();
            YColumn.HeaderText = "y";
            YColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCoords.Columns.Add(YColumn);

            DataGridViewTextBoxColumn ZColumn = new DataGridViewTextBoxColumn();
            ZColumn.HeaderText = "z";
            ZColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCoords.Columns.Add(ZColumn);

            dataGridViewCoords.Columns[0].Width = 50;
            dataGridViewCoords.Columns[1].Width = 100;
            dataGridViewCoords.Columns[2].Width = 100;
            dataGridViewCoords.Columns[3].Width = 100;
            dataGridViewCoords.ColumnHeadersVisible = true;
            int n = 0;
            foreach (DXFReaderNET.Entities.Point p in dxfReaderNETControl1.DXF.Points)
            {
                dataGridViewCoords.Rows.Add();

                n++;
                dataGridViewCoords.Rows[dataGridViewCoords.Rows.Count - 1].Cells[0].Value = n.ToString();
                dataGridViewCoords.Rows[dataGridViewCoords.Rows.Count - 1].Cells[1].Value = dxfReaderNETControl1.DXF.ToFormattedUnit(p.Position.X);
                dataGridViewCoords.Rows[dataGridViewCoords.Rows.Count - 1].Cells[2].Value = dxfReaderNETControl1.DXF.ToFormattedUnit(p.Position.Y);
                dataGridViewCoords.Rows[dataGridViewCoords.Rows.Count - 1].Cells[3].Value = dxfReaderNETControl1.DXF.ToFormattedUnit(p.Position.Z);
               
            }
        }
    }
}
