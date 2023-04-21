using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioOrdini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inizializzo dei metodi di pagamento
            MetodoPagamento metodo1 = new MetodoPagamento("TaleBanca");
            MetodoPagamento metodo3 = new MetodoPagamento("BancoPoste");
            MetodoPagamento metodo2 = new MetodoPagamento("CartaCredito");
            MetodoPagamento metodo4 = new MetodoPagamento("PayPal");

            //Inizializzo i prodotti
            Prodotto tenda1 = new Prodotto("IglooMini","Ferrino","Tenda da campeggio monoposto con telo antipioggia", 20, 33.00);
            Prodotto tenda2 = new Prodotto("IglooMaxi", "Ferrino", "Tenda da campeggio 3 posti con telo antipioggia", 10, 65.50);
            Prodotto zaino1 = new Prodotto("Zaino Baloo", "ScoutTech", "Zaino da escursione 50L", 12, 57.00);
            Prodotto zaino2 = new Prodotto("Zaino Akela", "ScoutTech", "Zaino da escursione 60L", 15, 72.00);
            Prodotto scarpe1 = new Prodotto("Scarpe Mountain", "ScoutTech", "Scarponi da Trekking rinforzati con punta in ferro", 7, 55.80);
            Prodotto scarpe2 = new Prodotto("Scarpe Hill", "ScoutTech", "Scarpe da passeggiata escursionistica", 8, 43.20);
            Prodotto borraccia1 = new Prodotto("Borraccia BeviPoco", "Ferrino", "Borraccia 0.5L in alluminio", 30, 8.50);
            Prodotto borraccia2 = new Prodotto("Borraccia BeviMolto", "Ferrino", "Borraccia termica 1L in alluminio", 30, 14.80);

            //Aggiungo i prodotti alla lista dei prodotti
            listaProdotti.Add(tenda1);
            listaProdotti.Add(tenda2);
            listaProdotti.Add(zaino1);
            listaProdotti.Add(zaino2);
            listaProdotti.Add(scarpe1);
            listaProdotti.Add(scarpe2);
            listaProdotti.Add(borraccia1);
            listaProdotti.Add(borraccia2);

            //Inizializzo i dati del primo utente
            Utente utente1 = new Utente("Marco","Vermiglio");
            
            Indirizzo indirizzo1utente1 = new Indirizzo("Corso Umberto, 9", "Carini", 90044);
            Indirizzo indirizzo2utente1 = new Indirizzo("Via Catania, 12", "Palermo", 90040);

            utente1.Indirizzi.Add(indirizzo1utente1);
            utente1.Indirizzi.Add(indirizzo2utente1);
            //Inizializzo gli ordini del primo utente
            Ordine ordine1utente1 = new Ordine(001, DateTime.Now, new List<Prodotto>() { tenda1, zaino2, borraccia2 }, new Spedizione(0001,"Bartolini", indirizzo1utente1, DateTime.Now), metodo1) ;
            Ordine ordine2utente1 = new Ordine(002, DateTime.Now, new List<Prodotto>() { tenda2, scarpe2, scarpe2 }, new Spedizione(0042, "CorriereEspresso", indirizzo1utente1, DateTime.Now), metodo3);
            Ordine.CalcoloImporto(ordine1utente1);
            Ordine.CalcoloImporto(ordine2utente1);

            utente1.OrdiniEffettuati.Add(ordine1utente1);
            utente1.OrdiniEffettuati.Add(ordine2utente1);

            //Inizializzo i dati del secondo utente
            Utente utente2 = new Utente("Giulio", "Cesare");

            Indirizzo indirizzo1utente2 = new Indirizzo("Via Roma, 8", "Palermo", 90033);
            Indirizzo indirizzo2utente2 = new Indirizzo("Corso Italia, 2", "Capaci", 90035);

            utente2.Indirizzi.Add(indirizzo1utente2);
            utente2.Indirizzi.Add(indirizzo2utente2);

            //Inizializzo gli ordini del secondo utente
            Ordine ordine1utente2 = new Ordine(003, DateTime.Now, new List<Prodotto>() {zaino2, scarpe1, borraccia2 }, new Spedizione(0321, "Bartolini", indirizzo1utente2, DateTime.Now), metodo2);
            Ordine ordine2utente2 = new Ordine(004, DateTime.Now, new List<Prodotto>() { tenda1, scarpe2 }, new Spedizione(0042, "CorriereEspresso", indirizzo2utente2, DateTime.Now), metodo4);
            Ordine.CalcoloImporto(ordine1utente2);
            Ordine.CalcoloImporto(ordine2utente2);

            utente2.OrdiniEffettuati.Add(ordine1utente2);
            utente2.OrdiniEffettuati.Add(ordine2utente2);

            //Inizializzo i dati del terzo utente
            Utente utente3 = new Utente("Pippo","Franco");
            Indirizzo indirizzo1utente3 = new Indirizzo("Piazza Mozart, 1", "Palermo", 90033);
            Indirizzo indirizzo2utente3 = new Indirizzo("Corso Garibaldi, 33", "Cefalù", 90035);

            utente3.Indirizzi.Add(indirizzo1utente3);
            utente3.Indirizzi.Add(indirizzo2utente3);

            //Inizializzo gli ordini del terzo utente
            Ordine ordine1utente3 = new Ordine(005, DateTime.Now, new List<Prodotto>() { zaino2, scarpe1, borraccia2 }, new Spedizione(3231, "Bartolini", indirizzo1utente2, DateTime.Now), metodo2);
            Ordine ordine2utente3 = new Ordine(006, DateTime.Now, new List<Prodotto>() { tenda1, scarpe2 }, new Spedizione(0042, "CorriereEspresso", indirizzo2utente2, DateTime.Now), metodo4);
            Ordine ordine3utente3 = new Ordine(007, DateTime.Now, new List<Prodotto>() { tenda1, tenda2, scarpe2 },new Spedizione(0042, "CorriereEspresso", indirizzo2utente2, DateTime.Now), metodo4);
            Ordine.CalcoloImporto(ordine1utente3);
            Ordine.CalcoloImporto(ordine2utente3);
            Ordine.CalcoloImporto(ordine3utente3);
            
            utente3.OrdiniEffettuati.Add(ordine1utente3);
            utente3.OrdiniEffettuati.Add(ordine2utente3);
            utente3.OrdiniEffettuati.Add(ordine3utente3);


            //Aggiungo gli utenti alla lista degli utenti
            listaUtenti.Add(utente1);
            listaUtenti.Add(utente2);
            listaUtenti.Add(utente3);

            //Aggiungo tutti gli ordini alla lista degli ordini
            listaOrdini.Add(ordine1utente1);
            listaOrdini.Add(ordine2utente1);
            listaOrdini.Add(ordine1utente2);
            listaOrdini.Add(ordine2utente2);
            listaOrdini.Add(ordine1utente3);
            listaOrdini.Add(ordine2utente3);
            listaOrdini.Add(ordine3utente3);

            Menu();
        
        }

        public static List<Utente> listaUtenti = new List<Utente>();

        public static List<Prodotto> listaProdotti = new List<Prodotto>();

        public static List<Ordine> listaOrdini = new List<Ordine>();
        public static void Menu()
        {
            Console.WriteLine("\nSeleziona un'operazione.");
            Console.WriteLine("1-Elenco Clienti");
            Console.WriteLine("2-Elenco Importi Ordini");
            Console.WriteLine("3-Elenco Ordini con importo minimo");
            Console.WriteLine("4-Giacenza Prodotti");
            Console.WriteLine("5-Dettagli Ordine");
            Console.WriteLine("6-Esci");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) ElencoClienti();
            else if (choice == 2) ElencoOrdini();
            else if (choice == 3) ElencoOrdiniCondizionato();
            else if (choice == 4) GiacenzaProdotti();
            else if (choice == 5) DettagliOrdine();
            else if (choice == 6) Environment.Exit(0);
            else
            {
                Console.WriteLine("Selezione non valida.");
                Menu();
            }
        }

        public static void ElencoClienti()
        {
            int i = 1;
            foreach(Utente user in listaUtenti)
            {
                Console.WriteLine($"{i}: {user.Nome} {user.Cognome}");
                i++;            
            }

            Menu();
        }

        public static void ElencoOrdini()
        {
            double totale = 0;
            foreach (Utente user in listaUtenti)
            {
                Console.WriteLine($"Cliente: {user.Nome} {user.Cognome}");
                
                foreach (Ordine order in user.OrdiniEffettuati)
                {
                    Console.WriteLine($"Ordine numero {order.IdOrdine} del {order.DataOrdine} - Importo: {order.Importo=Ordine.CalcoloImporto(order)} ");
                    totale += order.Importo;
                }
            }
            Console.WriteLine($"TOTALE IMPORTI:{totale}");

            Console.WriteLine("\n");
            Menu();
        }

        public static void ElencoOrdiniCondizionato()
        {
            Console.WriteLine("Inserire l'importo minimo:");
            double min = double.Parse(Console.ReadLine());

            foreach (Utente user in listaUtenti)
            {
                Console.WriteLine($"Cliente: {user.Nome} {user.Cognome}");

                foreach (Ordine order in user.OrdiniEffettuati)
                {
                    if (order.Importo >= min)
                    {
                        Console.WriteLine($"Ordine numero {order.IdOrdine} del {order.DataOrdine} - Importo: {order.Importo} ");
                    }
                }
            }

            Menu();
        }

        public static void GiacenzaProdotti()
        {
            Console.WriteLine("Inserire la soglia del numero di prodotti in giacenza:");
            int choice = int.Parse(Console.ReadLine());
            foreach (Prodotto product in listaProdotti)
            {
                if (product.Giacenza<choice) Console.WriteLine($"{product.NomeProdotto} - Disponibilità: {product.Giacenza}");
            }
            Menu();
        }
        public static void DettagliOrdine()
        {
            Console.WriteLine("Inserire Numero d'Ordine:");
            int id = int.Parse(Console.ReadLine());
            foreach (Ordine order in listaOrdini)
            {
                if (id == order.IdOrdine)
                {
                    Console.WriteLine($"Dettaglio ordine num. {order.IdOrdine}");
                    foreach(Prodotto product in order.ProdottiAcquistati)
                    {
                        Console.WriteLine($"{product.NomeProdotto}, {product.Brand}, {product.Descrizione}, {product.Prezzo}");
                    }
                    order.Importo=Ordine.CalcoloImporto(order);
                    Console.WriteLine($"\nTOTALE: {order.Importo}");
                    Console.WriteLine($"Ordine effettuato in data {order.DataOrdine} - Spedito da {order.DatiSpedizione.Corriere} in data {order.DatiSpedizione.DataSpedizione}");

                    Menu();
                }
            }
            DettagliOrdine();
        }
    }

    public class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public List<Indirizzo> Indirizzi { get; set; }  = new List<Indirizzo>();
        public List<MetodoPagamento> MetodiPagamento { get; set; } = new List<MetodoPagamento>();
        public List<Ordine> OrdiniEffettuati { get;set; } = new List<Ordine>();

        public Utente()
        {

        }

        public Utente(string nome, string cognome) 
        {
            Nome = nome;
            Cognome = cognome;
        }
        public Utente(string nome, string cognome, List<Indirizzo> indirizzi, List<MetodoPagamento> metodiPagamento, List<Ordine> ordiniEffettuati)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzi = indirizzi;
            MetodiPagamento = metodiPagamento;
            OrdiniEffettuati = ordiniEffettuati;
        }

    }

    public class Indirizzo
    {
        public string Via { get; set; }
        public string Citta { get; set; }
        public int CAP { get; set; }

        public Indirizzo(string via, string citta, int cap)
        {
            Via = via;
            Citta = citta;
            CAP = cap;
        } 
    }
    
    public class MetodoPagamento
    {
        public string Metodo { get; set; }

        public MetodoPagamento (string metodo)
        {
            Metodo = metodo;
        }

    }
    public class Ordine
    {
        public int IdOrdine { get; set; }
        public DateTime DataOrdine { get; set; }

        public List<Prodotto> ProdottiAcquistati = new List<Prodotto>();
        public double Importo { get; set; }
        public Spedizione DatiSpedizione { get; set; }
        public MetodoPagamento Pagamento { get; set; }

        public Ordine (int idOrdine, DateTime dataOrdine, List<Prodotto> prodottiAcquistati, Spedizione datiSpedizione, MetodoPagamento pagamento)
        {
            IdOrdine = idOrdine;
            DataOrdine = dataOrdine;
            ProdottiAcquistati = prodottiAcquistati;
            DatiSpedizione = datiSpedizione;
            Pagamento = pagamento;
        }

        public static double CalcoloImporto(Ordine order)
        {
            double importo = 0;
            foreach (Prodotto product in order.ProdottiAcquistati)
            {
                importo += product.Prezzo;
            }
            return importo;
        }
    }

    public class Spedizione
    {
        public int IdSpedizione { get; set; }
        public string Corriere { get; set; }
        public Indirizzo IndirizzoSpedizione { get; set; }
        public DateTime DataSpedizione { get; set; }

        public Spedizione (int idSpedizione, string corriere, Indirizzo indirizzoSpedizione, DateTime dataspedizione)
        {
            IdSpedizione = idSpedizione;
            Corriere = corriere;
            IndirizzoSpedizione = indirizzoSpedizione;
            DataSpedizione = dataspedizione;
        }
    }
    public class Prodotto
    {
        public string NomeProdotto { get; set; }
        public string Brand { get; set; }
        public string Descrizione { get; set; }
        public int Giacenza { get; set; }
        public double Prezzo { get; set; }

        public Prodotto(string nomeProdotto, string brand, string descrizione, int giacenza, double prezzo)
        {
            NomeProdotto = nomeProdotto;
            Brand = brand;
            Descrizione = descrizione;
            Giacenza = giacenza;
            Prezzo = prezzo;
        }
    }
}
