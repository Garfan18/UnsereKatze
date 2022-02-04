using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textgeschichte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zeitschleife";
            // abschnitt für das Titelbild

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("                                                  Zeitschleife");
            Console.WriteLine();
            Console.WriteLine("                                                  [");
            Console.WriteLine("                                             @xxxx[{::::::::::::>");
            Console.WriteLine("                                                  [");
            Console.WriteLine();
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("***********************************************************************************************************************");

            string startaufvorderung = "Drücke die Enter-Taste um das Spiel zu starten.";
            SlowTyping(startaufvorderung);
            
            string Starttaste = Console.ReadLine();
            // leere Variable "" bedeutet, man hat nur Enter gedrückt
            
            if (Starttaste == "")
            {
                Console.Clear();
                // Glütige Starteingabe.

                // Szene 1
                // Einführungstext schreiben
                string einführungstext = "Du wachst zuhause in deinem Bett auf. " +
                    "Ein kurzer Blick auf deinen Wecker verrät dir das " +
                    "es 1:00 Uhr ist.  Du fragst dich was dich geweckt " +
                    "hat, bis du feststellst das sich dein Hals ganz " +
                    "trocken anfühlt. Also stehst du auf um dir in der " +
                    "Küche ein Glas Wasser zu holen. Du gehst langsam die " +
                    "Kellertreppe hoch da sich dein Zimmer im Keller befindet. " +
                    "Oben angekommen läufst du durch den dunklen ganz zur Küche. " +
                    "Dabei trittst du in etwas Flüssigen. Dein erster Gedanke war" +
                    " das euer Familien Hund einen kleinen Unfall hatte, also " +
                    "läufst du angewidert weiter und last deiner Mutter morgen" +
                    " die Lache aufputzen. Als du in der Küche warst schlosst du " +
                    "die Tür hinter dir da du niemanden wecken möchtest. Du holst " +
                    "dir ein Küchenpapier um deinen fuss zu putzen. Als du dann " +
                    "das Tuch wegwerfen wolltest erkennst du im leichten Mondlicht" +
                    ", dass es dunkle Flecken hatte. Verwundert schaltest du deine " +
                    "Handytaschenlampe an und stellst fest das es sich um Blut " +
                    "handelte. Was machst du als nächstes?";
                SlowTyping(einführungstext);
                // Option A
                Console.WriteLine("A: Gehst du A: hoch zu deinen Eltern " +
                    "und weckst sie wegen des Blutes oder …");
                // Option B
                Console.WriteLine("B:untersuchst du zuerst die Blutlache, da vielleicht deine Katze " +
                    "dort ein Tier geschlachtet hat? ");
                Console.WriteLine("Schreibe A oder B! Bestätige mit der Enter-Taste.");
                string eingabe = Console.ReadLine();
                // Wenn man A eingegeben hat...
                if (eingabe.ToUpper() == "A")
                {
                    Console.WriteLine("A: du gehst zur Treppe und siehst wie ein Fussspur aus Blut die Treppe hochführt." +
                        "Als du die Treppe hochrannst und " +
                        "in das Zimmer deiner Eltern platzt siehst du einen grossen man vor ihrem Bett mit einem " +
                        "Riesenmesser in der Hand voller Blut. " +
                        "Vor Angst erstarrst du und somit konnte er dich packen und dir ins herz stechen. " +
                        "Du starbst auf der Stelle. Game Over. ");
                }
                // falls nicht, dann...
                else if (eingabe.ToUpper() == "B")
                {
                    // Szene2B
                    // Einführungstext
                    Console.WriteLine("B: du gehst schleichend aus der Küche ohne etwas zu trinken. Mit der Handytaschenlampe " +
                        "gehst du den Gang entlang. Schon von der ferne erkennst du das es sich um eine viel zu grosse Blutlache handelt als es von einem kleinen Tier stammt. " +
                        "Von der Blutlache gehen drei Spuren weg. Die erste ist deine eigene Fussspur da es sich nur um einen Fussabdruck handelt. " +
                        "Die zweite spur ist eine Schleifspur und " +
                        "die dritte eine fussabtruck Spur. Welche Spur gehst du nach? ");
                    // Option A
                    Console.WriteLine("A: Der Schleifspur oder…");

                    // Option B
                    Console.WriteLine("B: der Fussabdruckspur?");
                    // Benutzer auffordern
                    Console.WriteLine("Schreibe A oder B! Bestätige mit der Enter-Taste.");
                    // Eingabe auslesen
                    string eingabe2 = Console.ReadLine();
                    // Wenn man A eingegeben hat
                    if (eingabe2.ToUpper() == "A")
                    {
                        // Szene 3A
                        // Einführungstext
                        Console.WriteLine("A: Du gehst leise der Schleifspur nach. Sie führt in das " +
                            "Wohnzimmer hinter das Sofa. " +
                            "Du musst mit schrecken feststellen das " +
                            "die Spur vom Familien Hund stammt. " +
                            "Als du geschockt da standst hörst du plötzlich " +
                            "schwere Schritte im oberen Geschoss. " +
                            "Da du die Schritte " +
                            "von deiner Familie kennst wird dir bewusst " +
                            "das du diese Schritte noch nie gehört hast. " +
                            "Was machst du als nächstes? ");

                        // Option A
                        Console.WriteLine("A: Du untersucht die Hundeleiche, " +
                            "um zu schauen ob er sich selbst " +
                            "verletzt hat oder ob er verletzt wurde oder…");
                        // Option B
                        Console.WriteLine("B: du gehst hoch um herauszufinden wer herumlauft?");
                        // Spieler auffordern
                        Console.WriteLine("Schreibe A oder B! Bestätige mit der Enter-Taste.");
                        // Eingabe auslesen
                        string eingabe3 = Console.ReadLine();

                        // Wenn man A eingegeben hat, dann...
                        if (eingabe3.ToUpper() == "A")
                        {
                            // Szene 4A

                            // Einführungstext
                            Console.WriteLine("Du entscheidest dich die Leiche des " +
                                "Hundes zu untersuchen. Da es sich vielleicht " +
                                "um heimlicher besuch deines älteren Bruders handelt. " +
                                "Jedoch findest du schnell heraus das es nicht so ist. " +
                                "Denn du siehst mehrere einstichwunden eines grossen " +
                                "Messers im " +
                                "Körper des Familienhundes befindet. Nun ist dir bewusst, " +
                                "dass es sich um einen Mörder handelt. Wie handelst du nun? ");

                            //Option A
                            Console.WriteLine("A: Rufst du die Polizei, ...");
                            //Option B
                            Console.WriteLine("B: suchst nach einem Versteck oder");
                            //Option C
                            Console.WriteLine("C: besorgst du dir eine Waffe?");
                            //Spieler Auffordern
                            Console.WriteLine("Schreibe A, B oder C! Bestätige mit der Enter-Taste.");

                            //Eingabe auslesen
                            string eingabe4 = Console.ReadLine();

                            //Wenn man A eingibt, dann..
                            if (eingabe4.ToUpper() == "A")
                            {
                                // Game over
                                Console.WriteLine("Du Holst dein Handy heraus und willst " +
                                    "die Polizei anrufen. Jedoch hast du vergessen " +
                                    "das du noch auf einem Video warst, welches auf voller " +
                                    "Lautstärke eingeschalten ist. Du Tipps aus Panik schnell auf dem " +
                                    "Touchbildschirm herum. Jedoch ist es schon zu späht. " +
                                    "Ein grosse Mann steht vor dir und rammt ein Messer in dein " +
                                    "Schlüsselbein wobei deine Halsschlagader getroffen wurde. " +
                                    "Du verblutest in Sekunden. Game over");
                            }
                            //Wenn man B eingibt, dann..
                            if (eingabe4.ToUpper() == "B")
                            {
                                //Szene5

                                //Einführungstext
                                Console.WriteLine("Das wichtigste ist das du dir zuerst ein Versteck suchst, denkts du dir. " +
                                    "Die frage ist wohin? Gehst du …");
                                //Option 1 "Unter dem Bett"
                                Console.WriteLine("1: in dein Zimmer zurück (wo du sehr schlechten Empfang hast mit deinem Handy),");
                                //Option 2 "Unter dme Tisch"
                                Console.WriteLine("2: Du versteckst dich unter dem Tisch");
                                // Option 3 "Im Schrank"
                                Console.WriteLine("3: Du versteckst dich im Wandschrank");
                                // Option 4 "Hinter der Türe"
                                Console.WriteLine("4: Du versteckst dich hinter der Tür");
                                //Spieler Auffordern
                                Console.WriteLine("Schreibe 1, 2, 3 oder 4! Bestätige mit der Enter-Taste.");
                                //Eingabe auslesen
                                // eingabe als Text
                                string eingabe5 = Console.ReadLine();


                                // wird umgewandelt string -> int
                                int eingabe5alszahl;
                                eingabe5alszahl = Convert.ToInt32(eingabe5);

                                //überprüfe die variable...
                                switch (eingabe5alszahl)
                                {
                                    //Wenn antwort 1, dann...
                                    case 1:
                                        // Wenn der spieler 1 gewählt hat...
                                        Console.WriteLine("Du schleichst dich wieder zurück zu deinem Zimmer. " +
                                            "Als du die Kellertür öffnest und auf die " +
                                            "Treppe gehst stolperst du unbewusst über eure Katze. Dabei fällst " +
                                            "du so unglücklich das du dir dein Genick brichst und sofort stirbst. Game over");
                                        break;
                                    //Wenn antwort 2, dann...
                                    case 2:
                                        // Wenn der spieler 2 gewählt hat...
                                        Console.WriteLine("Du kriechst langsam unter den Wohnzimmertisch. Jedoch greifst du mit einer " +
                                            "Hand plötzlich in irgendetwas klitschiges und schreist auf. " +
                                            "Es handelt sich dabei um das Abendmahl deiner Katze, eine Maus. " +
                                            "Schon wird der Tisch über dir weggerissen und du wirst erstochen. Game over.");
                                        break;
                                    //Wenn antwort 3, dann...
                                    case 3:
                                        // Wenn der spieler 3 gewählt hat...
                                        // Szene 6
                                        Console.WriteLine("Szene 6");
                                        //Einführungstext
                                        Console.WriteLine("Du schleichst dich zum Wandschrank und versteckst dich darin. " +
                                            "Jedoch lässt du einen kleinen Spalt offen um zu sehen, " +
                                            "wenn der Einbrecher die Treppe runterkommt. " +
                                            "Du machst deine Handytaschenlampe " +
                                            "an um zu schauen ob sich etwas hilfreiches im Schrank befindet. " +
                                            "Du entdeckst den Fuchsschwanz von deinem Vater und nimmst ihn an dich. " +
                                            "Nun hast du auch eine Waffe. " +
                                            "Gerade als du das Licht ausgemacht hast hörst du kratzende Geräusche von der Kellertür. " +
                                            "Dir wurde bewusst das es sich um eure Katze handeln muss welche wieder rein will. " +
                                            "Schon hörst du schnelle Schritte welche die Treppen runterkommen und zur Türe stürmen. " +
                                            "Ein grosse man Mit einem riessen Messer in der Hand welches in " +
                                            "Blut getränkt war reisst die Kellertür auf. Dabei erschreckte " +
                                            "er eure Katze Welche wieder in denn Keller flüchtet. Mit einem Seufzer folgte der Mann ihr. Was machst du nun? " +
                                            "Schleicht du dich zur Keller Tür und versuchst den Mann zu töten, " +
                                            "wenn er wieder Rauskommst oder Sperrst du ihn in den Kellern ein?");
                                        //Option A
                                        Console.WriteLine("A:Schleichst du dich zur Keller Tür und versuchst den Mann zu töten, wenn er wieder rauskommt oder…");
                                        //Option B
                                        Console.WriteLine("B: Sperrst du ihn in den Kellern ein?");
                                        //Spieler Auffordern
                                        Console.WriteLine("Schreibe A oder B! Bestätige mit der Enter-Taste.");
                                        //Eingabe auslesen
                                        string eingabe6 = Console.ReadLine();
                                        //Wenn man A eingibt...
                                        if(eingabe6 == "A")
                                        {
                                            //Wenn der Spieler A gewählt hat...
                                            // Game over!
                                            Console.WriteLine("Du Schleichst dich zur Tür und Platzierst dich nebendran bereit den Mann anzugreifen, wenn er herauskommt. " +
                                                "Nach 5 min hörst du die Kellertreppe und machst dich bereit. " +
                                                "Als die Tür aufsprang schwingst du den Fuchsschwanz los und triffst auch was. " +
                                                "Jedoch ertönt ein schrecklicher schrei einer Katze und nicht eines Menschens. " +
                                                "Du stellst mit schrecken fest das der Mann die Katze als Schutz vor sich gehalten hat als er ahnte das ich da war. " +
                                                "Nun schnellte ein Messer in deine Richtung und Tötet dich sofort. Game over");
                                            
                                        }
                                        //Wenn man B eingibt...
                                        if(eingabe6 == "B")
                                        {
                                            //Wenn der Spieler B gewählt hat...
                                            //Ende
                                            Console.WriteLine("Du Schleichst zur Keller Tür und schliesst sie mit dem Schlüssel ab. " +
                                                "Danach stellst du noch einen Stuhl dagegen und rufst mit dem Handy schnell die Polizei an. " +
                                                "Nach nur 5 Min hörst du die Sirenen ausserhalb jedoch hörst du auch wie der Mann versucht die Tür aufzubrechen. " +
                                                "Der Mann wurde verhaftet jedoch wurde deine ganze Familie umgebracht bis auf deine Katze. " +
                                                "Du hebst deine Katze auf jedoch war die noch so schreckhaft, dass sie dich kratzte. " +
                                                "In dem Moment als du den schmerz spürst schreckst du in deinem Bett auf. " +
                                                "Es war nur ein Traum? Du drehst deinen Kopf und siehst wie die Uhr direkt auf 01:00 Uhr springt und sich dein Hals trocken anfühlt. ");
                                        }

                                        break;

                                    //Wenn antwort 4, dann...
                                    case 4:
                                        // Wenn der spieler 4 gewählt hat...
                                        Console.WriteLine("Du schleichst dich zurück zum Keller und willst dich hinter der Tür verstecken. " +
                                            "Dabei stolperst du über eure Katze und fällst " +
                                            "die Kellertreppe runter. Dabei brichst du dir das Genick. Game over.");
                                        break;
                                    //Wenn nicht, dann...
                                    default:
                                        Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
                                        break;
                                }
                            }
                            //Wenn man C eingibt, dann..
                            if (eingabe4.ToUpper() == "C")
                            {
                                // Game Over
                                Console.WriteLine("Du entscheidest dich eine Waffe " +
                                    "zu holen um dich zu verteidigen. " +
                                    "Du schleichst dich in die Küche und suchst nach einem Messer. " +
                                    "Als du gerade die Messer Schublade öffnest " +
                                    "stosst du ausversehen einen Topf um der mit einem grossen " +
                                    "Knall auf dem Boden landet. Sofort hörst " +
                                    "du schnelle Schritte vom oberen Geschoss. " +
                                    "Aus Panik greifst du nach einem Messer und " +
                                    "schneidest dich dabei. Schon sprang die Tür " +
                                    "der Küche auf und ein Messer flog in " +
                                    "dein rechtes Auge und durchbohrt dein Gehirn. " +
                                    "Du bist Tod. Game over. ");
                            }

                        }
                        //Fals nicht, dann ...
                        else
                        {
                            // Szene 4B
                            Console.WriteLine("Du gehst hoch ins obere Stockwerk. " +
                                "Du hörst wie die Schritte " +
                                "vom Zimmer deinem älteren Bruder kommen. " +
                                "Du denkst das er vielleicht heimlichen " +
                                "besuch hat als du einen dumpfen schrei hörst. " +
                                "Du läufst schnell zum Zimmer und reisst die Tür auf. " +
                                "Du siehst gerade noch wie dein Bruder stirbt, " +
                                "als ein grosser Mann ihm ein Kiesen aufs Gesicht drückt. " +
                                "Du schreist auf und willst fliehen. Jedoch spürst du einen stechenden " +
                                "Schmerz im rücken als du aus der Tür rennst. " +
                                "Du fällst hin und der man packt dich bei den Haaren. " +
                                "Mit voller Kraft rammt er dein Gesicht mehrmals auf den " +
                                "Boden bis dir vor Schmerzen schwarz vor den Augen wird. " +
                                "Du stirbst nach qualvollen Minuten. Game over.");
                        }

                    }
                    // Fals nicht, dann ...
                    else
                    {
                        Console.WriteLine("Du gehst der Fussabdruckspur nach " +
                            "und siehst wie sie die Treppe hochgeht. Als du " +
                            "oben an der Treppe ankamst siehst du wie ein" +
                            " grossem man gerade aus dem Zimmer deiner " +
                            "Eltern heraustritt. Er hat ein grosses Messer" +
                            " in der Hand. Du erstarrst vor Angst. In " +
                            "dieser Zeit bewegte sich der Mann schnell" +
                            " und leise auf dich zu, packt dich und sticht " +
                            "mit dem Messer mehrmals auf dich ein. Du " +
                            "stirbst und es ist Game over. ");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
                }
                
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
            }
            Console.ReadKey();



        }

        private static void SlowTyping(string myText)
        {
            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i]);
                System.Threading.Thread.Sleep(70);
            }
        }
    }
}
