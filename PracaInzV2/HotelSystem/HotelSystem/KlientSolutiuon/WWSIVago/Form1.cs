using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWSIVago.Serwer;
namespace WWSIVago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IHotelService client = new HotelServiceClient();
            pokojBindingSource.DataSource=   client.WolnePokoje(dateTimePicker1.Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IHotelService client = new HotelServiceClient();
            var mojaRezerwacja= client.RezerwujPokoj(new Rezerwacja { Data = dateTimePicker1.Value, LiczbaOsob = 2, Nazwisko = textBox1.Text });
            if (mojaRezerwacja.Akceptacja)
            {
                MessageBox.Show(mojaRezerwacja.Nazwisko);
            }
        }
    }
}
