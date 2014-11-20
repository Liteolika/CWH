using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWH.Main
{
    public class WordListEntry
    {
        public string Word { get; set; }


        public List<string> Descriptions { get; set; }

        public WordListEntry()
        {
            this.Descriptions = new List<string>();
        }

    }

    

}
