using XMLSearch.Models;

namespace XMLSearch.Views
{
    public partial class XMLView : Form
    {
        public XMLView(XmlNfce x)
        {
            InitializeComponent();
            xml = x;
        }

        private XmlNfce xml;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private Label AddControl(string name, string content)
        {
            Label label = new Label()
            {
                AutoSize = true,
                Text = name + ": " + content,
                Width = flowLayoutPanel1.Width
            };

            return label;
        }

        private void XMLView_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(AddControl("CNPJ", xml.Cnpj.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Num. NFCe", xml.NumNfce.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Serie", xml.Serie.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Cupom", xml.Cupom.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Modelo", xml.Modelo.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Data", xml.DataHora.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Total", xml.Total.ToString("F2")));
            flowLayoutPanel1.Controls.Add(AddControl("Desconto", xml.TotalDesconto.ToString("F2")));
            flowLayoutPanel1.Controls.Add(AddControl("Status", xml.Status.ToString()));
            flowLayoutPanel1.Controls.Add(AddControl("Chave", xml.ChaveDeAcesso));
            flowLayoutPanel1.Controls.Add(AddControl("Motivo", xml.Motivo));
            flowLayoutPanel1.Controls.Add(AddControl("Total Pago", xml.TotalPag.ToString("F2")));
            flowLayoutPanel1.Controls.Add(AddControl("Troco", xml.TotalTroco.ToString("F2")));
            flowLayoutPanel1.Controls.Add(AddControl("Tipo de Pagamento", xml.TipoPagamento.ToString()));
        }
    }
}
