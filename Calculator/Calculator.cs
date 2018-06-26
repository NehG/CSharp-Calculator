using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Calculator : Form
    {

        // A decimal that stores the result currently displayed by the calculator.
        private float currentValue;

        // A decimal that stores the value of the first operand.
        private float operand1;

        // A decimal that stores the value of the second operand.
        private float operand2;

        // An Operator type that stores a member of the Operator enumeration.
        private String op;

        // An enumeration with these constants: Add, Subtract, Multiply, Divide, and None.
        private enum Operator{
            Add = '+',
            Subtract = '-',
            Multiply = '*',
            Divide = '/',
            None = ' '
        };

        // A boolean which checks if operand2 has to be changed.
        private bool changeOperand2;

        // Instantiating ViewHistory with variable vh.
        ViewHistory vh = new ViewHistory();

        public Calculator()
        {
            InitializeComponent();
            // The default value for the op field is Operator.None.
            op = (Operator.None).ToString();
            // The Default for changeOperand2 is true.
            changeOperand2 = true;
            // Start Up Message.
            LabelEqu.Text = "Welcome To NehCalc";
            // View History Keyboard Shortcut.
            NumberTextBox.Text = "Use 'H' to View History";
            // Timer For Clearing Out All Start Up Messages.
            var t = new Timer();
            t.Interval = 1500;
            t.Tick += (s, e) =>
            {
                // Clearing All Out And Stopping Timer.
                LabelEqu.Text = "";
                NumberTextBox.Text = "";
                t.Stop();
            };
            // Starting Timer.
            t.Start();
        }

        // Gets the value of the currentValue field.
        public string CurrentValue()
        {
            return currentValue.ToString().Trim();
        }

        // Setting currentValue and operand2 after checking our boolean state.
        public void Add(string displayValue)
        { 
            float.TryParse(displayValue.Trim(), out currentValue);
            // If Operation(+, -, /, *) Is Not Changed Then Using Same Operand2 On Ans.
            if(changeOperand2 == false)
            {
                LabelEqu.Text = operand1.ToString() + " + " + operand2.ToString() + " = ";
                // Using PreSet Operand2 With Number Passed To It And Storing It As Operand1.
                operand1 = currentValue + operand2;
            }
            // If Operation(+, -, /, *) Is Changed Then Changing Operand2.
            else
            {
                // Fix Operand2 Until User Changes Operation. 
                operand2 = currentValue;
                LabelEqu.Text = operand1.ToString() + " + " + operand2.ToString() + " = ";
                // Performing Operation On Operand1 And CurrentValue.
                operand1 = operand1 + currentValue;
                changeOperand2 = false;
            }
        }

        // Subtract After Checking Our Boolean State.
        public void Subtract(string displayValue)
        {
            float.TryParse(displayValue.Trim(), out currentValue);
            if (changeOperand2 == false)
            {
                LabelEqu.Text = operand1.ToString() + " - " + operand2.ToString() + " = ";
                operand1 = currentValue - operand2;
            }
            else
            {
                operand2 = currentValue;
                LabelEqu.Text = operand1.ToString() + " - " + operand2.ToString() + " = ";
                operand1 = operand1 - currentValue;
                changeOperand2 = false;
            }
        }

        // Multiplication After Checking Our Boolean State.
        public void Multiply(string displayValue)
        {
            float.TryParse(displayValue.Trim(), out currentValue);
            if (changeOperand2 == false)
            {
                LabelEqu.Text = operand1.ToString() + " * " + operand2.ToString() + " = ";
                operand1 = currentValue * operand2;
            }
            else
            {
                operand2 = currentValue;
                LabelEqu.Text = operand1.ToString() + " * " + operand2.ToString() + " = ";
                operand1 = operand1 * currentValue;
                changeOperand2 = false;
            }
        }

        // Division After Checking Our Boolean State.
        public void Divide(string displayValue)
        {
            float.TryParse(displayValue.Trim(), out currentValue);
            // Using Try-Catch For DivideByZeroException
            try{
                if (changeOperand2 == false)
                {
                    // Explicitly Throwing Error If Denominator Is Zero.
                    if (operand2 != 0)
                    {
                        LabelEqu.Text = operand1.ToString() + " / " + operand2.ToString() + " = ";
                        operand1 = currentValue / operand2;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                }
                else
                {
                    if (currentValue != 0)
                    {
                        operand2 = currentValue;
                        LabelEqu.Text = operand1.ToString() + " / " + operand2.ToString() + " = ";
                        operand1 = operand1 / currentValue;
                        changeOperand2 = false;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                }
            }
            catch (DivideByZeroException)
            {
                // Resetting Everything And Displaying Error.
                ClearBtn.PerformClick();
                LabelEqu.Text = "ERR";
                // Adding It To Our History.
                vh.addHistory = LabelEqu.Text;
            }
        }

        // Clear Button ClickEvent.
        private void button1_Click(object sender, EventArgs e)
        {
            // Reset All To Defaults.
            op = Operator.None.ToString();
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            changeOperand2 = true;
            LabelEqu.Text = "All Clear";
            NumberTextBox.Text = "";
            vh.addHistory = LabelEqu.Text;
        }

        // '0' Button ClickEvent.
        private void Btn0_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("0");
        }

        // '1' Button ClickEvent.
        private void Btn1_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("1");
        }

        // '2' Button ClickEvent.
        private void Btn2_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("2");
        }

        // '3' Button ClickEvent.
        private void Btn3_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("3");
        }

        // '4' Button ClickEvent.
        private void Btn4_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("4");
        }

        // '5' Button Click Event.
        private void Btn5_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("5");
        }

        // '6' Button Click Event.
        private void Btn6_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("6");
        }

        // '7' Button Click Event.
        private void Btn7_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("7");
        }

        // '8' Button Click Event.
        private void Btn8_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("8");
        }

        // '9' Button Click Event.
        private void Btn9_Click(object sender, EventArgs e)
        {
            NumberTextBox.AppendText("9");
        }

        // '.' Button Click Event.
        private void BtnPoint_Click(object sender, EventArgs e)
        {
            // Check If NumberTextBox Contains A Number That Is Already Decimal.
            if(NumberTextBox.Text.Contains(".") != true)
                 NumberTextBox.AppendText(".");
        }

        // '+' Button Click Event.
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            // TryParse NumberTextBox Text To Float And As Operand1.
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            NumberTextBox.Text = "";
            // Set op variable to Add Operation.
            op = (Operator.Add).ToString();
            // Text To Display On Label.
            LabelEqu.Text = operand1.ToString() + " + ";
            // Changing State of changeOperand2 To Yes So We Can Accept Second Number.
            changeOperand2 = true;
        }

        // '-' Button Click Event.
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            NumberTextBox.Text = "";
            // Set op variable to Subtract Operation.
            op = (Operator.Subtract).ToString();
            LabelEqu.Text = operand1.ToString() + " - ";
            changeOperand2 = true;
        }

        // '*' Button Click Event.
        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            NumberTextBox.Text = "";
            // Set op variable to Multiply Operation.
            op = (Operator.Multiply).ToString();
            LabelEqu.Text = operand1.ToString() + " * ";
            changeOperand2 = true;
        }

        // '/' Button Click Event.
        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            NumberTextBox.Text = "";
            // Set op variable to Division Operation.
            op = (Operator.Divide).ToString();
            LabelEqu.Text = operand1.ToString() + " / ";
            changeOperand2 = true;
        }

        // 'Sqrt' Button Click Event.
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            // Using Math.Sqrt To Get Square Root Of Number In TextBox.
            NumberTextBox.Text = Math.Sqrt(operand1).ToString();
            LabelEqu.Text = "\u221A"+operand1.ToString()+" = ";
            vh.addHistory = LabelEqu.Text + NumberTextBox.Text.ToString();
        }

        // '1/X' Button Click Event.
        private void Btn1ByX_Click(object sender, EventArgs e)
        {
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            // Using 1 / (Entered Number) To Do Reciprocal Of It.
            NumberTextBox.Text = (1/operand1).ToString();
            LabelEqu.Text = "1 / "+operand1.ToString()+" = ";
            vh.addHistory = LabelEqu.Text + NumberTextBox.Text.ToString();
        }

        // '+/-' Button Click Event.
        private void BtnMean_Click(object sender, EventArgs e)
        {
            float.TryParse(NumberTextBox.Text.Trim(), out operand1);
            // Using -1 To Change Signes Of Number In TextBox.
            NumberTextBox.Text = (operand1 * (-1)).ToString();
            LabelEqu.Text = operand1.ToString()+" * -1 = ";
            vh.addHistory = LabelEqu.Text + NumberTextBox.Text.ToString();
        }

        // 'Back' Button Click Event.
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // Check If There Is Number In TextBox That Is To Be Deleted.
            if(NumberTextBox.Text.Length > 0)
               NumberTextBox.Text = NumberTextBox.Text.Remove(NumberTextBox.Text.Length-1);
        }

        // '=' Button Click Event.
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            // Switch On Operation That Is To Be Performed On Both Operands.
            switch (op)
            {
                case "Add":         { Add(NumberTextBox.Text); break; }
                case "Subtract":    { Subtract(NumberTextBox.Text); break; }
                case "Multiply":    { Multiply(NumberTextBox.Text); break; }
                case "Divide":      { Divide(NumberTextBox.Text); break; }
            }
            // Displaying Result To TextBox Named 'NumberTextBox'.
            NumberTextBox.Text = operand1.ToString();
            // Adding Whole Equation To Our History.
            vh.addHistory = LabelEqu.Text+operand1.ToString();
        }

        // Keyboard Keys Events.
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            // Using Switch To Perform Various Key Events.
            switch (e.KeyCode)
            {
                case Keys.NumPad1: { Btn1.PerformClick(); break; }
                case Keys.NumPad2: { Btn2.PerformClick(); break; }
                case Keys.NumPad3: { Btn3.PerformClick(); break; }
                case Keys.NumPad4: { Btn4.PerformClick(); break; }
                case Keys.NumPad5: { Btn5.PerformClick(); break; }
                case Keys.NumPad6: { Btn6.PerformClick(); break; }
                case Keys.NumPad7: { Btn7.PerformClick(); break; }
                case Keys.NumPad8: { Btn8.PerformClick(); break; }
                case Keys.NumPad9: { Btn9.PerformClick(); break; }
                case Keys.NumPad0: { Btn0.PerformClick(); break; }
                case Keys.Back: { BackBtn.PerformClick(); break; }
                case Keys.Add: { BtnPlus.PerformClick(); break; }
                case Keys.Subtract: { BtnMinus.PerformClick(); break; }
                case Keys.Divide: { BtnDivision.PerformClick(); break; }
                case Keys.Multiply: { BtnMultiple.PerformClick(); break; }
                case Keys.Decimal: { BtnPoint.PerformClick(); break; }
                case Keys.Oemplus: { BtnEquals.PerformClick(); break; }
                case Keys.H: { vh.Show(); break; }
                default: break;
            }
        }

        // 'CE' Button Click Event.
        private void BtnCE_Click(object sender, EventArgs e)
        {
            // Check If Operator Is Set Before Removing Operand2.
            if(op != Operator.None.ToString())
            {
                NumberTextBox.Text = "";
            }

        }

        // 'View History' Button ClickEvent.
        private void ViewHistory_Click(object sender, EventArgs e)
        {
            // Show View History Form.
            vh.Show();
        }
    }
}
