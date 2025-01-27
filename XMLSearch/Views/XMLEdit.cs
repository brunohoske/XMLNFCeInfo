using System.Data;
using System.Globalization;
using System.Reflection.Metadata;
using System.Xml.Linq;
using XMLSearch.Models;

namespace XMLSearch.Views
{
    public partial class XMLEdit : Form
    {
        public List<XmlNfce> NfceList { get; set; }
        public XMLEdit(List<XmlNfce> list)
        {
            InitializeComponent();
            NfceList = list;
            btnSignature.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int count = 0;
            int erros = 0;
            string tag = txtEdit.Text;
            try
            {

                foreach (var xml in NfceList)
                {
                    try
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            var element = xml.XML.Descendants()
                           .Where(e => e.Name.LocalName == tag);

                            if (element == null || element.Count() <= 0)
                            {
                                erros++;
                                continue;
                            }
                            else
                            {
                                element.First().Value = txtNewValue.Text;
                                count++;
                            }
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            var element = xml.XML.Descendants()
                            .Where(e => e.Name.LocalName == tag);

                            if(element == null || element.Count() <= 0)
                            {
                                erros++;
                                continue;
                            }
                            else
                            {
                                element.Remove();
                                count++;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        erros++;
                        continue;
                    }
                }
                MessageBox.Show("Processo concluído\n"+ "Corrigidos: " + count + " Falhas: " + erros);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void XMLEdit_Load(object sender, EventArgs e)
        {
            lblQuant.Text = NfceList.Count.ToString();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new FolderBrowserDialog();
                dialog.ShowDialog();
                foreach (var xml in NfceList)
                {
                    
                    string fullPath = Path.Combine(dialog.SelectedPath, xml.FileName);
                    string xmlContent = xml.XML.ToString(SaveOptions.DisableFormatting);
                    File.WriteAllText(fullPath, xmlContent);
                }
                MessageBox.Show("Todos XMLs Exportados com sucesso");
            }
            catch
            {
                MessageBox.Show("Nem todos os arquivos foram exportados");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                lblNewValue.Visible = false;
                txtNewValue.Visible = false;
            }
            else
            {
                lblNewValue.Visible = true;
                txtNewValue.Visible = true;
            }

        }

        private void btnICMS_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var xml in NfceList)
                {
                    double total = 0.0f;

                    double totalICMSDeson = xml.XML.Descendants("det")
                                        .Descendants("vICMSDeson")
                                        .Sum(x => (double?)x ?? 0);

                    var vICMSDesonElement = xml.XML.Descendants("ICMSTot")
                                            .Elements("vICMSDeson")
                                            .FirstOrDefault();

                    if (vICMSDesonElement != null)
                    {
                        vICMSDesonElement.Value = totalICMSDeson.ToString("F2", CultureInfo.InvariantCulture);
                    }
                }
                MessageBox.Show("Todos os XMLs corrigidos");
            }
            catch
            {
                MessageBox.Show("Erro inesperado ocorrido em corrigir os XMLs");
            }

        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            try
            {
                XNamespace ns = "http://www.portalfiscal.inf.br/nfe";
                foreach (var xml in NfceList)
                {
                    string chvNfe = "";
                    var infNFeElement = xml.XML.Descendants("infNFe").FirstOrDefault();

                    if (infNFeElement != null)
                    {
                        string idValue = infNFeElement.Attribute("Id")?.Value;

                        if (!string.IsNullOrEmpty(idValue))
                        {
                            chvNfe = idValue.Substring(3);
                           
                        }
                    }
                    
                    if (infNFeElement != null)
                    {
                        
                        infNFeElement.AddAfterSelf(
                            new XElement("infNFeSupl",
                                new XElement("qrCode", new XCData($"http://app.sefaz.es.gov.br/ConsultaNFCe?p={chvNfe}|2|1|1|C5CB4D07E2A869BDE41F7C7A2AB72C8AE357769D")),
                                new XElement("urlChave", "www.sefaz.es.gov.br/nfce/consulta")
                            ),
                            new XElement("Signature",
                                new XAttribute(XNamespace.Xmlns + "ds", "http://www.w3.org/2000/09/xmldsig#"),
                                new XElement("SignedInfo",
                                    new XElement("CanonicalizationMethod",
                                        new XAttribute("Algorithm", "http://www.w3.org/TR/2001/REC-xml-c14n-20010315")),
                                    new XElement("SignatureMethod",
                                        new XAttribute("Algorithm", "http://www.w3.org/2000/09/xmldsig#rsa-sha1")),
                                    new XElement("Reference",
                                        new XAttribute("URI", $"#NFe{chvNfe}"),
                                        new XElement("Transforms",
                                            new XElement("Transform",
                                                new XAttribute("Algorithm", "http://www.w3.org/2000/09/xmldsig#enveloped-signature")),
                                            new XElement("Transform",
                                                new XAttribute("Algorithm", "http://www.w3.org/TR/2001/REC-xml-c14n-20010315"))
                                        ),
                                        new XElement("DigestMethod",
                                            new XAttribute("Algorithm", "http://www.w3.org/2000/09/xmldsig#sha1")),
                                        new XElement("DigestValue", "rzcvfjnnA4PTa732GQ8kesMEZEE=")
                                    )
                                ),
                                new XElement("SignatureValue", "TQvNVRXrobD/Xr3e0Up+gileru4eKgBJgh4r02s1IbsmBTBLna8QUWbHIe60Xw3GqUtxUBjSJJ5NNu26zWUXFA9DFQ4M1ac8GLgP3Sioy7QYHPfXfa2/7Vj5r7zlzClN00Gv9NLyhldXtLuLhnSviCTp9p+ftez6koHUQBWKqkKnAG42XSQTE31TsrmhHe488Lz0mllBYxqQHs7CR87hNu0SA2orWgaVmGjfwFzlLq1PsqXdjZtrxK/Lv3L36Li6Qeuclq5a71DybbJIq6rlm/ucvRw2IE4bqRb9BjRBE8T+P8gwY3dB3Ywi7PsVyEaWbdKI0ljLMWfw5ApuPXHrxw=="),
                                new XElement("KeyInfo",
                                    new XElement("X509Data",
                                        new XElement("X509Certificate", "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")
                                    )
                                )
                            )
                        );

                  
                    }

                      var protNFe = new XElement("protNFe",
                      new XAttribute("versao", "4.00"),
                      new XElement("infProt",
                      new XAttribute("Id", "NFe332240110314065"),
                      new XElement("tpAmb", "1"),
                      new XElement("verAplic", "SVRSnfce202401291642"),
                      new XElement("chNFe", $"{chvNfe}"),
                      new XElement("dhRecbto", "2024-03-01T07:19:55-03:00"),
                      new XElement("nProt", "332240110314065"),
                      new XElement("digVal", "rzcvfjnnA4PTa732GQ8kesMEZEE="),
                      new XElement("cStat", "100"),
                      new XElement("xMotivo", "Autorizado o uso da NF-e")
                   ));
                    

                    if (xml.XML.Root.Name.LocalName != "nfeProc")
                    {
                        
                        var nfeProc = new XElement(
                            XName.Get("nfeProc", "http://www.portalfiscal.inf.br/nfe"),
                            new XAttribute("versao", "4.00"),
                            xml.XML.Root 
                        );

                        
                        xml.XML = new XDocument(nfeProc);
                    }
                    var nfeElement = xml.XML.Root.Element("NFe");
                    if (nfeElement != null)
                    {
                        
                        nfeElement.AddAfterSelf(protNFe);
                        

                    }
                    //XNamespace novoNamespace = "http://www.w3.org/2000/09/xmldsig#"; // Defina o novo namespace

                    //foreach (var element in xml.XML.Descendants("Signature"))
                    //{
                    //    // Atualiza o namespace do elemento
                    //    element.Name = novoNamespace + element.Name.LocalName;

                    //    // Atualiza o namespace dos atributos, se necessário
                    //    foreach (var attribute in element.Attributes().Where(a => a.Name.Namespace != XNamespace.None).ToList())
                    //    {
                    //        element.SetAttributeValue(novoNamespace + attribute.Name.LocalName, attribute.Value);
                    //        attribute.Remove();
                    //    }
                    //}

                    XNamespace namespacePai = xml.XML.Root.Name.Namespace;

                    foreach (var element in xml.XML.Descendants().Where(e => e.Name.Namespace == XNamespace.None))
                    {
                        // Define o namespace dos filhos como o namespace do pai
                        element.Name = namespacePai + element.Name.LocalName;
                    }

                    
                }

                MessageBox.Show("Todos os XMLs assinados");
            }
            catch
            {
                MessageBox.Show("Nem todos os XMLs foram assinados. Erro ocorrido");
            }

            
        }
        
    }
}
