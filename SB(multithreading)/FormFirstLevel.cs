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
    public partial class FormFirstLevel : Form
    {

        public int height = 4;
        public int width = 4;
        public int[,] field;
        public int[,] end;
        public int stepIndex = 0;
        public FormFirstLevel()
        {
            InitializeComponent();
        }
        private void LoadLevel()
        {
            StreamReader file1 = new StreamReader("field.txt");
            StreamReader file2 = new StreamReader("EndGame.txt");
            for (int i = 0; i < height; i++)
            {
                string[] s1 = file1.ReadLine().Split();
                string[] s2 = file2.ReadLine().Split();
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = int.Parse(s1[j]);
                    end[i, j] = int.Parse(s2[j]);
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
                    if (field[i, j] == 1)
                        dataGridViewField1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                    else if (field[i, j] == 2)
                        dataGridViewField1.Rows[i].Cells[j].Style.BackColor = Color.Violet;

                    else dataGridViewField1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
        private void FormFirstLevel_Load(object sender, EventArgs e)
        {
            field = new int[height, width];
            end = new int[height, width];
            dataGridViewField1.Rows.Add(height);
            dataGridViewMove1.Rows.Add(4);
            pictureBoxYel.BackColor = Color.Yellow;
            pictureBoxViol.BackColor = Color.Violet;
            LoadLevel();
            dataGridViewMove1.ClearSelection();
            dataGridViewField1.ClearSelection();
            dataGridViewMove1.Rows[0].Cells[0].Selected = false;
            dataGridViewField1.Enabled = false;
            GridField();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (TryStep(button.Image, dataGridViewMove1.CurrentCell.RowIndex,
                 dataGridViewMove1.CurrentCell.ColumnIndex, field) == true)
                dataGridViewMove1.CurrentCell.Value = button.Image;
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
                tempField[y - 1, x] = field[y, x];
                return true;
            }

            if (StepShip == down && y + 1 < height - 1)
            {
                tempField[y + 1, x] = field[y, x];
                return true;
            }

            if (StepShip == right && x + 1 < width - 1)
            {
                tempField[y, x + 1] = field[y, x];
                return true;
            }

            if (StepShip == left && x - 1 < 0)
            {
                tempField[y, x - 1] = field[y, x];
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
                    if (field[i, j] != end[i, j])
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
