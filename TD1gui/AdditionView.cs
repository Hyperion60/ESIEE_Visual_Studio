using System;
using System.Windows.Forms;
using TD1cli;


namespace ESIEE_Visual_Studio
{
    public class AdditionView
    {
        public static void result_Click(TextBox number1, TextBox number2, Label result, Label error)
        {
            int int1 ,int2;
            bool state = true;
            error.Text = "Erreurs :\n";
            try
            {
                int1 = Convert.ToInt32(number1.Text);
            }
            catch (Exception e)
            {
                error.Text += "Nombre 1 : Entrée invalide ou nulle\n";
                state = false;
            }

            try
            {
                int2 = Convert.ToInt32(number2.Text);
            }
            catch (Exception e)
            {
                error.Text += "Nombre 2 : Entrée invalide ou nulle\n";
                state = false;
            }

            if (state)
            {
                int res = Addition.sum(Convert.ToInt32(number1.Text), Convert.ToInt32(number2.Text));
                result.Text = Convert.ToString(res);
            }
            else
            {
                result.Text = "-";
            }
        }

        public static void init_Click(TextBox number1, TextBox number2, Label result, Label errors)
        {
            number1.Text = "";
            number2.Text = "";
            result.Text = "-";
            errors.Text = "Erreurs :\n";
        }
    }
}