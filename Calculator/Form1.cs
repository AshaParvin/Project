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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region Cancel Methods
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputBox.Text = string.Empty;
            FocusInputText();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputBox.Text.Length < 1 || this.UserInputBox.SelectionStart < 1)
            {
                return;
            }
            var SelectionStart = this.UserInputBox.SelectionStart;
           this.UserInputBox.Text = this.UserInputBox.Text.Remove(this.UserInputBox.SelectionStart-1, 1);
            SelectionStart--;
            this.UserInputBox.SelectionStart = SelectionStart;
            this.UserInputBox.SelectionLength = 0;



            FocusInputText();
        }
        #endregion
        #region  Operator Methods
        private void ModButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }
        #endregion

        #region Accept Method
        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

      
        #endregion
        #region Numerator Methods
        private void ZeroButton_Click(object sender, EventArgs e)
        {
           
            /* inserts 0 in the position(selectionStart) where cursor is placed */
            InsertTextValue("0");
            FocusInputText();
        }


        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }
        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }
        #endregion

        #region Calculation Method
        private void CalculateEquation()
        {

            
          

            this.UserResultLabel.Text= ParseOperation();

            

            FocusInputText();
        }

        //Parses User equation and calculates the result
        private string ParseOperation()
        {
            try
            {
                var userInput = this.UserInputBox.Text;   //getting user input values from textbox
                userInput.Replace(" ", ""); //ignoring spaces in the equation
                
                var operation = new Operation();
                var leftSide = true;
                int i;
                for (i =0;  i < userInput.Length; i++)
                {

                    //Any checks if input has any of the characters in 0123456789.
                    if ("0123456789.".Any(c => userInput[i] == c))
                    {
                        if (leftSide)
                            operation.Leftside += userInput[i];
                        else
                            operation.Rightside += userInput[i];
                        
                    } 
                    else if ("+-/%*".Any(c => userInput[i] == c))

                    {
                        // If we are on the right side . do the current operation and set the result to the leftside
                        if(!leftSide)
                        {
                            //Get the operator Type
                            var operatorType = GetOperationType(userInput[i]);

                            if (operation.Rightside.Length == 0) //checking if user presses something like 2+%
                            {
                                if (operatorType != OperationType.Minus) //keeping an exception for minus eg.3*-5-> 3*(-5)
                                    throw new InvalidOperationException("Enter a proper value.Cannot have more than 1 operator together");
                                //If we get here then the equation might have a minus value eg.3*-5-> 3*(-5)
                                //So we are appending the minus operator to the number
                                operation.Rightside += userInput[i];
                            }
                            else
                            {
                                //calculating the 1st equation and setting the results to the left side
                                operation.Leftside = CalculateOperation(operation);// here the parameter contains an equation(1+2)
                                                                                   //Now set new operator(when there is more than 1)
                                operation.OperationType = operatorType;
                                //clear the previous rightside number
                                operation.Rightside = string.Empty;
                            }
                        }
                        else
                        {
                            //Getting the operators
                            var operatorType = GetOperationType(userInput[i]);
                           
                            if(operation.Leftside.Length==0) //checking the 1st char (if an operator)
                            {
                                if (operatorType != OperationType.Minus) //keeping an exception for minus eg.-2+3
                                    throw new InvalidOperationException("Enter a proper value.Cannot start with an Operator");
                                //If we get here then the 1st number precedes with a minus 
                                //So we are appending the minus operator to the number
                                operation.Leftside += userInput[i];
                            }
                            else
                            {
                                //If we get here we have a leftside number and an operator so we can move to the right side

                                //Set the OperationType now
                                operation.OperationType = operatorType;

                                //Move to the right side of the operator
                                leftSide = false;
                            }
                        }
                    }
                }
                // We have done parsing. Now we have a valid equation
                //Calculate the current Operation.
                return CalculateOperation(operation); 
                 
            }
            catch(Exception e)
            { 
                return "Invalid Equation" + e.Message;
            }
        }

        private string CalculateOperation(Operation operation)
        {
            //Giving values to the String representation of left and right side equation
            double left=0;
            double right = 0;

            //Checking if the leftside of the operator is a valid number
            if (!double.TryParse(operation.Leftside, out left))
                throw new InvalidExpressionException($"Enter a number before the operator");
            
            //Checking if the rightside of the operator is a valid number
            if (!double.TryParse(operation.Rightside, out right))
                throw new InvalidExpressionException($"Enter a number after the operator");
            //Operations
            try
            {
                switch(operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString(); //explicitly converting double to string representation
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Mod:
                        return (left % right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown Operator");

                }
            }
            catch(Exception e)
            {
                throw new InvalidOperationException($"Failed to calculate{ operation.Leftside } { operation.OperationType} { operation.Rightside}.{ e.Message}");

               
            }
           

        }

        #endregion

        #region Private Methods

        private OperationType GetOperationType(char Char)
        {

            switch (Char)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                case '%':
                    return OperationType.Mod;
                default:
                   throw new InvalidOperationException($"InvalidOperator");
            }
        }
        private void FocusInputText()
        {
            this.UserInputBox.Focus();   //Focus of cursor remains on this textbox
        }

        private void InsertTextValue(string value)
        {
            //initialising Selectionstart(place of cursor =eg : hello. if curson is after h .the index value of selection start is 1)
            var SelectionStart = this.UserInputBox.SelectionStart;
            //input value entered by user
            this.UserInputBox.Text = this.UserInputBox.Text.Insert(this.UserInputBox.SelectionStart, value);

            /** now selectionstart is reset . he|llo .if selectionstart is 2 here . and as value ll is added .now selectionstart(ie cursor)
            is changed to index value 4. ie.curson position is moved to index value 4**/

            this.UserInputBox.SelectionStart = SelectionStart + value.Length;
           this.UserInputBox.SelectionLength = 0;
        }


        #endregion

        
    }
}
