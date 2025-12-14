using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    //okienko w ktorym mozemy zmienic wielkosc obszaru bitmapy na ktorej rysujemy
    public partial class Okienko : Form
    {
        public Okienko()
        {
            InitializeComponent();
        }
        public int Szerokosc { get; private set; }
        public int Dlugosc { get; private set; }
        //jesli klikniety zostal przycisk Ok wykonujemy kod
        private void button1_Click(object sender, EventArgs e)
        {
            //oblsgujemy bledy jesli jakies dane sa nie prawidlowe
            try
            {
                //pobieramy dane
                int szerokn = Convert.ToInt32(szer_okna.Text);
                int dlugokn = Convert.ToInt32(dlug_okna.Text);
                //jesli nie mieszcza sie w zakresie to wyswietlamy taki komunikat
                if (szerokn > 1815 || szerokn < 400)
                {
                    MessageBox.Show("Wprowadziłes dane poza zakresem");
                }
                else if (dlugokn > 784 || dlugokn < 400)
                {
                    MessageBox.Show("Wprowadziłes dane poza zakresem");
                }
                else
                {
                    //jesli wszystko poszlo zgodnie to wysylamy wynik OK i zamykamy
                    Szerokosc = szerokn;
                    Dlugosc = dlugokn;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                    

            }
            catch (Exception ex)
            {

                MessageBox.Show("Dane nie są liczbami");
            }
             
            
        }

        //jesli klikniety zostal przycisk Cancel to wysylamy taki wynik
        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }
    }
}
