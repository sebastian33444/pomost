using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace POMOST_Lite
{
    public partial class Konfiguracja_bazy : Form
    {
        public string ns;
        public string nb;

        public struct konf_baza
        {
            public string nazwa_serwera;
            public string nazwa_bazy;
        }

        public Konfiguracja_bazy()
        {
            InitializeComponent();
            deserializacja();
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
            this.Close();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            serializacja(nazwa_serwera.Text, nazwa_bazy.Text);
            this.Close();
            Logowanie_uzytkownika log = new Logowanie_uzytkownika();
            log.Show();
        }

 
         private void serializacja(string instance, string dbdir)
        {
            konf_baza konf = new konf_baza();
            konf.nazwa_serwera = instance;
            konf.nazwa_bazy = dbdir;
            StreamWriter wr = new StreamWriter("dane.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(konf_baza));
            serializer.Serialize(wr, konf);
            wr.Flush();
            wr.Close();
        }

         public void deserializacja()
        {
            TextReader re = new StreamReader("dane.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(konf_baza));
            konf_baza objekt = (konf_baza)serializer.Deserialize(re);
            ns = nazwa_serwera.Text = objekt.nazwa_serwera;
            nb = nazwa_bazy.Text = objekt.nazwa_bazy;
            re.Close();
        }

     }
}
