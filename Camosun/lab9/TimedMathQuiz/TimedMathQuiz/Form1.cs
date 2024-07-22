using System;

namespace TimedMathQuiz_
{
    public partial class Form1 : Form
    {
        private int secondsCounter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTheTime();            
            GenerateRandomAdditions();
        }
        
        // genera data variables
        public void GenerateRandomAdditions()
        {
            Random random = new Random();
            label1.Text = random.Next(10).ToString();
            label3.Text = random.Next(10).ToString();
            label5.Text = random.Next(10).ToString();
            label7.Text = random.Next(10).ToString();
            label9.Text = random.Next(10).ToString();
            label11.Text = random.Next(10).ToString();           
        }

        // calculate the result 
        public bool CheckAnswers()
        {
            int answer1, answer2, answer3;
            int user1, user2, user3;

            answer1 = Convert.ToInt32(label1.Text) + Convert.ToInt32(label3.Text);
            answer2 = Convert.ToInt32(label5.Text) + Convert.ToInt32(label7.Text);
            answer3 = Convert.ToInt32(label9.Text) + Convert.ToInt32(label11.Text);

            int.TryParse(txtAnswer1.Text, out user1);
            int.TryParse(txtAnswer2.Text, out user2);
            int.TryParse(txtAnswer3.Text, out user3);

            if (answer1.Equals(user1) && answer2.Equals(user2) && answer3.Equals(user3))
            {                                                
                timer1.Stop();   
                if (secondsCounter > 5)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Your time: " + secondsCounter + " seconds.";
                }
                else
                lblMessage.Text = "Your time: " + secondsCounter + " seconds.";
                return true;
            }
            else
            {
                return false;
            }
        }

        // validate the result
        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            CheckAnswers();            
        }
        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            CheckAnswers();
        }
        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            CheckAnswers();
        }
        // initialize the time
        public void StartTheTime()
        {            
            timer1.Start();
            secondsCounter = 0;
            lblTimer.Text = secondsCounter.ToString() + " seconds";
        }
        // incremente seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsCounter++;
            lblTimer.Text = secondsCounter.ToString() + " seconds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAnswer1.Text = "";
            txtAnswer2.Text = "";
            txtAnswer3.Text = "";
            lblMessage.Text = "";
            txtAnswer1.Focus();
            StartTheTime();
            GenerateRandomAdditions();
        }      
    }
}