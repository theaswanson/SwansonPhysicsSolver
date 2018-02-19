using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            const double PRECISION = 0.01;

            double InitialX, FinalX, InitialY, FinalY, InitialV, FinalV, A, T;
            InitialX = FinalX = InitialY = FinalY = InitialV = FinalV = A = T = 0;

            bool hasInitialX, hasFinalX, hasInitialY, hasFinalY, hasInitialV, hasFinalV, hasA, hasT;
            hasInitialX = hasFinalX = hasInitialY = hasFinalY = hasInitialV = hasFinalV = hasA = hasT = false;

            //get text from text boxes
            if (HasText(InitialXTextBox))
            {
                hasInitialX = true;
                InitialX = double.Parse(InitialXTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(FinalXTextBox))
            {
                hasFinalX = true;
                FinalX = double.Parse(FinalXTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(InitialYTextBox))
            {
                hasInitialY = true;
                InitialY = double.Parse(InitialYTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(FinalYTextBox))
            {
                hasFinalY = true;
                FinalY = double.Parse(FinalYTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(InitialVTextBox))
            {
                hasInitialV = true;
                InitialV = double.Parse(InitialVTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(FinalVTextBox))
            {
                hasFinalV = true;
                FinalV = double.Parse(FinalVTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(ATextBox))
            {
                hasA = true;
                A = double.Parse(ATextBox.Text, CultureInfo.InvariantCulture);
            }
            if (HasText(TTextBox))
            {
                hasT = true;
                T = double.Parse(TTextBox.Text, CultureInfo.InvariantCulture);
            }

            bool exhausted = false;
            bool solvedSomething = false;

            while (!exhausted)
            {
                exhausted = false;
                solvedSomething = false;

                // if initial x, final x, and velocity exist
                // distance, time, velocity

                if (!hasFinalX && Convert.ToInt32(hasT) == 1 && (Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasFinalV)) == 1)
                {
                    if (!hasInitialX)
                    {
                        InitialX = 0;
                        InitialXTextBox.Text = InitialX.ToString();
                    }
                    
                    if (hasInitialV)
                    {
                        FinalX = InitialV * T;
                        FinalXTextBox.Text = FinalX.ToString();

                        FinalV = InitialV;
                        FinalVTextBox.Text = FinalV.ToString();

                        hasFinalV = true;
                    }
                    else if (hasFinalV)
                    {
                        FinalX = FinalV * T;
                        FinalXTextBox.Text = FinalX.ToString();

                        InitialV = FinalV;
                        InitialVTextBox.Text = InitialV.ToString();

                        hasInitialV = true;
                    }
                    
                    hasInitialX = true;
                    hasFinalX = true;
                    solvedSomething = true;
                }

                // if 3 of 4 variables exist for equation 1
                if (Convert.ToInt32(hasFinalV) + Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasA) + Convert.ToInt32(hasT) == 3)
                {
                    if (!hasFinalV) // solve for final velocity
                    {
                        //calculate variable
                        FinalV = InitialV + A * T;

                        //set text box to answer
                        FinalVTextBox.Text = FinalV.ToString();
                        hasFinalV = true;
                        solvedSomething = true;
                    }
                    else if (!hasInitialV) // solve for intial velocity
                    {
                        //calculate variable
                        InitialV = FinalV - A * T;

                        //set text box to answer
                        InitialVTextBox.Text = InitialV.ToString();
                        hasInitialV = true;
                        solvedSomething = true;
                    }
                    else if (!hasA) // solve for acceleration
                    {
                        if (T == 0)
                        {
                            MessageBox.Show("Cannot solve for acceleration: time is 0.");
                        }
                        else
                        {
                            //calculate variable
                            A = (FinalV - InitialV) / T;

                            //set text box to answer
                            ATextBox.Text = A.ToString();
                            hasA = true;
                            solvedSomething = true;
                        }
                    }
                    else if (!hasT) // solve for time
                    {
                        if (A == 0)
                        {
                            MessageBox.Show("Cannot solve for time: acceleration is 0.");
                        }
                        else
                        {
                            //calculate variable
                            T = (FinalV - InitialV) / A;

                            //set text box to answer
                            TTextBox.Text = T.ToString();
                            hasT = true;
                            solvedSomething = true;
                        }
                    }
                }
                else if (Convert.ToInt32(hasFinalV) + Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasA) + Convert.ToInt32(hasT) == 4)
                {
                    if (Math.Abs(FinalV - (InitialV + A * T)) > PRECISION)
                    {
                        MessageBox.Show("Values are incorrect.", "Input Validation");
                    }
                }


                // if 4 of 5 variables exist for equation 2
                if (Convert.ToInt32(hasFinalX) + Convert.ToInt32(hasInitialX) + Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasA) + Convert.ToInt32(hasT) == 4)
                {
                    if (!hasFinalX) // solve for final x position
                    {
                        //calculate variable
                        FinalX = InitialX + InitialV * T + 0.5 * A * Math.Pow(T, 2);

                        //set text box to answer
                        FinalXTextBox.Text = FinalX.ToString();
                        hasFinalX = true;
                        solvedSomething = true;
                    }
                    else if (!hasInitialX) // solve for initial x position
                    {
                        //calculate variable
                        InitialX = FinalX - (InitialV * T + 0.5 * A * Math.Pow(T, 2));

                        //set text box to answer
                        InitialXTextBox.Text = InitialX.ToString();
                        hasInitialX = true;
                        solvedSomething = true;
                    }
                    else if (!hasInitialV) // solve for initial velocity
                    {
                        if (T == 0)
                        {
                            MessageBox.Show("Cannot solve for initial velocity: time is 0.");
                        }
                        else
                        {
                            //calculate variable
                            InitialV = (FinalX - InitialX - 0.5 * A * Math.Pow(T, 2)) / T;

                            //set text box to answer
                            InitialVTextBox.Text = InitialV.ToString();
                            hasInitialV = true;
                            solvedSomething = true;
                        }

                    }
                    else if (!hasA) // solve for acceleration
                    {
                        if (T == 0)
                        {
                            MessageBox.Show("Cannot solve for acceleration: time is 0.");
                        }
                        else
                        {
                            A = 2 * (FinalX - InitialX - InitialV * T) / Math.Pow(T, 2);
                            ATextBox.Text = A.ToString();
                            hasA = true;
                            solvedSomething = true;
                        }
                    }
                    else if (!hasT) // solve for time
                    {
                        double a = 0.5 * A;
                        double b = InitialV;
                        double c = InitialX - FinalX;

                        double sqrtpart = (b * b) - (4 * a * c);
                        double answer1 = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
                        double answer2 = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);

                        if (answer1 >= 0 && answer2 >= 0)
                        {
                            TTextBox.Text = answer1.ToString() + " and " + answer2.ToString();
                            T = answer2;
                            hasT = true;
                            solvedSomething = true;
                        }
                        else if (answer1 < 0 && answer2 >= 0)
                        {
                            TTextBox.Text = answer2.ToString();
                            T = answer2;
                            hasT = true;
                            solvedSomething = true;
                        }
                        else if (answer2 < 0 && answer1 >= 0)
                        {
                            TTextBox.Text = answer1.ToString();
                            T = answer1;
                            hasT = true;
                            solvedSomething = true;
                        }
                        else
                        {
                            TTextBox.Text = "Error: Negative time";
                        }

                    }
                }
                else if (Convert.ToInt32(hasFinalX) + Convert.ToInt32(hasInitialX) + Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasA) + Convert.ToInt32(hasT) == 5)
                {
                    if (Math.Abs(FinalX - (InitialX + InitialV * T + 0.5 * A * Math.Pow(T, 2))) > PRECISION)
                    {
                        MessageBox.Show("Values are incorrect.", "Input Validation");
                    }
                }

                // if 4 of 5 variables exist for equation 3
                if (Convert.ToInt32(hasFinalX) + Convert.ToInt32(hasInitialX) + Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasFinalV) + Convert.ToInt32(hasT) == 4)
                {
                    if (!hasFinalX)
                    {
                        //calculate variable
                        FinalX = InitialX + 0.5 * (InitialV + FinalV) * T;

                        //set text box to answer
                        FinalXTextBox.Text = FinalX.ToString();
                        hasFinalX = true;
                        solvedSomething = true;
                    }
                    else if (!hasInitialX)
                    {
                        //calculate variable
                        InitialX = FinalX - 0.5 * (InitialV + FinalV) * T;

                        //set text box to answer
                        InitialXTextBox.Text = InitialX.ToString();
                        hasInitialX = true;
                        solvedSomething = true;
                    }
                    else if (!hasInitialV)
                    {
                        if (T == 0)
                        {
                            MessageBox.Show("Cannot solve for initial velocity: time is 0.");
                        }
                        else
                        {
                            //calculate variable
                            InitialV = 2 * (FinalX - InitialX) / T - FinalV;

                            //set text box to answer
                            InitialVTextBox.Text = InitialV.ToString();
                            hasInitialV = true;
                            solvedSomething = true;
                        }

                    }
                    else if (!hasFinalV)
                    {
                        if (T == 0)
                        {
                            MessageBox.Show("Cannot solve for final velocity: time is 0.");
                        }
                        else
                        {
                            //calculate variable
                            FinalV = 2 * (FinalX - InitialX) / T - InitialV;

                            //set text box to answer
                            FinalVTextBox.Text = FinalV.ToString();
                            hasFinalV = true;
                            solvedSomething = true;
                        }
                    }
                    else if (!hasT)
                    {
                        if (InitialV + FinalV == 0)
                        {
                            MessageBox.Show("Cannot solve for time: the sum of initial velocity and final velocity is 0.");
                        }
                        else
                        {
                            //calculate variable
                            T = 2 * (FinalX - InitialX) / (InitialV + FinalV);

                            //set text box to answer
                            TTextBox.Text = T.ToString();
                            hasT = true;
                            solvedSomething = true;
                        }
                    }
                }
                else if (Convert.ToInt32(hasFinalX) + Convert.ToInt32(hasInitialX) + Convert.ToInt32(hasInitialV) + Convert.ToInt32(hasFinalV) + Convert.ToInt32(hasT) == 5)
                {
                    if (Math.Abs(FinalX - (InitialX + 0.5 * (InitialV + FinalV) * T)) > PRECISION)
                    {
                        MessageBox.Show("Values are incorrect.", "Input Validation");
                    }
                }

                // if 4 of 5 variables exist for equation 4
                if (Convert.ToInt32(hasA) + Convert.ToInt32(hasFinalX) + Convert.ToInt32(hasInitialX) + Convert.ToInt32(hasFinalV) + Convert.ToInt32(hasInitialV) == 4)
                {
                    if (!hasA) // solve for acceleration
                    {
                        if (FinalX == InitialX)
                        {
                            MessageBox.Show("Cannot solve for acceleration: final x position and initial x position are the same");
                        }
                        else
                        {
                            //calculate variable
                            A = 0.5 * (Math.Pow(FinalV, 2) - Math.Pow(InitialV, 2)) / (FinalX - InitialX);

                            //set text box to answer
                            ATextBox.Text = A.ToString();
                            hasA = true;
                            solvedSomething = true;
                        }
                    }
                    else if (!hasFinalX)
                    {
                        if (A == 0)
                        {
                            MessageBox.Show("Cannot solve for final x position: acceleration is zero.");
                        }
                        else
                        {
                            FinalX = (Math.Pow(FinalV, 2) - Math.Pow(InitialV, 2)) / (2 * A) + InitialX;

                            FinalXTextBox.Text = FinalX.ToString();
                            hasFinalX = true;
                            solvedSomething = true;
                        }
                    }
                    else if (!hasInitialX)
                    {
                        if (A == 0)
                        {
                            MessageBox.Show("Cannot solve for initial x position: acceleration is zero.");
                        }
                        else
                        {
                            InitialX = FinalX - (Math.Pow(FinalV, 2) - Math.Pow(InitialV, 2)) / (2 * A);

                            InitialXTextBox.Text = InitialX.ToString();
                            hasInitialX = true;
                            solvedSomething = true;
                        }
                    }
                    else if (!hasFinalV)
                    {
                        FinalV = Math.Sqrt(2 * A * (FinalX - InitialX) + Math.Pow(InitialV, 2));

                        FinalVTextBox.Text = FinalV.ToString();
                        hasFinalV = true;
                        solvedSomething = true;
                    }
                    else if (!hasInitialV)
                    {
                        InitialV = Math.Sqrt(Math.Pow(FinalV, 2) - (2 * A * (FinalX - InitialX)));

                        InitialVTextBox.Text = InitialV.ToString();
                        hasInitialV = true;
                        solvedSomething = true;
                    }
                }
                else if (Convert.ToInt32(hasA) + Convert.ToInt32(hasFinalX) + Convert.ToInt32(hasInitialX) + Convert.ToInt32(hasFinalV) + Convert.ToInt32(hasInitialV) == 5)
                {
                    if (Math.Abs(2 * A * (FinalX - InitialX) - Math.Pow(FinalV, 2) + Math.Pow(InitialV, 2)) > PRECISION)
                    {
                        MessageBox.Show("Values are incorrect.", "Input Validation");
                    }
                }

                if (solvedSomething == false) // if we were unable to solve for any variables
                {
                    exhausted = true; // we've exhausted all our options
                }

            }

            MessageBox.Show("Finished solving.");
        }

        private bool HasText(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Sanitize(double InitialX, double FinalX, double InitialV, double FinalV, double A, double T)
        {
            if (HasText(InitialXTextBox))
            {
                InitialX = double.Parse(InitialXTextBox.Text);
            }
            if (HasText(FinalXTextBox))
            {
                FinalX = double.Parse(FinalXTextBox.Text);
            }
            if (HasText(InitialVTextBox))
            {
                InitialV = double.Parse(InitialVTextBox.Text);
            }
            if (HasText(FinalVTextBox))
            {
                FinalV = double.Parse(FinalVTextBox.Text);
            }
            if (HasText(ATextBox))
            {
                A = double.Parse(ATextBox.Text);
            }
            if (HasText(TTextBox))
            {
                T = double.Parse(TTextBox.Text);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InitialXTextBox.Text = FinalXTextBox.Text = InitialYTextBox.Text = FinalYTextBox.Text = InitialVTextBox.Text = FinalVTextBox.Text = ATextBox.Text = TTextBox.Text = "";
        }
    }
}
