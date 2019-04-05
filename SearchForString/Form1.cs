using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            lstFound.Items.Clear();
            string SearchText = txtString.Text;
            int SearchLength = SearchText.Length;
            int MinSearchLen, MaxSearchLen = 0;
            string FSearchText, LSearchText = "";
            MinSearchLen = 2;
            MaxSearchLen = 30;
            
            for (int Cursor = 0; Cursor < SearchLength; Cursor++)
            {
                for (int Word = MinSearchLen; Word <= MaxSearchLen; Word++)
                {
                    if (Cursor + Word > SearchLength)
                        break;
                    FSearchText = SearchText.Substring(Cursor, Word);
                    LSearchText = Reverse(FSearchText);
                    if (FSearchText == LSearchText)
                    {
                        lstFound.Items.Add(FSearchText);
                    }
                }
            }

        }

        public static string Reverse(string Text)
        {
            char[] charArray = Text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
