/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using ClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ficha_de_Exercicios_IPMA___1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dicLocais = LoadLocalInfo();

            foreach (KeyValuePair<int, string> kv in dicLocais)
            {
                PrevisaoIpmaModel currentPrevisao = await PrevisaoProcessor.LoadPrevisoes(kv.Key);

                currentPrevisao.local = kv.Value;

                WriteFiles(currentPrevisao);
            }

            Console.WriteLine("Finished !");
            Console.ReadKey();
        }

        /// <summary>
        /// Loads Info from locais.csv
        /// Function provided by teacher Luis Ferreira.
        /// </summary>
        /// <returns></returns>
        private static Dictionary<int, string> LoadLocalInfo()
        {
            Dictionary<int, string> dicLocais = new Dictionary<int, string>();

            // Expressão Regular para instanciar objeto Regex
            String erString = @"^[0-9]{7},[123],([1-9]?\d,){2}[A-Z]{3},([^,\n]*)$";

            Regex g = new Regex(erString);
            using (StreamReader r = new StreamReader("../../../locais.csv"))
            {
                string line;

                while ((line = r.ReadLine()) != null)
                {
                    Match m = g.Match(line);
                    if (m.Success)
                    {
                        string[] campos = m.Value.Split(',');
                        int codLocal = int.Parse(campos[0]);
                        string cidade = campos[5];

                        dicLocais.Add(codLocal, cidade);
                    }
                }
            }
            return dicLocais;
        }

        /// <summary>
        /// Writes Json File.
        /// </summary>
        /// <param name="currentPrevisao"></param>
        private static void WriteFiles(PrevisaoIpmaModel currentPrevisao)
        {
            // Writes json File
            using (StreamWriter file = File.CreateText($@"./output/{currentPrevisao.globalIdLocal}-detalhe.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, currentPrevisao);
            }
        }
    }
}
