using Google.Protobuf.WellKnownTypes;
using Microsoft.Graph;
using System;
using System.Windows.Forms;
using Teste_tecnico.Interfaces;
using Teste_tecnico.Viewers;




namespace Teste_tecnico
{
    internal static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());

        }
           
    }
}
