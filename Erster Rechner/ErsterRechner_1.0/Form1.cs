using System;
using System.Windows.Forms;

namespace ErsterRechner
  {
  public partial class Form1: Form
    {
    public Form1()
      {
      InitializeComponent();
      }

    private void textBox1_TextChanged( object sender, EventArgs e )
      {

      // Versuch, die Eingabe des Benutzers als int zu parsen
      if ( int.TryParse( byte_input.Text, out int inputNumber ) )
        {
        // �berpr�fe, ob die Zahl im g�ltigen Bereich f�r einen Byte-Wert liegt (0 bis 255)
        if ( inputNumber >= 0 && inputNumber <= 255 )
          {
          // Berechne das Doppelte als int
          int result = inputNumber * 2;

          // Zeige das Ergebnis in der Ausgabebox an
          byte_output.Text = result.ToString();
          }
        else
          {
          // Zeige eine Fehlermeldung an, wenn die eingegebene Zahl nicht im g�ltigen Byte-Bereich liegt
          MessageBox.Show( "Bitte gib eine Zahl zwischen 0 und 255 ein.", "Ung�ltige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning );

          // Leere das Ausgabefeld
          byte_output.Text = "";
          }
        }
      else
        {
        // Zeige eine Fehlermeldung an, wenn die Eingabe keine g�ltige Zahl ist
        MessageBox.Show( "Bitte gib eine g�ltige Zahl ein.", "Ung�ltige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning );

        // Leere das Ausgabefeld
        byte_output.Text = "";
        }
      }
    }
  }
