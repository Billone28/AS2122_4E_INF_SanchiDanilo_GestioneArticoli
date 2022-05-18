using AS2122_4E_INF_SanchiDanilo_GestioneArticoli.Library;
namespace AS2122_4E_INF_SanchiDanilo_GestioneArticoli
{
    public partial class frmMain : Form
    {
        Dictionary<string, Articolo> articoli;

        public frmMain()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();        
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (articoli.ContainsKey(txtCodice.Text))
            {
                articoli[txtCodice.Text] = new Articolo(txtCodice.Text, cmbUnitadiMisura.Text, txtDescrizione.Text, txtPrezzo.Text);
            }
            else
            {
                articoli.Add(txtCodice.Text, new Articolo (txtCodice.Text, cmbUnitadiMisura.Text, txtDescrizione.Text, txtPrezzo.Text));
            }
        }
        private void btnEsegui_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Articolo> a in articoli)
            {
                lstArticoli.Items.Add(a.ToString());
            }
        }
    }
}