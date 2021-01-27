using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoUrSeCrEtS
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> encodings = new Dictionary<string, string>();

        private void DicInit()
        {
            encodings.Add("简体中文 (GB2312)", "gb2312");
            encodings.Add("简体中文 (GB18030)", "GB18030");
            encodings.Add("繁体中文 (Big5)", "big5");
            encodings.Add("日语 (Shift-JIS)", "shift_jis");
            encodings.Add("Unicode (UTF-8)", "utf-8");
            encodings.Add("Unicode", "utf-16");
            encodings.Add("Unicode (Big-Endian)", "UnicodeFFFE");
            encodings.Add("Unicode (UTF-7)", "utf-7");
            encodings.Add("Unicode (UTF-32)", "utf-32");
            encodings.Add("Unicode (UTF-32 Big-Endian)", "utf-32BE");
        }

        public Form1()
        {
            InitializeComponent();
            DicInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var ec in encodings)
            {
                LeftComboBox.Items.Add(ec.Key);
                RightComboBox.Items.Add(ec.Key);
            }
            LeftComboBox.SelectedItem = "Unicode (UTF-8)";
            RightComboBox.SelectedIndex = 0;
        }

        private string Translate(string words, string fromCoding, string toCoding)
        {
            Encoding from = Encoding.GetEncoding(fromCoding);
            byte[] fromBytes = from.GetBytes(words);
            Encoding to = Encoding.GetEncoding(toCoding);
            string toString = to.GetString(fromBytes);
            return toString;
        }

        private void LeftToRightButton_Click(object sender, EventArgs e)
        {
            string input = LeftTextBox.Text;
            if (input == "") return;
            string fromCoding = encodings[LeftComboBox.Text];
            string toCoding = encodings[RightComboBox.Text];
            string output = Translate(input, fromCoding, toCoding);
            RightTextBox.Text = output;
        }

        private void RightToLeftButton_Click(object sender, EventArgs e)
        {
            string input = RightTextBox.Text;
            if (input == "") return;
            string fromCoding = encodings[RightComboBox.Text];
            string toCoding = encodings[LeftComboBox.Text];
            string output = Translate(input, fromCoding, toCoding);
            LeftTextBox.Text = output;
        }
    }
}
