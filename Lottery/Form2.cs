using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form2 : Form
    {
        Ticket ticket;
        Form1 form;
       
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ticket = new Ticket();
            this.Text = "Lottery ticket number " + ticket.numberTick.ToString();
        }

        private void fieldOne_Click(object sender, EventArgs e)
        {
            checkWin(1, this.fieldOne);
        }

        private void fieldTwo_Click(object sender, EventArgs e)
        {
            checkWin(2, this.fieldTwo);

        }

        private void fieldThree_Click(object sender, EventArgs e)
        {
            checkWin(3, this.fieldThree);
        }

        private void fieldFour_Click(object sender, EventArgs e)
        {
            checkWin(4, this.fieldFour);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameLot.checkWin(ticket.minWin, ticket.bigWin);
            form.countAndOut();
            Close();
        }

        private void checkWin (int numField, Button item)
        {
            if (ticket.statusField(numField))
            {
                item.BackColor = System.Drawing.Color.Gold;
                item.BackgroundImage = System.Drawing.Image.FromFile("win.png");
            }
            else
            {
                item.BackColor = System.Drawing.Color.White;
                item.BackgroundImage = System.Drawing.Image.FromFile("Lose.png");
            }
        }
    }
}
