using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ClassLibrary;
using Newtonsoft.Json;

namespace Ficha_de_Exercicios_IPMA
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dicLocais = await LoadLocalInfo();

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
        /// Writes the .json and .xml files.
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

            // Writes xml File
            using (StreamWriter file = File.CreateText($@"./output/{currentPrevisao.globalIdLocal}-detalhe.xml"))
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(PrevisaoIpmaModel));
                writer.Serialize(file, currentPrevisao);
            }

        }

        /// <summary>
        /// Loads Info from Locais and returns a dictionary.
        /// </summary>
        /// <returns></returns>
        private static async Task<Dictionary<int,string>> LoadLocalInfo()
        {
            var locais = await LocalProcessor.LoadLocais();

            return locais.GroupBy(l => l.globalIdLocal).ToDictionary(k => k.Key, v => v.Select(f => f.local).First());
        }
    }
}
