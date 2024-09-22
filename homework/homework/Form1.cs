using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Label lbone = new Label(), lbtwo = new Label(), lbOperations = new Label(), lbRes = new Label();
        TextBox tbone = new TextBox(), tbtwo = new TextBox(), tbResult = new TextBox();
        ComboBox cmbOperations = new ComboBox();
        Button btResult = new Button(), btclear = new Button();

        /// ///////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "saker";
            this.Size = new Size(580, 400);

            /////////////// label ///////////////////////


            lbone.Text = "Number One :";
            lbone.ForeColor = Color.Green;
            lbone.Font = new Font(Font.FontFamily, 10F, FontStyle.Italic);
            lbone.Location = new Point(450, 20);


            lbtwo.Text = "Number Two :";
            lbtwo.ForeColor = Color.Green;
            lbtwo.Font = new Font(Font.FontFamily, 10F, FontStyle.Italic);
            lbtwo.Location = new Point(150, 20);


            lbOperations.Text = "Operations :";
            lbOperations.ForeColor = Color.Green;
            lbOperations.Font = new Font(Font.FontFamily, 10F, FontStyle.Italic);
            lbOperations.Location = new Point(290, 20);


            lbRes.Text = "Result :";
            lbRes.ForeColor = Color.Green;
            lbRes.Font = new Font(Font.FontFamily, 10F, FontStyle.Italic);
            lbRes.Location = new Point(30, 20);

            ////////////////////////// textBox /////////////////////////////


            tbone.Location = new Point(450, 50);
            tbone.Font = new Font(Font.FontFamily, 9F, FontStyle.Underline);
            tbone.Name = "tbone";
            tbone.TextChanged += txtch;


            tbtwo.Location = new Point(150, 50);
            tbtwo.Font = new Font(Font.FontFamily, 9F, FontStyle.Underline);
            tbtwo.TextChanged += txtch;
            tbtwo.Text = null;
            tbtwo.TextAlign = new HorizontalAlignment();

            tbResult.Location = new Point(30, 50);
            tbResult.Font = new Font(Font.FontFamily, 9F, FontStyle.Underline);
            tbResult.ReadOnly = true;

            ///////////////// Button ///////////////////////////////////

            btResult.Text = "Result";
            btResult.Location = new Point(300, 150);
            btResult.Size = new Size(70, 50);
            btResult.Font = new Font(Font.FontFamily, 9F, FontStyle.Bold);
            btResult.BackColor = Color.Green;
            btResult.Click += btResult_click;

            btclear.Text = "Clear";
            btclear.Location = new Point(200, 150);
            btclear.Size = new Size(70, 50);
            btclear.Font = new Font(Font.FontFamily, 9F, FontStyle.Bold);
            btclear.BackColor = Color.Red;
            btclear.Click += btclear_click;

            ///////////////// combobox ////////////////////////////


            cmbOperations.Location = new Point(290, 50);
            cmbOperations.Items.Add("+");
            cmbOperations.Items.Add("-");
            cmbOperations.Items.Add("*");
            cmbOperations.Items.Add("/");
            cmbOperations.ForeColor = Color.Green;
            cmbOperations.Font = new Font("Microsoft Sans Serif", 10F);
            cmbOperations.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperations.Text = "+";
            //cmbOperations.SelectedIndexChanged += cmbOperations_changed;
            cmbOperations.SelectedIndexChanged += btResult_click;


            ////////////////////// Add Form //////////////////////////////
            this.Controls.Add(lbone);
            this.Controls.Add(lbOperations);
            this.Controls.Add(lbtwo);
            this.Controls.Add(lbRes);
            this.Controls.Add(tbone);
            this.Controls.Add(tbtwo);
            this.Controls.Add(tbResult);
            this.Controls.Add(btResult);
            this.Controls.Add(btclear);
            this.Controls.Add(cmbOperations);
        }


        void btResult_click(object s, EventArgs e)
        {
            double x, y;
            try
            {
                x = double.Parse(tbone.Text);
            }
            catch
            {
                if (tbone.Text == "")
                    MessageBox.Show("The TextBox One is Empty");
                else
                    MessageBox.Show("Erorr TextBox One ");
                tbone.Focus();
                return;
            }

            try
            {
                y = double.Parse(tbtwo.Text);
            }
            catch
            {
                if (tbtwo.Text == "")
                    MessageBox.Show("The TextBox Two is Empty");
                else
                    MessageBox.Show("Erorr TextBox Two ");
                tbtwo.Focus();
                return;
            }

            switch (cmbOperations.SelectedItem.ToString())
            {
                case "+": tbResult.Text = (x + y).ToString(); break;
                case "-": tbResult.Text = (x - y).ToString(); break;
                case "*": tbResult.Text = (x * y).ToString(); break;
                case "/": tbResult.Text = (x / y).ToString(); break;
                default: break;

            }

        }

        void btclear_click(object s, EventArgs e)
        {
            tbone.Text = tbtwo.Text = tbResult.Text = null;
        }

        //void cmbOperations_changed(object s, EventArgs e)
        //{
        //   hhghhhjygg
        //}

        public void txtch(object s, EventArgs e)
        {




            string b = tbtwo.Text;
            int v = 0;
            string h = null;
            for (int i = 0; i < b.Length; i++)
                if (int.TryParse(b[i].ToString(), out v))
                {

                    h += v.ToString();

                }


            tbtwo.Text = h;





        }

    }
}
