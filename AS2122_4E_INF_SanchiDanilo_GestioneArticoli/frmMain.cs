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
    }
}