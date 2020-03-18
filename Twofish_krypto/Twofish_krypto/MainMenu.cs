using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twofish_krypto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            Encryption EncryptWin = new Encryption();
            EncryptWin.ShowDialog();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            Decryption DecryptWin = new Decryption();
            DecryptWin.ShowDialog();
        }

        private void Steps_Click(object sender, EventArgs e)
        {
            Steps StepsWin = new Steps();
            StepsWin.ShowDialog();
        }
    }
}
