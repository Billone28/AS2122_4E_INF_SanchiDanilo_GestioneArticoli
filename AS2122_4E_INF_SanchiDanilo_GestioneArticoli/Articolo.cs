using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_SanchiDanilo_GestioneArticoli
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

