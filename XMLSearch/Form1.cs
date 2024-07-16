using System.Globalization;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLSearch.Models;
using XMLSearch.Views;

namespace XMLSearch
{
    public partial class Form1 : Form
    {
        public List<XmlNfce> NfceList;
        public Form1()
        {
            InitializeComponent();
            txtSaltos.ScrollBars = ScrollBars.Vertical;
            txtSaltos.Multiline = true;
            txtSaltos.WordWrap = true;
            txtSaltos.ReadOnly = true;

            

            


        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
        private async void btnSelectFiles_Click(object sender, EventArgs e)
        {

            NfceList = await GetNFCes();
            var saltos = new List<XmlNfce>();
            saltos = SearchSaltos(NfceList);
            gridView.SuspendLayout();
            gridView.Rows.Clear();

            gridView.Columns.Add(new DataGridViewButtonColumn() { Name = "Visualizar", UseColumnTextForButtonValue = true, HeaderText = "Visualizar", Text ="Visualizar"});
            gridView.Columns.Add("XML", "XML");
            gridView.Columns.Add("Série", "Série");
            gridView.Columns[0].Width = gridView.Columns[0].Width / 2 + 40;
            gridView.Columns[2].Width = gridView.Columns[2].Width/2 + 24 ;


            gridView.CellClick += (sender, e) =>
            {
                if (e.ColumnIndex == 0)
                {
                    XMLView xMLView = new XMLView(NfceList[e.RowIndex]); xMLView.Show();
                }
            };
            int index = 0;
            foreach (var nfce in NfceList)
            {

                Button button = new Button() { Text = "Visualizar", AutoSize = true };
                button.Click += (sender, e) => { XMLView xMLView = new XMLView(nfce); xMLView.Show(); };
                button.Name = "Visualizar";

                gridView.Rows.Add(button, nfce.NumNfce.ToString(), nfce.Serie.ToString());


                index++;


            }
            foreach (var salto in saltos)
            {
                txtSaltos.Text += salto.ToString();
            }
            lblQuantXml.Text = NfceList.Count.ToString();
            lblQuantSaltos.Text = saltos.Count.ToString();
            gridView.ResumeLayout();

        }

        private async Task<List<XmlNfce>> GetNFCes()
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileStream = ofd.OpenFile();
                return await UploadXMLs(ofd);
            }
            return null;
        }

        private async Task<List<XmlNfce>> UploadXMLs(OpenFileDialog ofd)
        {
            List<XmlNfce> nfces = new List<XmlNfce>();
            using ZipArchive zip = ZipFile.Open(ofd.FileName, ZipArchiveMode.Read);
            foreach (ZipArchiveEntry entry in zip.Entries)
            {
                using Stream stream = entry.Open();
                nfces.Add(GetInfos(stream));
            }
            return nfces;
        }

        private XmlNfce GetInfos(Stream stream)
        {

            XDocument xml = XDocument.Load(stream);
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";

            XmlNfce nfce = new XmlNfce()
            {
                NumNfce = long.Parse(xml.Descendants(ns + "ide")
                                .Elements(ns + "nNF")
                                .FirstOrDefault().Value),
                Serie = int.Parse(xml.Descendants(ns + "ide")
                                .Elements(ns + "serie")
                                .FirstOrDefault().Value),
                Modelo = int.Parse(xml.Descendants(ns + "ide")
                               .Elements(ns + "mod")
                               .FirstOrDefault().Value),
                Cupom = long.Parse(xml.Descendants(ns + "ide")
                                .Elements(ns + "cNF").FirstOrDefault().Value),
                Cnpj = xml.Descendants(ns + "emit")
                       .Elements(ns + "CNPJ")
                       .FirstOrDefault().Value,
                Total = double.Parse(xml.Descendants(ns + "total")
                        .Descendants(ns + "ICMSTot")
                        .Elements(ns + "vNF")
                        .FirstOrDefault().Value, CultureInfo.InvariantCulture),
                TotalDesconto = double.Parse(xml.Descendants(ns + "total")
                        .Descendants(ns + "ICMSTot")
                        .Elements(ns + "vDesc")
                        .FirstOrDefault().Value, CultureInfo.InvariantCulture),
                ChaveDeAcesso = xml.Descendants(ns + "infProt")
                          .Elements(ns + "chNFe")
                          .FirstOrDefault()?.Value,
                Motivo = xml.Descendants(ns + "infProt")
                            .Elements(ns + "xMotivo")
                            .FirstOrDefault()?.Value,
                Status = int.Parse(xml.Descendants(ns + "infProt")
                         .Elements(ns + "cStat")
                         .FirstOrDefault()?.Value),

                TotalPag = double.Parse(xml.Descendants(ns + "detPag")
                         .Elements(ns + "vPag")
                         .FirstOrDefault()?.Value, CultureInfo.InvariantCulture),

                TipoPagamento = int.Parse(xml.Descendants(ns + "detPag")
                         .Elements(ns + "tPag")
                         .FirstOrDefault()?.Value),

                DataHora = DateTime.Parse(xml.Descendants(ns + "ide")
                                .Elements(ns + "dhEmi")
                                .FirstOrDefault()?.Value),

                //
            };

            if (xml.Descendants(ns + "vTroco").FirstOrDefault() != null)
            {
                nfce.TotalTroco = double.Parse(xml.Descendants(ns + "vTroco").FirstOrDefault()?.Value, CultureInfo.InvariantCulture);
            }

            return nfce;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<XmlNfce> SearchSaltos(List<XmlNfce> list)
        {
            //long numIni = list.First().NumNfce;
            //long numFin = list.Last().NumNfce;
            //long num = numIni;
            //List<XmlNfce> saltos = new List<XmlNfce>();

            //int count = 0;
            //while (num != numFin)
            //{
            //    if (list[count].NumNfce == num)
            //    {

            //    }
            //    else
            //    {
            //        saltos.Add(list[count]);
            //        num += 1;
            //    }
            //    num++;
            //    count++;

            //}
            //return saltos;

            long numIni = list.First().NumNfce;
            long numFin = list.Last().NumNfce;
            long num = numIni;
            List<XmlNfce> saltos = new List<XmlNfce>();

            int count = 0;
            while (num != numFin)
            {
                if (list[count].NumNfce == num)
                {

                }
                else
                {
                    saltos.Add(list[count]);

                }
                num++;
                count++;

            }
            return saltos;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
