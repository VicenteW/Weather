using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace Clima_Grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCiudades.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Elegir Ciudad
            switch (lstCiudades.SelectedIndex)
            {
                case 0:
                    BuscarClima("Orizaba,mx");
                    break;
                case 1:
                    BuscarClima("Cordoba,mx");
                    break;
                case 2:
                    BuscarClima("Veracruz,mx");
                    break;
                case 3:
                    BuscarClima("Xalapa,mx");
                    break;
                case 4:
                    BuscarClima("Irvine,us");
                    break;
                case 5:
                    BuscarClima("Chimbote,pe");
                    break;
                case 6:
                    BuscarClima("Toronto,ca");
                    break;
                case 7:
                    BuscarClima("Austin,us");
                    break;
                case 8:
                    BuscarClima("Versalles,co");
                    break;
                case 9:
                    BuscarClima("Paris,fr");
                    break;
                case 10:
                    BuscarClima("Montreal,ca");
                    break;
                case 11:
                    BuscarClima("Madrid,es");
                    break;
                case 12:
                    BuscarClima("London,gb");
                    break;
                case 13:
                    BuscarClima("Quebec,ca");
                    break;
                case 14:
                    BuscarClima("Shanghai,cn");
                    break;
                case 15:
                    BuscarClima("Tokyo,jp");
                    break;
            }
        }


        void BuscarClima(string ciudad)
        {
            
                Clima clima;
                Double temp = 0;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q="+ciudad+ "&units=metric&APPID=bbc938177fcad2c9827133d071ff8fe6");
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    clima = JsonConvert.DeserializeObject<Clima>(json);
                }
            //Insertar los valores en los label

            

            lblNombre.Text = clima.name.ToString();
            lblTemp.Text = clima.main.temp.ToString() + "°C";
            lblTempMax.Text = "Temperatura maxima: " + clima.main.temp_max.ToString() + "°C";
            lblTempMin.Text = "Temperatura minima: " + clima.main.temp_min.ToString() + "°C";
            lbl_humedad.Text = "Humedad: " + clima.main.humidity.ToString() + "%";
            lbl_presion.Text = "Presión: " + clima.main.pressure.ToString() + " hpa";
            lbl_vel_viento.Text = "Vel. Viento: " + clima.wind.speed.ToString() + " m/s";
            //Elegir icono
            switch (clima.weather[0].icon.ToString())
            {
                case "01d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\01d.png");
                    break;
                case "02d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\02d.png");
                    break;
                case "03d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\03d.png");
                    break;
                case "04d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\04d.png");
                    break;
                case "09d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\09d.png");
                    break;
                case "10d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\10d.png");
                    break;
                case "11d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\11d.png");
                    break;
                case "13d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\13d.png");
                    break;
                case "50d":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\50d.png");
                    break;
                case "01n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\01n.png");
                    break;
                case "02n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\02n.png");
                    break;
                case "03n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\03n.png");
                    break;
                case "04n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\04n.png");
                    break;
                case "09n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\09n.png");
                    break;
                case "10n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\10n.png");
                    break;
                case "11n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\11n.png");
                    break;
                case "13n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\13n.png");
                    break;
                case "50n":
                    picSol.Image = Image.FromFile("C:\\IconosClima\\50n.png");
                    break;

            }
                        
        }
        public void Llenardgv()
        {
            dgvClima.Columns[0].Name = "Ciudad";
            dgvClima.Columns[1].Name = "Temperatura";
            dgvClima.Columns[2].Name = "Temp. Max";
            dgvClima.Columns[3].Name = "Temp. Mix";
            dgvClima.Columns[4].Name = "Humedad";
            dgvClima.Columns[5].Name = "Presión";
            dgvClima.Columns[6].Name = "Vel. Viento";
            for (int i = 0; i <= 15; i++)
            {
                switch (i)
                {
                    case 0:
                        ConseguirClimas("Orizaba,mx");
                        break;
                    case 1:
                        ConseguirClimas("Cordoba,mx");
                        break;
                    case 2:
                        ConseguirClimas("Veracruz,mx");
                        break;
                    case 3:
                        ConseguirClimas("Xalapa,mx");
                        break;
                    case 4:
                        ConseguirClimas("Irvine,us");
                        break;
                    case 5:
                        ConseguirClimas("Chimbote,pe");
                        break;
                    case 6:
                        ConseguirClimas("Toronto,ca");
                        break;
                    case 7:
                        ConseguirClimas("Austin,us");
                        break;
                    case 8:
                        ConseguirClimas("Versalles,co");
                        break;
                    case 9:
                        ConseguirClimas("Paris,fr");
                        break;
                    case 10:
                        ConseguirClimas("Montreal,ca");
                        break;
                    case 11:
                        ConseguirClimas("Madrid,es");
                        break;
                    case 12:
                        ConseguirClimas("London,gb");
                        break;
                    case 13:
                        ConseguirClimas("Quebec,ca");
                        break;
                    case 14:
                        ConseguirClimas("Shanghai,cn");
                        break;
                    case 15:
                        ConseguirClimas("Tokyo,jp");
                        break;
                }
            }
        }
        public void ConseguirClimas(string ciudad)
        {
            Clima clima;
            Double temp = 0;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + ciudad + "&units=metric&APPID=bbc938177fcad2c9827133d071ff8fe6");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                clima = JsonConvert.DeserializeObject<Clima>(json);
            }
            dgvClima.Rows.Add(clima.name.ToString(), clima.main.temp.ToString(), clima.main.temp_max.ToString(), clima.main.temp_min.ToString(), clima.main.humidity.ToString(), clima.main.pressure.ToString(), clima.wind.speed.ToString());
            
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            pnlTemp.Show();
            Llenardgv();
            DateTime today = DateTime.Now;
            string nombre = today.ToString();

            nombre = nombre.Replace('/', '_');
            nombre = nombre.Replace('.', ',');
            nombre = nombre.Replace(':', '-');
            StreamWriter sw = new StreamWriter(@"C:\\Users\\vis-h\\Documents\\Climas\\"+nombre+".txt");
            for (int i = 0; i < dgvClima.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if(j == 1)
                    {
                        sw.Write("Temperatura en el momento: ");
                    }
                    if (j == 2)
                    {
                        sw.Write("Temperatura Máxima del dia: ");
                    }
                    if (j == 3)
                    {
                        sw.Write("Temperatura Mínima del dia: ");
                    }
                    if (j == 4)
                    {
                        sw.Write("Humedad del dia: ");
                    }
                    if (j == 5)
                    {
                        sw.Write("Presión del dia: ");
                    }
                    if (j == 6)
                    {
                        sw.Write("Vel. viento del dia: ");
                    }
                    sw.Write(dgvClima.Rows[i].Cells[j].Value.ToString());
                    if(j == 1)
                    {
                        sw.Write("°C");
                    }
                    if (j == 2)
                    {
                        sw.Write("°C");
                    }
                    if (j == 3)
                    {
                        sw.Write("°C");
                    }
                    if (j == 4)
                    {
                        sw.Write("%");
                    }
                    if (j == 5)
                    {
                        sw.Write(" hpa");
                    }
                    if (j == 6)
                    {
                        sw.Write(" m/s");
                    }
                    if (j != 6)
                    {
                        sw.Write(" - ");
                    }
                }
                sw.WriteLine("");
            }
            sw.Close();
            MessageBox.Show("ARCHIVO CREADO");
        }

        

        private void dgvClima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTempMin_Click(object sender, EventArgs e)
        {

        }
    }
}
