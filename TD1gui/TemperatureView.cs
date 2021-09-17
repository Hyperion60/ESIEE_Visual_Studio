using System;
using System.Windows.Forms;
using TD1cli;

namespace ESIEE_Visual_Studio
{
    public class TemperatureView
    {
        public static void temp_calc(TextBox fartemp, Label result, Label errors)
        {
            double temp = 0.0;
            bool state = true;
            errors.Text = "Erreurs :\n";
            try
            {
                temp = Convert.ToDouble(fartemp.Text);
            }
            catch (Exception e)
            {
                errors.Text += "Température invalide ou nulle";
                state = false;
            }

            if (state)
            {
                result.Text = Convert.ToString(Temperature.fahrenheit_to_celsius(temp));
            }
            else
            {
                result.Text = "-";
            }
        }

        public static void temp_init(TextBox fartemp, Label result, Label errors)
        {
            fartemp.Text = null;
            result.Text = "-";
            errors.Text = "Erreurs :\n";
        }
    }
}