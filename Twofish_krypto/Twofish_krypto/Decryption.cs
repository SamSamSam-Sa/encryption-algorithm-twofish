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
    public partial class Decryption : Form
    {
        public Decryption()
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

        private void ChooseKey_Click(object sender, EventArgs e)
        {
            var dialogRes = openFileDialog1.ShowDialog(this);
            if (dialogRes == DialogResult.OK)
            {
                KeyWay.Text = openFileDialog1.FileName;
            }
        }

        private void Decypher_Click(object sender, EventArgs e)
        {
            var closedMessage = File.ReadAllText(@WayFrom.Text);
            var key = File.ReadAllText(@KeyWay.Text);
            var closedMessageBin = StringMethods.ConvertTextToBinString(closedMessage);
            List<string> decodedBlocks = new List<string>();
            List<byte> intViewOfBytes = new List<byte>();
            string result = "";

            if (closedMessageBin.Length % 128 != 0)
            {
                for (int i = closedMessageBin.Length % 128; i < 128; i++)
                    closedMessageBin += "0";
            }
            var blocks128bit = StringMethods.StringToList(closedMessageBin, 128);
            foreach (string block in blocks128bit)
            {
                decodedBlocks.Add(TwofishAlgo.Decyphering(block, key));
            }
            var binaryResultString = StringMethods.ListToString(decodedBlocks);
            var bytesResultHashset = StringMethods.StringToList(binaryResultString, 8);
            foreach (string resultByte in bytesResultHashset)
            {
                intViewOfBytes.Add(Convert.ToByte(Convert.ToInt32(resultByte, 2)));
            }

            var arrayOfBytes = intViewOfBytes.ToArray();
            Encoding encoding = Encoding.GetEncoding(1251);
            for (int i = 0; i < arrayOfBytes.Count(); i++)
            {
                byte[] oneByte = new byte[1];
                oneByte[0] = arrayOfBytes[i];
                result += encoding.GetString(oneByte);
            }
            File.WriteAllText(WayTo.Text, result, Encoding.UTF8);
        }
    }
}
