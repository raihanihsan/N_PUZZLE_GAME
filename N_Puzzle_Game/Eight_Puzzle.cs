using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Puzzle_Game
{
    public partial class Eight_Puzzle : Form
    {
        string path = "";
        UserControl_Puzzle_Numbers usdg;
       
        public bool b_bfs = false, b_gbfs = false, b_a_star = false, b_bi = false;

        public Eight_Puzzle()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                panel1.Controls.Clear();
                usdg = new UserControl_Puzzle_Numbers(270, 3, 90);
                panel1.Controls.Add(usdg);
        }

        private void Eight_Puzzle_Load(object sender, EventArgs e)
        {
            this.Width = 310;
            radioButton1.Checked = true;
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
        }
        private int[,] get_state(string state)
        {
            int N = (int)Math.Sqrt(state.Length);
            int[,] rs = new int[N, N];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    int idx = i * 3 + j;
                    rs[i, j] = state[idx] - 48;
                }
            return rs;
        }

       

        private void Eight_Puzzle_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
