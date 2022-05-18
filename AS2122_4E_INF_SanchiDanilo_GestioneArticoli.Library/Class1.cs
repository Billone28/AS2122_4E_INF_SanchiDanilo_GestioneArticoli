namespace AS2122_4E_INF_SanchiDanilo_GestioneArticoli.Library
{
    public class Class1
    {
        class Articolo
        {
            string codice;
            string descrizione;
            string UnitadiMisura;
            string prezzo;

            public Articolo(string codice, string descrizione, string unitadiMisura, string prezzo)
            {
                this.codice = codice;
                this.descrizione = descrizione;
                this.UnitadiMisura = unitadiMisura;
                this.prezzo = prezzo;
            }
            public string Codice { get { return codice; } }
            public string Descrizione { get { return descrizione; } }
            public string UnitaDiMisura { get { return UnitaDiMisura; } }
            public string Prezzo { get { return prezzo; } }
        }

    }
}