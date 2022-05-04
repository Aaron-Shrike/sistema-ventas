using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;
using MetroFramework.Controls;

namespace Ventas
{
    public class Validaciones
    {
        public static void SonidoError()
        {
            SystemSounds.Beep.Play();
        }


        public static bool NumeroDigitosValido(MetroTextBox textBox, out string msgError, string nombreCampo, int digitosObligatorios, string msgErrorDefecto = "")
        {
            string text = textBox.Text.Trim();

            textBox.Text = text;//borrar los espacios del Text

            if (string.IsNullOrEmpty(text) == true)
            {
                msgError = "Debe indicar el campo " + nombreCampo;
                return false;
            }

            textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);//color rojo indicando error

            if (text.All(char.IsNumber) != true)
            {
                msgError = "El " + nombreCampo + " es numérico";
                return false;
            }

            if (text.Length == digitosObligatorios)
            {
                textBox.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);//restablece el color
                msgError = "";
                return true;
            }

            if (text.Length > digitosObligatorios)
            {
                msgError = "El " + nombreCampo + " excede en dígitos(" + digitosObligatorios + " dígitos permitidos)";
                return false;
            }

            if (text.Length < digitosObligatorios)
            {
                msgError = "Le faltan dígitos al " + nombreCampo + "(" + digitosObligatorios + " dígitos permitidos)";
                return false;
            }

            msgError = msgErrorDefecto;
            return false;
        }

        public static bool TextoValido(MetroTextBox textBox, out string msgError, string nombreCampo, int digitosMinimos = 0, string msgErrorDefecto = "")
        {
            string text = textBox.Text.Trim();

            textBox.Text = text;//borrar los espacios del Text

            if (string.IsNullOrEmpty(text) == true)
            {
                msgError = "Debe indicar el campo " + nombreCampo;
                return false;
            }

            textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);//color rojo indicando error

            if (text.Length >= digitosMinimos)
            {
                textBox.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);//restablece el color
                msgError = "";
                return true;
            }

            msgError = msgErrorDefecto;
            return false;
        }

        public static bool CorreoValido(MetroTextBox textBox, out string msgError, string msgErrorDefecto = "")
        {
            string text = textBox.Text.Trim();

            textBox.Text = text;//borrar los espacios del Text

            if (string.IsNullOrEmpty(text) == true)
            {
                msgError = "Debe indicar un Correo";
                return false;
            }

            textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);//color rojo indicando error

            string expresion = @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$";
            
            if (Regex.IsMatch(text, expresion) && Regex.Replace(text, expresion, String.Empty).Length == 0)
            {
                textBox.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);//restablece el color
                msgError = "";
                return true;
            }

            msgError = msgErrorDefecto;
            return false;
        }

        public static bool TextoRepetidoValido(MetroTextBox textBoxOriginal, MetroTextBox textBox, out string msgError, string nombreCampo, string msgErrorDefecto = "")
        {
            string textOriginal = textBoxOriginal.Text;
            string text = textBox.Text;

            //textBoxRepetido.Text = textRepetido;//borrar los espacios del Text

            if (string.IsNullOrEmpty(text) == true)
            {
                msgError = "Debe indicar el campo " + nombreCampo;
                return false;
            }

            textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);//color rojo indicando error

            if (text.Equals(textOriginal))
            {
                textBox.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);//restablece el color
                msgError = "";
                return true;
            }

            msgError = msgErrorDefecto;
            return false;
        }
    }
}
