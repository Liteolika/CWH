using CWH.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWH.WinGui
{
    public partial class Form1 : Form
    {
        WordlistRepository repo;

        public Form1()
        {
            InitializeComponent();
            this.repo = new WordlistRepository();

            //repo.AddWord(new WordListEntry { Word = "RIA", Description = "Torkställe" });
            //repo.AddWord(new WordListEntry { Word = "RA", Description = "Solgud" });
            //repo.AddWord(new WordListEntry { Word = "LJUDTEKNIKER", Description = "Audiolog" });
            //repo.AddWord(new WordListEntry { Word = "SOLEN", Description = "Största stjärnan" });
            //repo.AddWord(new WordListEntry { Word = "BUDORD", Description = "De tio" });

            SearchType.DataSource = Enum.GetValues(typeof(TypeSearch));

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            TypeSearch searchType;
            Enum.TryParse<TypeSearch>(SearchType.SelectedItem.ToString(), out searchType);

            List<WordListEntry> result = new List<WordListEntry>();

            if (searchType == TypeSearch.Description)
            {
                result = repo.FindDescription(SearchText.Text);
            }

            if (searchType == TypeSearch.Word)
            {
                result = repo.FindWord(SearchText.Text, SearchPartial.Checked, '*');
            }

            ResultGrid.DataSource = result;

            var a = 1;
        }



    }

    public enum TypeSearch
    {
        Word,
        Description
    }

}
