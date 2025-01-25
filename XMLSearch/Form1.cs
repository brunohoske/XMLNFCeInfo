using System.Globalization;
using System.IO.Compression;
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

        private async void btnSelectFiles_Click(object sender, EventArgs e)
        {

            NfceList = await GetNFCes();
            var saltos = new List<XmlNfce>();
            //saltos = SearchSaltos(NfceList);
            gridView.SuspendLayout();
            gridView.Rows.Clear();

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "chkColumn";
            chkColumn.HeaderText = "Selecionar";
            chkColumn.ValueType = typeof(bool);
            gridView.Columns.Add(chkColumn);

            gridView.Columns.Add(new DataGridViewButtonColumn() { Name = "Visualizar", UseColumnTextForButtonValue = true, HeaderText = "Visualizar", Text = "Visualizar" });
            gridView.Columns.Add("XML", "XML");
            gridView.Columns.Add("Série", "Série");
            gridView.Columns[0].Width = gridView.Columns[0].Width / 2 + 40;
            gridView.Columns[2].Width = gridView.Columns[2].Width / 2 + 24;


            gridView.CellClick += (sender, e) =>
            {
                if (e.ColumnIndex == 1)
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

                gridView.Rows.Add(false, button, nfce.NumNfce.ToString(), nfce.Serie.ToString());


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

                nfces.Add(GetInfos(stream, entry.Name));
            }
            return nfces;
        }

        private XmlNfce GetInfos(Stream stream, string fileName)
        {

            XDocument xml = XDocument.Load(stream);
            //XNamespace ns = "http://www.portalfiscal.inf.br/nfe";
            XNamespace ns = xml.Root.GetDefaultNamespace();



            XmlNfce nfce = new XmlNfce()
            {
                FileName = fileName,
                XML = xml,

                NumNfce = long.TryParse(xml.Descendants(ns + "ide")
                .Elements(ns + "nNF")
                .FirstOrDefault()?.Value, out long numNfce) ? numNfce : 0,

                Serie = int.TryParse(xml.Descendants(ns + "ide")
                .Elements(ns + "serie")
                .FirstOrDefault()?.Value, out int serie) ? serie : 0,

                Modelo = int.TryParse(xml.Descendants(ns + "ide")
                .Elements(ns + "mod")
                .FirstOrDefault()?.Value, out int modelo) ? modelo : 0,

                Cupom = long.TryParse(xml.Descendants(ns + "ide")
                .Elements(ns + "cNF")
                .FirstOrDefault()?.Value, out long cupom) ? cupom : 0,

                Cnpj = xml.Descendants(ns + "emit")
                .Elements(ns + "CNPJ")
                .FirstOrDefault()?.Value,

                Total = double.TryParse(xml.Descendants(ns + "total")
                .Descendants(ns + "ICMSTot")
                .Elements(ns + "vNF")
                .FirstOrDefault()?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double total) ? total : 0,

                TotalDesconto = double.TryParse(xml.Descendants(ns + "total")
                .Descendants(ns + "ICMSTot")
                .Elements(ns + "vDesc")
                .FirstOrDefault()?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double totalDesconto) ? totalDesconto : 0,

                ChaveDeAcesso = xml.Descendants(ns + "infProt")
                .Elements(ns + "chNFe")
                .FirstOrDefault()?.Value,

                Motivo = xml.Descendants(ns + "infProt")
                .Elements(ns + "xMotivo")
                .FirstOrDefault()?.Value,

                Status = int.TryParse(xml.Descendants(ns + "infProt")
                .Elements(ns + "cStat")
                .FirstOrDefault()?.Value, out int status) ? status : 0,

                TotalPag = double.TryParse(xml.Descendants(ns + "detPag")
                .Elements(ns + "vPag")
                .FirstOrDefault()?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double totalPag) ? totalPag : 0,

                TipoPagamento = int.TryParse(xml.Descendants(ns + "detPag")
                .Elements(ns + "tPag")
                .FirstOrDefault()?.Value, out int tipoPagamento) ? tipoPagamento : 0,

                DataHora = DateTime.TryParse(xml.Descendants(ns + "ide")
                .Elements(ns + "dhEmi")
                .FirstOrDefault()?.Value, out DateTime dataHora) ? dataHora : DateTime.MinValue,
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

        private void btnXmlEdit_Click(object sender, EventArgs e)
        {
            List<XmlNfce> list = new List<XmlNfce>();
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                bool isChecked = Convert.ToBoolean(gridView.Rows[i].Cells[0].Value);
                if (isChecked)
                {
                    list.Add(NfceList[i]);
                }
            }
            XMLEdit form = new XMLEdit(list);
            form.Show();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in gridView.Rows)
            {
                if(!row.IsNewRow)
                {
                    row.Cells[0].Value = chkSelectAll.Checked;
                }
                
            }
        }
    }
}
