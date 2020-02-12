using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            ultraLabel2.Visible = false;

        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ultraLabel2_Click(object sender, EventArgs e)
        {

        }

        private void showStuff(object sender, EventArgs e)
        {
           // if (ultraComboEditor1.SelectedItem == "Length")
        
           // Console.WriteLine(SelectOption.SelectedItem);
            if (SelectOption.Text == "Length")
            {
                ultraLabel2.Visible = true;
               // textBox1.Text = null;
               // textBox2.Text = null;
                textBox1.Visible = true;
                textBox2.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
            }
            else if (SelectOption.Text == "Weight")
            {
                ultraLabel2.Visible = true;
                //textBox1.Visible = true;
                //textBox2.Visible = true;
                textBox1.Text = null;
                textBox2.Text = null;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
            
            }
        }

        private void converter(object sender, EventArgs e)
        {
            Console.WriteLine("hey again!!");
        }


        private void ConvertRight(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" ||
                comboBox2.Text == "" || comboBox1.Text == "0" || comboBox2.Text == "0") return;
            Console.WriteLine("1");
            //Console.WriteLine(current.Name);
            bool convertRight = false;
           //TextBox current =  sender as TextBox  ;
//           TextBox current = (TextBox)sender;
            
            ComboBox current; TextBox curTextBox;
            try
            {
                current = (ComboBox)sender;
                // Console.WriteLine(current.Name);
                if (current.Name == "comboBox1")
                    convertRight = true;
                Console.WriteLine("2");
            }
            catch
            {
                Console.WriteLine("TextBox changed , so exception thrown by combox conversion!!");
            }
            finally
            {
                try
                {
                    curTextBox = (TextBox)sender;
                    //      Console.WriteLine(curTextBox.Name);
                    if (curTextBox.Name == "textBox1")
                        convertRight = true;
                }
                catch
                {
                    Console.WriteLine("What are you doing bro!!!!!!!!!!!!!!!!!");
                }

            }
            

           
     //       Console.WriteLine(current.Name);
        //    if (current.Name == "comboBox1")
         //       convertRight = true;
            //Console.WriteLine(new StackFrame(1).GetMethod().Name);
            string baseFrom, baseTo; double userinput;
            if (convertRight == true)
            {
                // means user entetred input on the left side
                if (textBox1.Text == "") return;

                userinput = double.Parse(textBox1.Text);

                baseFrom = comboBox1.Text;
                baseTo = comboBox2.Text;
            }
            else
            {
                Console.WriteLine("3");
                // means user entetred input on the left side
                if (textBox2.Text == "") return;

                userinput = double.Parse(textBox2.Text);

                baseFrom = comboBox2.Text;   //interchanged
                baseTo = comboBox1.Text;
    
            }

            if (baseFrom == baseTo) { textBox2.Text = textBox1.Text; return; }
            //Console.WriteLine(userinput);

            double answer=0;  // for case if converting from km to km
            if (true)
            {
                // these calculations based on km
                Console.WriteLine("4");
                if (baseTo == "Kilometre") answer = userinput;

                else if (baseTo == "Metre")
                {
                    answer = userinput * 1000;

                }
                else if (baseTo == "Centimetre")
                {
                    answer = userinput * 100000;
                }
                else if (baseTo == "Millimetre")
                {
                    answer = userinput * 1000000;
                }
                else if (baseTo == "Micrometre")
                {
                    answer = userinput * 1e9;
                }
                else if (baseTo == "Nanometre")
                {
                    answer = userinput * 1e12;
                }
                else if (baseTo == "Mile")
                {
                    answer = userinput * 0.621371;
                }
                else if (baseTo == "Yard")
                {
                    Console.WriteLine(answer);
                    answer = userinput * 1093.61;

                }
                else if (baseTo == "Foot")
                {
                    answer = userinput * 3280.84;
                }
                else if (baseTo == "Inch")
                {
                    answer = userinput * 39370.1;
                }
                else if (baseTo == "Nautical Mile")
                {
                    answer = userinput * 0.539957;
                }

                if (baseFrom == "Metre") answer = answer / 1e3;
                else if (baseFrom == "Centimetre") answer = answer / 1e5;
                else if (baseFrom == "Millimetre") answer = answer / 1e6;
                else if (baseFrom == "Micrometre") answer = answer / 1e9;
                else if (baseFrom == "Nanometre") answer = answer / 1e12;
                else if (baseFrom == "Foot") answer = answer / 3281;
                else if (baseFrom == "Inch") answer = answer / 39370;
                else if (baseFrom == "Nautical Mile") answer = answer * 3281;
                Console.WriteLine("5");
                Console.WriteLine(answer);
            }
            //2
            if (convertRight)
            { textBox2.Text = Convert.ToString(answer); return; }
            else
            { textBox1.Text = Convert.ToString(answer);
            Console.WriteLine("6"); 
                return; }

        }
        private void ConvertRightWeight(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox3.Text == "" ||
                comboBox3.Text == "" || comboBox4.Text == "0" || comboBox4.Text == "0") return;
            Console.WriteLine("1");
            //Console.WriteLine(current.Name);
            bool convertRight = false;
            //TextBox current =  sender as TextBox  ;
            //           TextBox current = (TextBox)sender;

            ComboBox current; TextBox curTextBox;
            try
            {
                current = (ComboBox)sender;
                // Console.WriteLine(current.Name);
                if (current.Name == "comboBox3")
                    convertRight = true;
                Console.WriteLine("2");
            }
            catch
            {
                Console.WriteLine("TextBox changed , so exception thrown by combox conversion!!");
            }
            finally
            {
                try
                {
                    curTextBox = (TextBox)sender;
                    //      Console.WriteLine(curTextBox.Name);
                    if (curTextBox.Name == "textBox1")
                        convertRight = true;
                }
                catch
                {
                    Console.WriteLine("What are you doing bro!!!!!!!!!!!!!!!!!");
                }

            }



            //       Console.WriteLine(current.Name);
            //    if (current.Name == "comboBox1")
            //       convertRight = true;
            //Console.WriteLine(new StackFrame(1).GetMethod().Name);
            string baseFrom, baseTo; double userinput;
            if (convertRight == true)
            {
                // means user entetred input on the left side
                if (textBox1.Text == "") return;

                userinput = double.Parse(textBox1.Text);

                baseFrom = comboBox3.Text;
                baseTo = comboBox4.Text;
            }
            else
            {
                Console.WriteLine("3");
                // means user entetred input on the left side
                if (textBox2.Text == "") return;

                userinput = double.Parse(textBox2.Text);

                baseFrom = comboBox4.Text;   //interchanged
                baseTo = comboBox3.Text;

            }

            if (baseFrom == baseTo) { textBox2.Text = textBox1.Text; return; }
            //Console.WriteLine(userinput);

            double answer = 0;  // for case if converting from km to km
            if (true)
            {
                // these calculations based on km
                Console.WriteLine("4");
                if (baseTo == "Kilogram") answer = userinput;

                else if (baseTo == "Tonne")
                {
                    answer = userinput * 0.001;

                }
                else if (baseTo == "Gram")
                {
                    answer = userinput * 1000;
                }
                else if (baseTo == "Millgram")
                {
                    answer = userinput * 1e6;
                }
                else if (baseTo == "Microgram")
                {
                    answer = userinput * 1e9;
                }
                else if (baseTo == "Imperial ton")
                {
                    answer = userinput /1016;
                }
                else if (baseTo == "US ton")
                {
                    answer = userinput /907;
                }
                else if (baseTo == "Stone")
                {
                    Console.WriteLine(answer);
                    answer = userinput / 6.35;

                }
                else if (baseTo == "Pound")
                {
                    answer = userinput / 2.205;
                }
                else if (baseTo == "Ounce")
                {
                    answer = userinput * 35.274;
                }
                //else if (baseTo == "Nautical Mile")
                //{
                //    answer = userinput * 0.539957;
                //}

                if (baseFrom == "Tonne") answer = answer / 0.001;
                else if (baseFrom == "Gram") answer = answer / 1000;
                else if (baseFrom == "Millgram") answer = answer / 1e6;
                else if (baseFrom == "Microgram") answer = answer / 1e9;
                else if (baseFrom == "Imperial ton") answer = answer * 1016;
                else if (baseFrom == "US ton") answer = answer * 907;
                else if (baseFrom == "Stone") answer = answer * 6.35;
                else if (baseFrom == "Pound") answer = answer * 2.205;
                else if (baseFrom == "Ounce") answer = answer / 35.274;

                Console.WriteLine("5");
                Console.WriteLine(answer);
            }
            //2
            if (convertRight)
            { textBox2.Text = Convert.ToString(answer); return; }
            else
            {
                textBox1.Text = Convert.ToString(answer);
                Console.WriteLine("6");
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
