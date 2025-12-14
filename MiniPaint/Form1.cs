using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        // Główna bitmapa obszar na którym rysujemy i który zapisujemy do pliku.
        private Bitmap bitmapa;

        // flaga ktora sprawdza czy uzytkwonik ma przytrzymany przycisk (rysuje)
        private bool rysuje = false;

        // Poprzednia pozycja myszy potrzebna do rysowania
        private Point poprzedniPunkt;

        // pedzel/ołowke którym rysujemy
        private Pen olowek;

        // Tryb rysowania moze byc pędzel / kwadrat / koło / trójkąt.
        private string trybRysowania = "Pedzel";

        // Aktualna pozycja myszy potrzebna do podgladu
        private Point aktualnyPunktMyszy;

        public Form1()
        {
            InitializeComponent();

            //Tworzymy bitmapę o wielkości panelu i wypełniamy ją białym kolorem.
            //dzieki using po skonczeniu zsób zostanie zwolniony automatycznie
            bitmapa = new Bitmap(panel_do_rys.Width, panel_do_rys.Height);
            using (Graphics g = Graphics.FromImage(bitmapa))
            {
                g.Clear(Color.White);
            }

            // Ustawiamy bitmapę jako tło panelu dzieki czemu to co jest rysowane sie odrazu pokazuje
            panel_do_rys.BackgroundImage = bitmapa;

            // ustawiamy domyslny pedzel o wielkosci 5 i kolorze czarnym
            olowek = new Pen(Color.Black, 5);

            // łączymy zdarzenia myszy i malowania panelu.
            panel_do_rys.MouseDown += panel_do_rys_MouseDown;
            panel_do_rys.MouseMove += panel_do_rys_MouseMove;
            panel_do_rys.MouseUp += panel_do_rys_MouseUp;
            panel_do_rys.Paint += Panel_do_rys_Paint;
        }

        private void Panel_do_rys_Paint(object sender, PaintEventArgs e)
        {
            // Podgląd figur geometrycznych (tymczasowy, przerywany kształt).
            //Instrukcja warunkowa gdy mamy trybrysowania jakiejs figury i rysuje jest true to wtedy nie rysujemy odrazu
            //tylko mamy podglad tymczasowy przerywany
            if (rysuje && (trybRysowania == "Kwadrat" || trybRysowania == "Kolo" || trybRysowania == "Trojkat"))
            {
                //zwraca nam mniejsza wartosc wspolrzednych myszy x i y od ktorego rysuje nam prostokat
                int x = Math.Min(poprzedniPunkt.X, aktualnyPunktMyszy.X);
                int y = Math.Min(poprzedniPunkt.Y, aktualnyPunktMyszy.Y);
                //dzieki Math.abs mamy wartosci absolutne odejmujac jeden punkt od drugiego i wiemy jakie dlugosci mamy miec
                int width = Math.Abs(poprzedniPunkt.X - aktualnyPunktMyszy.X);
                int height = Math.Abs(poprzedniPunkt.Y - aktualnyPunktMyszy.Y);
                //tworzymy prostokat z tymi danymi wyzej
                Rectangle rect = new Rectangle(x, y, width, height);

                //tempPen to pioro rysujace z parametrami naszego obecnego olowka
                using (Pen tempPen = new Pen(olowek.Color, olowek.Width))
                {
                    // ustawiamy styl lini rysowanych do podglądu (przerywane kropki)
                    tempPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                    //w zaleznosci od wybranej figury rysujemy kwadrat/prostokat , kolo/elipse, trojkat
                    if (trybRysowania == "Kwadrat")
                        e.Graphics.DrawRectangle(tempPen, rect);
                    

                    else if (trybRysowania == "Kolo")
                        e.Graphics.DrawEllipse(tempPen, rect);

                    else if (trybRysowania == "Trojkat")
                    {
                        //rysujemy trojkat na podstawie 3 punktow
                        //p1 miejsce w ktorym kliknelismy rysowanie
                        //p2 lezy na tym samym x co aktualne miejsce ale na y w ktorym kliknelismy
                        //p3 to pozycja aktualna myszy
                        //dzieki temu rysujemy trojkat prostokatny
                        Point p1 = poprzedniPunkt;
                        Point p2 = new Point(aktualnyPunktMyszy.X, poprzedniPunkt.Y);
                        Point p3 = aktualnyPunktMyszy;
                        Point[] punktyTrojkata = { p1, p2, p3 };
                        e.Graphics.DrawPolygon(tempPen, punktyTrojkata);
                    }
                }
            }
        }

        // Zamkniecie aplikacji
        private void Przycisk_wyjscia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Przycisk dzieki ktoremu mozemy zmienic rozmiar panelu i tworzymy nowa pusta bitmape
        private void button1_Click(object sender, EventArgs e)
        {
            using (Okienko okienko = new Okienko())
            {
                //jesli z okna klikniemy OK to wtedy nam sie zmieni okno rysowania 
                if (okienko.ShowDialog() == DialogResult.OK)
                {
                    int szer = okienko.Szerokosc;
                    int dlug = okienko.Dlugosc;

                    panel_do_rys.Width = szer;
                    panel_do_rys.Height = dlug;

                    // Tworzymy nową pustą bitmapę o zmienionych wartosciach
                    bitmapa = new Bitmap(panel_do_rys.Width, panel_do_rys.Height);
                    panel_do_rys.BackgroundImage = bitmapa;
                }
            }
        }

        // obsluga eventu podczas trzymania przycisku myszy
        private void panel_do_rys_MouseDown(object sender, MouseEventArgs e)
        {
            //zmieniamy wartosc flagi rysuje na true
            rysuje = true;
            //aktualizujemy wartosc poprzedniego puntku na obecny
            poprzedniPunkt = e.Location;
        }

        // obsluga eventu podczas ruszania myszka
        private void panel_do_rys_MouseMove(object sender, MouseEventArgs e)
        {
            //jesli rysuje = false to wtedy zeby odrazu sie nic nie zwracalo i reszta sie nie wykonywala
            if (!rysuje) return;

            //aktualizujemy obecna pozycje myszy caly czas
            aktualnyPunktMyszy = e.Location;

            //jesli trybrysowania jest pedzel to wtedy wykonujemy to co w instrukcji
            if (trybRysowania == "Pedzel")
            {
                // Rysujemy bezpośrednio na bitmapie
                using (Graphics g = Graphics.FromImage(bitmapa))
                {
                    //uzywamy aby antyalising wygładzał krawedzie dzieki czemu ladniej wyglada rysowanie
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    //wyliczamy roznice pomiedzy punktami
                    int dx = e.X - poprzedniPunkt.X;
                    int dy = e.Y - poprzedniPunkt.Y;
                    // Obliczamy odległość między punktami
                    int odleglosc = (int)Math.Sqrt(dx * dx + dy * dy);
                    //jesli odleglosc jest rowna 0 zmieniamy ja na 1
                    if (odleglosc == 0) odleglosc = 1;

                    using (SolidBrush pedzel = new SolidBrush(olowek.Color))
                    {
                        // Interpolacja — rysowanie wielu małych kropek między punktami
                        // dzieki czemu nawet przy plynnym ruchu myszki mamy plynna linie
                        for (int i = 0; i <= odleglosc; i++)
                        {
                            float t = (float)i / odleglosc;
                            int x = (int)(poprzedniPunkt.X + dx * t);
                            int y = (int)(poprzedniPunkt.Y + dy * t);

                            g.FillEllipse(
                                pedzel,
                                x - olowek.Width / 2,
                                y - olowek.Width / 2,
                                olowek.Width,
                                olowek.Width
                            );
                        }
                    }
                }

                poprzedniPunkt = e.Location; // ustawiamy poprzedni punkt na obecny
                panel_do_rys.Invalidate(); // odświeżamy widok
            }
            else if (trybRysowania == "Kwadrat" || trybRysowania == "Kolo" || trybRysowania == "Trojkat")
            {
                // Dla figur pokazujemy tylko podglad nie rysujemy odrazu
                panel_do_rys.Invalidate();
            }
        }

        // obsluga eventu podczas puszczeniu przycisku myszy
        private void panel_do_rys_MouseUp(object sender, MouseEventArgs e)
        {
            //zmieniamy flage na false
            rysuje = false;

            //dzialanie dokladnie jak wyzej tylko faktycznie rysujemy dopiero wtedy gdy puscimy przycisk myszy
            int x = Math.Min(poprzedniPunkt.X, e.Location.X);
            int y = Math.Min(poprzedniPunkt.Y, e.Location.Y);
            int width = Math.Abs(poprzedniPunkt.X - e.Location.X);
            int height = Math.Abs(poprzedniPunkt.Y - e.Location.Y);
            Rectangle finalRect = new Rectangle(x, y, width, height);

            using (Graphics g = Graphics.FromImage(bitmapa))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Rysowanie ostatecznych figur na bitmapie.
                if (trybRysowania == "Kwadrat")
                    g.DrawRectangle(olowek, finalRect);

                else if (trybRysowania == "Kolo")
                    g.DrawEllipse(olowek, finalRect);

                else if (trybRysowania == "Trojkat")
                {
                    Point p1 = poprzedniPunkt;
                    Point p2 = new Point(e.Location.X, poprzedniPunkt.Y);
                    Point p3 = e.Location;
                    Point[] punktyTrojkata = { p1, p2, p3 };
                    g.DrawPolygon(olowek, punktyTrojkata);
                }
            }

            panel_do_rys.Invalidate();
        }

        // Gumka zmieniamy po prostu kolor na bialy przy przycisnieciu na obrazek gumki
        private void gumka_Click(object sender, EventArgs e)
        {
            olowek.Color = Color.White;
        }

        // poprzez Radiobuttony wybieramy grubosc olowka i zmieniamy po przycisnieciu przycisku
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) olowek.Width = 5;
            else if (radioButton2.Checked) olowek.Width = 10;
            else if (radioButton3.Checked) olowek.Width = 15;
            else if (radioButton4.Checked) olowek.Width = 20;
            else if (radioButton5.Checked) olowek.Width = 25;
            else if (radioButton6.Checked) olowek.Width = 30;
        }

        // Zmiana koloru pędzla na podstawie wybranego elementu w liście uzywamy listboxa
        private void Kolory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranyKolor = Kolory.SelectedItem.ToString();

            switch (wybranyKolor)
            {
                case "Czarny": olowek.Color = Color.Black; break;
                case "Czerwony": olowek.Color = Color.Red; break;
                case "Zielony": olowek.Color = Color.Green; break;
                case "Niebieski": olowek.Color = Color.Blue; break;
                case "Fioletowy": olowek.Color = Color.Purple; break;
                case "Różowy": olowek.Color = Color.Pink; break;
                case "Biały": olowek.Color = Color.White; break;
                case "Żółty": olowek.Color = Color.Yellow; break;
                case "Pomarańczowy": olowek.Color = Color.Orange; break;
                case "Brązowy": olowek.Color = Color.Brown; break;
                case "Szary": olowek.Color = Color.Gray; break;
                default: break;
            }
        }

        //Wybieramy figury z ListView jest to bardziej rozbudowana lista niz zwykly listbox 
        //ustawiamy zgodnie z wybrana figura taki tryb rysowania gdy zadna figura nie jest wybrana wtedy dziala pedzel
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null || listView1.SelectedItems.Count == 0)
            {
                trybRysowania = "Pedzel";
                return;
            }

            string selectedTool = listView1.SelectedItems[0].Text;

            switch (selectedTool)
            {
                case "Kwadrat": trybRysowania = "Kwadrat"; break;
                case "Koło": trybRysowania = "Kolo"; break;
                case "Trójkąt": trybRysowania = "Trojkat"; break;
                default: trybRysowania = "Pedzel"; break;
            }
        }

        // Podczas przycisniecia obrazka z olowkiem ustawiamy kolor na czarny po prostu
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            olowek.Color = Color.Black;
        }

        //Przycisk savu zapisujemy obraz z bitmapy do pliku graficznego
        private void Save_Click(object sender, EventArgs e)
        {
            //Filter dzieki temu ustawiamy domyslne mozliwosci zapisu
            saveFileDialog1.Filter = "Plik PNG (*.png)|*.png|Plik JPEG (*.jpg)|*.jpg|Plik BMP (*.bmp)|*.bmp";
            //ustawiamy tytul okienka dzieki title
            saveFileDialog1.Title = "Zapisz obrazek MiniPaint";
            //ustawiamy zeby domyslnie mialo sie zapisac odrazu do folderu Mypictures
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sciezkaDoPliku = saveFileDialog1.FileName;

                    // Zapisujemy bitmape to co narysowalismy
                    bitmapa.Save(sciezkaDoPliku, System.Drawing.Imaging.ImageFormat.Png);
                    //jesli zapisalo sie pomyslnie to wyswietlamy komunikat
                    MessageBox.Show("Obrazek został pomyślnie zapisany!", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //jesli wystapil jakis blad to go obslugujemy
                    MessageBox.Show($"Wystąpił błąd podczas zapisu pliku: {ex.Message}", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
