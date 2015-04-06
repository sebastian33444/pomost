using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace POMOST_Lite
{
    public class ConnectBaza
    {
        public string Connect()
        {
            XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("dane.xml");
                String polaczenie = "Data Source=" + xmlDoc.GetElementsByTagName("nazwa_serwera").Item(0).InnerText + ";Initial Catalog=" + xmlDoc.GetElementsByTagName("nazwa_bazy").Item(0).InnerText + ";Integrated Security=True";
                return polaczenie;
        }

    }
}
