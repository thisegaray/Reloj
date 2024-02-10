using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojGuia2
{
    public partial class Pantalla : Form
    {
        public class Reloj
        {
            // Variables locales
            private int hora = 12;
            private int minutos = 0;
            private string meridiano = "";
            private Graphics lienzo;

            // Enums
            private enum Numeros
            {
                CERO = 0,
                UNO = 1,
                DOS = 2,
                TRES = 3,
                CUATRO = 4,
                CINCO = 5,
                SEIS = 6,
                SIETE = 7,
                OCHO = 8,
                NUEVE = 9
            }

            // Métodos Constructores
            public Reloj() { }
            public Reloj(int Hora24, int Min)
            {
                // MessageBox.Show($"Son las {Hora24}:{Min}");
            }

            // Métodos privados
            private string ComprobarTiempo(int Hora24)
            {
                if (Hora24 > 12)
                {
                    return "pm";
                }
                else if (Hora24 <= 12)
                {
                    return "am";
                }
                else
                {
                    MessageBox.Show("Hora no válida");
                    return "";
                }
            }

            public void DibujarNumeros(Graphics lienzo, Point Ubicacion, int Hora24, int Min)
            {
                switch(Hora24)
                {
                    case 1:
                        {
                            Size tamanio = new Size(10, 50);
                            Brush pincel = new SolidBrush(Color.Red);
                            Rectangle rectangulo = new Rectangle(Ubicacion, tamanio);
                            lienzo.FillRectangle(pincel, rectangulo);
                        }
                        break;
                    case 2:
                        {
                            MessageBox.Show($"{(int) Numeros.DOS}");
                        }
                        break;
                    case (int)Numeros.TRES:
                        {
                            MessageBox.Show($"{(int)Numeros.TRES}");
                        }
                            break;
                    case (int)Numeros.CUATRO:
                        {
                            MessageBox.Show($"{(int)Numeros.CUATRO}");
                        }
                            break;
                    case (int)Numeros.CINCO:
                        {
                            MessageBox.Show($"{(int)Numeros.CINCO}");
                        }
                            break;
                    case (int)Numeros.SEIS:
                        {
                            MessageBox.Show($"{(int)Numeros.DOS}");
                        }
                            break;
                    case (int)Numeros.SIETE:
                        {
                            MessageBox.Show($"{(int)Numeros.SIETE}");
                        }
                            break;
                    case (int)Numeros.OCHO:
                        {
                            MessageBox.Show($"{(int)Numeros.OCHO}");
                        }
                            break;
                    case (int)Numeros.NUEVE:
                        {
                            MessageBox.Show($"{(int)Numeros.DOS}");
                        }
                            break;
                }
            }

            // Métodos públicos
            public void AsignarHora(int Hora24, int Min)
            {
                hora = Hora24;
                minutos = Min;
                meridiano = ComprobarTiempo(Hora24);
                MessageBox.Show($"{Hora24}:{Min} {meridiano}");
            }
            public void VerEnPanel(Panel grafico, Point Ubicacion) //Point ubicacion)
            {
                lienzo = grafico.CreateGraphics();
                DibujarNumeros(lienzo, Ubicacion, hora, minutos);
            }
        }

        public Pantalla()
        {
            InitializeComponent();
        }

        private void PanelReloj_Paint(object sender, PaintEventArgs e)
        {
            // Instancias
            //Reloj reloj1 = new Reloj(10, 10);

            Reloj reloj2 = new Reloj();
            reloj2.AsignarHora(2, 20);
            reloj2.VerEnPanel(PanelReloj, new Point(20,20));

            Reloj reloj3 = new Reloj();
            reloj3.AsignarHora(1, 59);
            reloj2.VerEnPanel(PanelReloj, new Point(30, 30));
        }
    }
}
