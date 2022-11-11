using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Microsoft.CognitiveSearch.Skills.Cryptonyms
{
    class CryptonymLinker
    {
        public CryptonymLinker(string executingDirectoryPath)
        {
            string json = File.ReadAllText($"{executingDirectoryPath}\\CryptonymLinker\\cia-cryptonyms.json");
            Cryptonyms = new List<string>(JsonConvert.DeserializeObject<List<string>>(json));
        }

        public List<string> Cryptonyms
        {
            get; private set;
        }
    }
}
