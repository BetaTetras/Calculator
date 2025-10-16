namespace Calculatrice
{
    public partial class Form1 : Form
    {
        String FirstNum = "";
        String SecondNum = "";
        char? Ope = null;

        public Form1()
        {
            InitializeComponent();

            Btn1.Click += Button_Click;
            Btn2.Click += Button_Click;
            Btn3.Click += Button_Click;
            Btn4.Click += Button_Click;
            Btn5.Click += Button_Click;
            Btn6.Click += Button_Click;
            Btn7.Click += Button_Click;
            Btn8.Click += Button_Click;
            Btn9.Click += Button_Click;
            Btn0.Click += Button_Click;
            BtnPlus.Click += Button_Click;
            BtnMoins.Click += Button_Click;
            BtnFois.Click += Button_Click;
            BtnDiviser.Click += Button_Click;
            BtnEgale.Click += Button_Click;
            BtnSupp.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            long Res = 0;

            switch (btn.Name)
            {
                case "Btn0":
                case "Btn1":
                case "Btn2":
                case "Btn3":
                case "Btn4":
                case "Btn5":
                case "Btn6":
                case "Btn7":
                case "Btn8":
                case "Btn9":
                    if (btn.Name == "Btn0" && FirstNum == "")
                    {
                        break;
                    }
                    else if (Ope == null)
                    {
                        if (FirstNum.Length < 10)
                        {
                            FirstNum += btn.Text;
                            textBox1.Text = "";
                            textBox1.Text = FirstNum;
                        }
                    }
                    else if (SecondNum.Length < 10)
                    {
                        SecondNum += btn.Text;
                        textBox1.Text = "";
                        textBox1.Text = SecondNum;
                    }
                    break;

                case "BtnPlus":
                case "BtnMoins":
                case "BtnFois":
                case "BtnDiviser":
                    if (Ope == null)
                    {
                        Ope = btn.Text[0];
                        textBox1.Text = "";
                        textBox1.Text = "" + Ope;
                    }
                    break;

                case "BtnEgale":
                    if (FirstNum != "" && SecondNum != "" && Ope != null)
                    {
                        Res = CalculerRes(FirstNum, Ope, SecondNum);
                        textBox1.Text = "";
                        textBox1.Text = Res.ToString();

                        FirstNum = "";
                        SecondNum = "";
                        Ope = null;
                    }
                    break;

                case "BtnSupp":
                    if (Ope == null)
                    {
                        FirstNum = "";
                        textBox1.Text = "";
                        textBox1.Text = FirstNum;
                    }
                    else
                    {
                        SecondNum = "";
                        textBox1.Text = "";
                        textBox1.Text = SecondNum;
                    }
                    break;
                }
            }

            public long CalculerRes(String nb1, char? Ope, String nb2)
        {
            long INTnb1 = Convert.ToInt64(nb1);
            long INTnb2 = Convert.ToInt64(nb2);

            switch (Ope)
            {
                case '+':
                    return INTnb1 + INTnb2;
                    break;

                case '-':
                    return INTnb1 - INTnb2;
                    break;

                case '*':
                    return INTnb1 * INTnb2;
                    break;

                case '/':
                    if (INTnb2 == 0)
                    {
                        MessageBox.Show("# Erreur\n#Division par 0 !");
                        return 0;
                    }
                    return INTnb1 / INTnb2;
                    break;
            }

            return 0;

        }
    }
}
