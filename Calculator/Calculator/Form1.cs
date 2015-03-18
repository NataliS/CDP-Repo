using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Double resultValue = 0;
        private string operatorPerformed = " ";
        private bool isOperationPerformed = false;


        public Form1()
        {
            InitializeComponent();
        }

       
        private void ClickTheButton(object sender, EventArgs e)
        {

            if ((textBox.Text == "0") || (isOperationPerformed))
                textBox.Clear();
            isOperationPerformed = false;
            Button button = (Button) sender;
            if (button.Text == ".") 
             {
                 if (!textBox.Text.Contains("."))
                 {
                     textBox.Text = textBox.Text + button.Text;
                 }
             }
             else
                
                 textBox.Text = textBox.Text + button.Text;
        if(textBox.Text==".")
            {
                textBox.Text = "0.";
            }
        if (button.Name == "buttonPi")
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1) + "3.14159265";
            }

        }

        private void ClickTheOperator(object sender, EventArgs e)
      {
          Button button = (Button)sender;
         if ((resultValue >0)||(resultValue<0))
          {
              buttonResult.PerformClick();
              operatorPerformed = button.Text;
              buttonLabel.Text = resultValue + " " + operatorPerformed;
             textBox.Text = resultValue.ToString();
             isOperationPerformed = true;
             }
          else
          {
              operatorPerformed = button.Text;
              resultValue = Double.Parse(textBox.Text);
              buttonLabel.Text = resultValue + " " + operatorPerformed;
              textBox.Text = resultValue.ToString();
             isOperationPerformed = true;
          }    

      }

   private void ClickClearCe(object sender, EventArgs e)
      {
          textBox.Text = "0";
          resultValue = 0;
          buttonLabel.Text = null;
      }

   private void ClickDelete(object sender, EventArgs e)
   {
       if (textBox.TextLength > 0)
           textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);

   }
      private void ClickResultButton(object sender, EventArgs e)
      {
          switch (operatorPerformed)
          {
              case "+":
                  textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                  break;

              case "-":
                  textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                  break;

              case "*":
                  textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                  break;

              case "/":
                  textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                  break;

              case "sin":
                  textBox.Text = (Math.Sin(Double.Parse(textBox.Text)).ToString());
                  break;

              case "cos":
                  textBox.Text = (Math.Cos(Double.Parse(textBox.Text)).ToString());
;                  break;

              case "tg":
                  textBox.Text = (Math.Tan(Double.Parse(textBox.Text)).ToString());
                  break;

              case "log":
                  textBox.Text = (Math.Log(Double.Parse(textBox.Text)).ToString());
                  break;

              case "exp":
                  textBox.Text = (Math.Exp(Double.Parse(textBox.Text)).ToString());
                  break;

              case "sqrt":
                  textBox.Text = (Math.Sqrt(Double.Parse(textBox.Text)).ToString());
                  break;

         default:
                  break;

          }
         resultValue = Double.Parse(textBox.Text);
         buttonLabel.Text = " ";
      }

     

     

  

      
        
    }
}
