using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB_multithreading_
{
    public partial class FormMain : Form
    {
     
       
        FormFirstLevel formlvl1 = new FormFirstLevel();
        FormSecondLevel formlvl2 = new FormSecondLevel();
        FormThirdLevel formlvl3 = new FormThirdLevel(); 
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dGVLevel1.Rows.Add(4);
            dGVLevel2.Rows.Add(5);
            dGVLevel3.Rows.Add(6);
            //
            dGVLevel1.Rows[0].Cells[0].Style.BackColor = Color.Yellow;
            dGVLevel1.Rows[0].Cells[1].Style.BackColor = Color.Yellow;
            dGVLevel1.Rows[1].Cells[0].Style.BackColor = Color.Yellow;

            dGVLevel1.Rows[3].Cells[3].Style.BackColor = Color.Violet;
            dGVLevel1.Rows[2].Cells[3].Style.BackColor = Color.Violet;
            dGVLevel1.Rows[3].Cells[2].Style.BackColor = Color.Violet;
            //
            dGVLevel2.Rows[0].Cells[0].Style.BackColor = Color.DarkMagenta;
            dGVLevel2.Rows[1].Cells[0].Style.BackColor = Color.DarkMagenta;
            dGVLevel2.Rows[0].Cells[1].Style.BackColor = Color.DarkMagenta;

            dGVLevel2.Rows[0].Cells[4].Style.BackColor = Color.DeepPink;
            dGVLevel2.Rows[1].Cells[4].Style.BackColor = Color.DeepPink;
            dGVLevel2.Rows[2].Cells[4].Style.BackColor = Color.DeepPink;

            dGVLevel2.Rows[4].Cells[2].Style.BackColor = Color.BlueViolet;
            dGVLevel2.Rows[4].Cells[3].Style.BackColor = Color.BlueViolet;
            dGVLevel2.Rows[4].Cells[4].Style.BackColor = Color.BlueViolet;
            //
            dGVLevel3.Rows[0].Cells[0].Style.BackColor = Color.BlanchedAlmond;
            dGVLevel3.Rows[0].Cells[1].Style.BackColor = Color.BlanchedAlmond;
            dGVLevel3.Rows[0].Cells[2].Style.BackColor = Color.BlanchedAlmond;

            dGVLevel3.Rows[0].Cells[5].Style.BackColor = Color.DarkOrchid;
            dGVLevel3.Rows[0].Cells[4].Style.BackColor = Color.DarkOrchid;
            dGVLevel3.Rows[1].Cells[5].Style.BackColor = Color.DarkOrchid;
            dGVLevel3.Rows[2].Cells[5].Style.BackColor = Color.DarkOrchid;

            dGVLevel3.Rows[5].Cells[0].Style.BackColor = Color.Indigo;
            dGVLevel3.Rows[5].Cells[1].Style.BackColor = Color.Indigo;
            dGVLevel3.Rows[4].Cells[0].Style.BackColor = Color.Indigo;
           
            dGVLevel3.Rows[5].Cells[5].Style.BackColor = Color.HotPink;
            dGVLevel3.Rows[4].Cells[4].Style.BackColor = Color.HotPink;
            dGVLevel3.Rows[5].Cells[4].Style.BackColor = Color.HotPink;
            dGVLevel3.Rows[4].Cells[5].Style.BackColor = Color.HotPink;


            dGVLevel1.ClearSelection();
            dGVLevel2.ClearSelection();
            dGVLevel3.ClearSelection();

            dGVLevel1.Enabled = false;
            dGVLevel2.Enabled = false;
            dGVLevel3.Enabled = false;
        }

       

        private void InstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ДЕЛАЙ УРОКИ!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formlvl1.Show();
        }

        private void dGVLevel2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formlvl2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formlvl3.Show();
        }
    }
}
