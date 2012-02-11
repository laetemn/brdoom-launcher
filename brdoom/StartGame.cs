using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
// O parametro abaixo é necessário para iniciar programas externos
using System.Diagnostics;

namespace BrDOOM
{
    public class StartGame
    {
        // Variáveis ;P
        private int valor;
        //private String playGame;

        // Carrega as configurações salvas em arquivo externo - INI
        private void LoadConfig()
        {
            //TODO
        }

        // Salva as configurações em arquivo externo - INI
        private void saveConfig()
        {
            //TODO
        }

        // Checagem de integridade de dados
        // Efetua a checagem do CRC dos IWADS
        // Verifica se os IWADs são originais
        private void checkData()
        {
            //TODO
        }

        //public void runGame(string engine, int mode, int server, int port)
        public int runGame(string argValor)
        {
            try
            {
                Process.Start(argValor);
            }
            catch (Exception erro)
            {
                Console.Write(erro.Message.ToString());
                valor = 1;
            }
            return valor;
        }

    }
}
