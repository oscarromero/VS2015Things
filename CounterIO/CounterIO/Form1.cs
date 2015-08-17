using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterIO
{
    public partial class Form1 : Form
    {
        public Queue<int> tokens = new Queue<int>();
        public int lastTokenNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAvailableTokens();
        }

        private void btnPrintToken_Click(object sender, EventArgs e)
        {
            generateToken();
        }

        private void btnCounter1_Click(object sender, EventArgs e)
        {
            takeTokenForCounter(1);
        }

        private void btnCounter2_Click(object sender, EventArgs e)
        {
            takeTokenForCounter(2);
        }

        private void btnCounter3_Click(object sender, EventArgs e)
        {
            takeTokenForCounter(3);
        }

        public void updateAvailableTokens()
        {
            txtAvailableTokens.Text = "There are " + tokens.Count + " in the queue.";

            lstQueue.Items.Clear();
            foreach (int token in tokens)
            {
                lstQueue.Items.Add(token);
            }
        }

        public void generateToken()
        {
            int newTokenNumber = lastTokenNumber + 1;
            lastTokenNumber = newTokenNumber;

            tokens.Enqueue(newTokenNumber);
            lstQueue.Items.Add(newTokenNumber);

            updateAvailableTokens();
        }

        public void takeTokenForCounter(int counterId)
        {
            if (! (tokens.Count > 0))
            {
                MessageBox.Show("There are no tokens in the queue.");
                return;
            }

            int servedToken = tokens.Dequeue();
            txtMessage.Text = "Token " + servedToken + " go to counter #" + counterId;

            switch (counterId)
            {
                case 1:
                    txtCounter1.Text = servedToken.ToString();
                    break;
                case 2:
                    txtCounter2.Text = servedToken.ToString();
                    break;
                case 3:
                    txtCounter3.Text = servedToken.ToString();
                    break;
                default:
                    break;
            }

            updateAvailableTokens();
        }
    }
}
