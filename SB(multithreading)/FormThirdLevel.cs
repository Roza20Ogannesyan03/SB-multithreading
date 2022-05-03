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
    public partial class FormThirdLevel : Form
    {
        public int height = 6;
        public int width = 6;
        public int[,] field3;
        public int[,] end3;
        public int stepIndex = 0;
        public FormThirdLevel()
        {
            InitializeComponent();
        }
        private void LoadLevel()
        {
            StreamReader file1 = new StreamReader("field3.txt");
            StreamReader file2 = new StreamReader("EndGame3.txt");
            for (int i = 0; i < height; i++)
            {
                string[] s1 = file1.ReadLine().Split();
                string[] s2 = file2.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    field3[i, j] = int.Parse(s1[j]);
                    end3[i, j] = int.Parse(s2[j]);
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
                    if (field3[i, j] == 1)
                        dgvField3.Rows[i].Cells[j].Style.BackColor = Color.BlanchedAlmond;

                    else if (field3[i, j] == 2)
                        dgvField3.Rows[i].Cells[j].Style.BackColor = Color.DarkOrchid;

                    else if (field3[i, j] == 3)
                        dgvField3.Rows[i].Cells[j].Style.BackColor = Color.Indigo;

                    else if(field3[i,j] == 4)
                        dgvField3.Rows[i].Cells[j].Style.BackColor = Color.HotPink;

                    else dgvField3.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void FormThirdLevel_Load(object sender, EventArgs e)
        {
            field3 = new int[height, width];
            end3 = new int[height, width];
            dgvField3.Rows.Add(height);
            dgvMove3.Rows.Add(6);
            LoadLevel();
            dgvField3.ClearSelection();
            dgvMove3.ClearSelection();
            dgvMove3.Rows[0].Cells[0].Selected = false;
            dgvField3.Enabled = false;
            GridField();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (TryStep(button.Image, dgvMove3.CurrentCell.RowIndex,
                 dgvMove3.CurrentCell.ColumnIndex, field3) == true)
                dgvMove3.CurrentCell.Value = button.Image;
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
                tempField[y - 1, x] = field3[y, x];
                return true;
            }

            if (StepShip == down && y + 1 < height - 1)
            {
                tempField[y + 1, x] = field3[y, x];
                return true;
            }

            if (StepShip == right && x + 1 < width - 1)
            {
                tempField[y, x + 1] = field3[y, x];
                return true;
            }

            if (StepShip == left && x - 1 < 0)
            {
                tempField[y, x - 1] = field3[y, x];
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
                    if (field3[i, j] != end3[i, j])
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
