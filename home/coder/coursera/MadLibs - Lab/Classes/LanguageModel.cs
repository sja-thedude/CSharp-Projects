using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalyst;
using Catalyst.Models;
using Microsoft.Extensions.Logging;
using Mosaik.Core;

namespace MadLibs
{
    public class LanguageModel
    {
        Pipeline nlp;

        public LanguageModel()
        {
            Initialize();
        }
        /// <summary>
        /// Initialzie the langauge model
        /// </summary>
        public void Initialize()
        {
            //Need to register the languages we want to use first
            Catalyst.Models.English.Register();

            //Configures the model storage to use the local folder ./catalyst-models/
            Storage.Current = new DiskStorage("catalyst-models");

            //Parse the documents using the English pipeline, as the text data is untokenized so far
            nlp = Pipeline.For(Language.English);

        }

        /// <summary>
        /// Extracts tokens from text. Tokens are objects that contain reference to the start and end position of a given word
        /// along with its part-of-speech tag (i.e noun,verb, det, and etc.)
        /// </summary>
        /// <param name="text"></param>
        /// <returns>A list of token objects. Tokens are objects that contain reference to the start and end position of a given word along with its part-of-speech tag (i.e noun,verb, det, and etc.) </returns>
        public List<PToken> ExtractTokens(string text)
        {
            var doc = new Document(text, Language.English);

            var result = nlp.ProcessSingle(doc);
            var tokens = new List<PToken>();
            for (int k = 0; k < doc.TokensData.Count; k++)
                for (int i = 0; i < doc.TokensData[k].Count; i++)
                {
                    var data = doc.TokensData[k][i];
                    PToken t = new PToken();
                    t.start = data.Bounds[0];
                    t.end = data.Bounds[1];
                    t.tag = data.Tag.ToString();
                    tokens.Add(t);
                }


            return tokens;
        }
    }
}

/// <summary>
/// Token singleton class. 
/// Tokens are objects that contain reference to the start and end position of a given word along with its part-of-speech tag (i.e noun,verb, det, and etc.)
/// </summary>
public class PToken
{

    public int start { get; set; }
    public int end { get; set; }

    public string tag = "";

}
