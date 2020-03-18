using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Twofish_krypto
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void ChooseFrom_Click(object sender, EventArgs e)
        {
            var dialogRes = openFileDialog1.ShowDialog(this);
            if (dialogRes == DialogResult.OK)
            {
                WayFrom.Text = openFileDialog1.FileName;
            }
        }

        private void ChooseWhere_Click(object sender, EventArgs e)
        {
            var dialogRes = saveFileDialog1.ShowDialog(this);
            if (dialogRes == DialogResult.OK)
            {
                WayTo.Text = saveFileDialog1.FileName;
            }
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            //var len = TwofishAlgo.testKey.Length;
            var openMessage = File.ReadAllText(@WayFrom.Text);
            var openMessageBin = StringMethods.ConvertTextToBinString(openMessage);
            List <string> encodedBlocks = new List <string>();
            List<byte> intViewOfBytes = new List<byte>();
            string result = "";
            //byte[] bytesResult = new byte[];
            if (openMessageBin.Length % 128 != 0)
            {
                for (int i = openMessageBin.Length % 128; i < 128; i++)
                    openMessageBin += "0";
            }
            var blocks128bit = StringMethods.StringToList(openMessageBin, 128);
            foreach (string block in blocks128bit)
            {
                encodedBlocks.Add(TwofishAlgo.Cyphering(block, TwofishAlgo.testKey));
            }
            var binaryResultString = StringMethods.ListToString(encodedBlocks);
            var bytesResultHashset = StringMethods.StringToList(binaryResultString, 8);
            foreach (string resultByte in bytesResultHashset)
            {
                intViewOfBytes.Add(Convert.ToByte(Convert.ToInt32(resultByte, 2))) ;
            }

            var arrayOfBytes = intViewOfBytes.ToArray();
            Encoding encoding = Encoding.GetEncoding(1251);
            for (int i = 0; i < arrayOfBytes.Count(); i++)
            {
                byte [] oneByte = new byte[1];
                oneByte [0] = arrayOfBytes[i];
                result += encoding.GetString(oneByte);
            }
            File.WriteAllText(WayTo.Text, result, Encoding.UTF8);
            var fileName = Convert.ToString(DateTime.Now).Replace(":", "_");
            string keyPath = "G:\\KINGSTON\\8 сем\\КМЗИ\\лаб3+дз\\" + fileName + ".txt";
            File.WriteAllText(keyPath, TwofishAlgo.testKey);
        }
    }
}
