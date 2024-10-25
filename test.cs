using System;

namespace MyApp
{
    // Definiert eine Klasse namens 'Test'
    public class Test
    {
        // Ein privates Feld, das nur innerhalb der Klasse zug�nglich ist
        private string message;

        // Ein �ffentlicher Konstruktor, der aufgerufen wird, wenn eine Instanz der Klasse erstellt wird
        public Test(string initialMessage)
        {
            // Initialisiert das private Feld 'message' mit dem �bergebenen Wert
            message = initialMessage;
        }

        // Eine �ffentliche Methode, die das aktuelle Message-Feld zur�ckgibt
        public string GetMessage()
        {
            return message;
        }

        // Eine �ffentliche Methode, um das Message-Feld zu �ndern
        public void SetMessage(string newMessage)
        {
            message = newMessage;
        }

        // Eine �ffentliche Methode, die das Message-Feld auf die Konsole ausgibt
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }

    // Die Hauptmethode, die beim Programmstart ausgef�hrt wird
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellt eine neue Instanz der 'Test'-Klasse mit einer anf�nglichen Nachricht
            Test myTest = new Test("Hallo, Welt!");

            // Ruft die PrintMessage-Methode auf, um die Nachricht auf die Konsole zu drucken
            myTest.PrintMessage();

            // �ndert die Nachricht und druckt sie erneut
            myTest.SetMessage("Neue Nachricht!");
            myTest.PrintMessage();
        }
    }
}
