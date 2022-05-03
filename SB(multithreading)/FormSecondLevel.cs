using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB_multithreading_
{
    public partial class FormSecondLevel : Form
    {

        public int height = 5;
        public int width = 5;
        public int[,] field2;
        public int[,] end2;
        public int stepIndex = 0;
        public FormSecondLevel()
        {
            InitializeComponent();
        }

        private void LoadLevel()
        {
            StreamReader file1 = new StreamReader("field2.txt");
            StreamReader file2 = new StreamReader("EndGame2.txt");
            for (int i = 0; i < height; i++)
            {
                string[] s1 = file1.ReadLine().Split();
                string[] s2 = file2.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    field2[i, j] = int.Parse(s1[j]);
                    end2[i, j] = int.Parse(s2[j]);
                }
            }
            file1.Close();
            file2.Close();
        }
        public void GridField()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (field2[i, j] == 1)
                        dgvField2.Rows[i].Cells[j].Style.BackColor = Color.DarkMagenta;

                    else if (field2[i, j] == 2)
                        dgvField2.Rows[i].Cells[j].Style.BackColor = Color.DeepPink;

                    else if(field2[i,j] == 3)
                        dgvField2.Rows[i].Cells[j].Style.BackColor = Color.BlueViolet;

                    else dgvField2.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void FormSecondLevel_Load(object sender, EventArgs e)
        {
            field2 = new int[height, width];
            end2 = new int[height, width];
            dgvField2.Rows.Add(height);
            dgvMove2.Rows.Add(5);
            LoadLevel();
            dgvField2.ClearSelection();
            dgvMove2.ClearSelection();
            dgvMove2.Rows[0].Cells[0].Selected = false;
            dgvField2.Enabled = false;
            GridField();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (TryStep(button.Image, dgvMove2.CurrentCell.RowIndex,
                 dgvMove2.CurrentCell.ColumnIndex, field2) == true)
                dgvMove2.CurrentCell.Value = button.Image;
            else MessageBox.Show("!!!");
        }
        public bool TryStep(Image StepShip, int y, int x, int[,] tempField)
        {
            Image up = Image.FromFile("up1.png");
            Image down = Image.FromFile("down1.png");
            Image right = Image.FromFile("right1.png");
            Image left = Image.FromFile("left1.png");
            if (StepShip == up && y - 1 > 0)
            {
                tempField[y - 1, x] = field2[y, x];
                return true;
            }

            if (StepShip == down && y + 1 < height - 1)
            {
                tempField[y + 1, x] = field2[y, x];
                return true;
            }

            if (StepShip == right && x + 1 < width - 1)
            {
                tempField[y, x + 1] = field2[y, x];
                return true;
            }

            if (StepShip == left && x - 1 < 0)
            {
                tempField[y, x - 1] = field2[y, x];
                return true;
            }

            return false;

        }

        public bool CheckWin()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (field2[i, j] != end2[i, j])
                    {
                        GridField();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
