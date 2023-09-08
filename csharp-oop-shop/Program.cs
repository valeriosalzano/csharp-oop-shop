namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // creazione base dati
            Prodotto[] arrayDiProdotti = new Prodotto[5];
            int[] arrayDiNumeri = new int[5];

            string[] nomeProdotti =
            {
                "La ruota del tempo: L'occhio del mondo",
                "La saga di Terramare: Il mago ",
                "Cronache del mondo emerso: Nihal della Terra del Vento",
                "Ciclo dell'eredità: Eragon",
                "Il signore degli anelli: La compagnia dell'anello"
            };

            string[] descrizioneProdotti =
            {
                "Fervono i preparativi per la festa di primavera, nella regione dei Fiumi Gemelli, e il giovane Rand al'Thor è ansioso di lasciarsi alle spalle un anno difficile, pieno di cattivi presagi. Alcuni stranieri si aggirano per il villaggio di Emond's Field, e non si parla d'altro: un'elegante dama accompagnata da un gelido cavaliere, misteriose figure a cavallo che spariscono nel nulla, un menestrello desideroso di cantare epiche gesta. Sono giunte notizie di una guerra in remote contrade e dell'ascesa di un falso Drago, la cui venuta, temuta e annunciata, porterà una nuova Frattura nel mondo. E il Male si addensa: creature malvagie e leggendarie, i bestiali Trolloc assetati di sangue, si sono scatenate nella caccia a un ragazzo che il Tenebroso sembra temere, e che vuole in ogni modo asservire... Nulla sarà più come prima, nel Disegno delle Epoche tessuto dalla Ruota del Tempo: un mondo inquieto e sgomento si appresta a essere di nuovo preda dell'Ombra. Che la saga abbia inizio...",
                "Scritto più di trent'anni fa, il romanzo narra le vicende di un bimbo diverso da tutti gli altri, Duny, capace di piegare gli animali alla propria volontà con piccoli, misteriosi incantesimi. Poi, una volta cresciuto, l'hanno chiamato Ged, lo Sparviere: un giovane mago che deve compiere un complesso apprendistato per conoscere meglio i suoi immensi poteri e usarli contro il male. Età di lettura: da 10 anni.",
                "Nihal è davvero strana. Nel Mondo Emerso sembra non esserci nessuno come lei: grandi occhi viola, orecchie appuntite, capelli blu. Cresciuta da un armaiolo, vive in una delle tante città-torri della Terra del Vento, giocando a combattere insieme a un gruppo di amici che l'ha eletta capo, in virtù della sua forza e agilità. Ma per Nihal tutto cambia all'improvviso quando la Terra del Vento viene attaccata dal Tiranno, il despota che già ha conquistato cinque delle otto Terre che compongono il Mondo Emerso. A Nihal rimane solo una scelta: diventare un vero guerriero e difendere gli innocenti che rischiano di cadere sotto il tallone dell'esercito del Tiranno, composto di mostri apparentemente imbattibili. Potrà contare solo su due validi alleati: Sennar, il giovane mago che è diventato il suo \"inseparabile nemico\" e soprattutto la sua infallibile spada di cristallo nero.",
                "Quando Eragon trova una liscia pietra blu nella foresta, è convinto che gli sia toccata una grande fortuna: potrà venderla e nutrire la sua famiglia per tutto l'inverno. Ma la pietra in realtà è un uovo. Quando si schiude rivelando il suo straordinario contenuto, un cucciolo di drago, Eragon scopre che gli è toccato in sorte un'eredità antica come l'Impero. Forte di una spada magica e dei consigli di un vecchio cantastorie, dovrà cavarsela in un universo denso di magia, mistero e insidie, imparare a distinguere l'amico dal nemico, dimostrare di essere il degno erede dei Cavalieri dei Draghi.",
                "Composto da tre romanzi pubblicati in Gran Bretagna fra il 1954 e il 1955, Il Signore degli Anelli è uno dei più grandi cicli narrativi del XX secolo. J.R.R. Tolkien ha creato un mondo e un epos che da sempre affascinano e influenzano lettori e scrittori di tutto il mondo. La Compagnia dell'Anello si apre nella Contea, un idilliaco paese agricolo dove vivono gli Hobbit, piccoli esseri lieti, saggi e longevi. La quiete è turbata dall'arrivo dello stregone Gandalf, che convince Frodo a partire per il paese delle tenebre, Mordor, dove dovrà gettare nelle fiamme del Monte Fato il terribile Anello del Potere, giunto nelle sue mani per una serie di incredibili circostanze. Un gruppo di hobbit lo accompagna e strada facendo si aggiungono alla banda l'elfo, il nano e alcuni uomini, tutti uniti nella lotta contro il Male. La Compagnia affronta un cammino lungo e pericoloso, finché i suoi membri si disperdono, minacciati da forze oscure, mentre la meta sembra allontanarsi sempre di più."
            };

            decimal[] prezzoProdotti =
            {
                37.4m,
                28.7m,
                20.48m,
                25.4m,
                18.7m
            };

            for(int i = 0; i < arrayDiProdotti.Length; i++)
            {
                arrayDiProdotti[i] = new Prodotto(nomeProdotti[i], descrizioneProdotti[i], prezzoProdotti[i],0.22f);
            }

            // fine creazione base dati

            Console.WriteLine("Il nostro negozio di libri ti suggerisce i nostri 5 bestsellers!" + Environment.NewLine);

            for(int i = 0; i < arrayDiProdotti.Length; i++)
            {
                Console.WriteLine(Environment.NewLine + $"---- Libro {i+1} ----" + Environment.NewLine);
                arrayDiProdotti[i].StampaProdotto();

            }
        }
    }
}