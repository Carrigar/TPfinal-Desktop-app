using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public class Helper
    {
        public void mostrarImagen(string url, PictureBox ubicacion)
        {
            try
            {
                ubicacion.Load(url);
            }
            catch (Exception)
            {
                ubicacion.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
        public void ocultarColumna(string columna1, string columna2, string columna3, DataGridView ubicacion)
        {
            ubicacion.Columns[columna1].Visible = false;
            ubicacion.Columns[columna2].Visible = false;
            ubicacion.Columns[columna3].Visible = false;
        }
        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

    }
}
