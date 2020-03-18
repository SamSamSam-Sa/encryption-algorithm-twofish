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
    public partial class Steps : Form
    {
        public Steps()
        {
            InitializeComponent();
        }

        private void DoCalculations_Click(object sender, EventArgs e)
        {
            InputData.Text = StringMethods.DataBlockGen(128);
            //var data = InputData.Text;
            var key = StringMethods.DataBlockGen(Convert.ToInt32(InputKey.Text, 10));
            InputKey.Text = key;
            var dialogRes = saveFileDialog1.ShowDialog(this);
            if (dialogRes == DialogResult.OK)
            {
                ResultFileWay.Text = saveFileDialog1.FileName;
            }
            LogEncrypt(key, InputData.Text, ResultFileWay.Text);
        }


        public static void LogEncrypt(string key, string openMes, string fileWay)
        {

            StringBuilder strBuild = new StringBuilder();
            int[] blocksAfterInputWhiting = new int[4];
            int[] blocksAfterOutputWhiting = new int[4];
            List<string> closedMessage = new List<string>();
            var subkeysArr = SubkeysGen.SubKeysGeneration(key);
            strBuild.AppendLine($"Open message block: {openMes};");
            strBuild.AppendLine($"Key({key.Length.ToString()}): {key};");
            strBuild.AppendLine($"RoundKeys: {subkeysArr[0]};");
            for (int i = 1; i < 40; i++)
            {
                   strBuild.AppendLine($"           {subkeysArr[i]};");
            }
            var XDataBlocks = StringMethods.StringToList(openMes, TwofishAlgo.XBlockLength);
            strBuild.AppendLine();
            strBuild.AppendLine($"**************************Input Whiting**************************");
            strBuild.AppendLine();

            for (int i = 0; i < 4; i++)
            {
                blocksAfterInputWhiting[i] = Convert.ToInt32(XDataBlocks[i], 2) ^ Convert.ToInt32(subkeysArr[i], 2);
                strBuild.AppendLine($"{XDataBlocks[i]} xor {subkeysArr[i]} = {StringMethods.MyConvertToString(blocksAfterInputWhiting[i], 2, 32)};");
            }
            strBuild.AppendLine();
            strBuild.AppendLine($"**************************The Main Cycle**************************");
            File.AppendAllText(fileWay, strBuild.ToString());

            for (int round = 0; round < 16; round++)
            {
                blocksAfterInputWhiting = OneRoundLog(blocksAfterInputWhiting, subkeysArr, round, fileWay);
            }
            strBuild.AppendLine();
            strBuild.AppendLine($"**************************Output Whiting**************************");
            strBuild.AppendLine();

            for (int i = 0; i < 4; i++)
            {
                blocksAfterOutputWhiting[i] = blocksAfterInputWhiting[i] ^ Convert.ToInt32(subkeysArr[i + 36], 2);
                closedMessage.Add(StringMethods.MyConvertToString(blocksAfterOutputWhiting[i], 2, 32));
                strBuild.AppendLine($"{StringMethods.MyConvertToString(blocksAfterInputWhiting[i], 2, 32)} xor {subkeysArr[i+36]} = {StringMethods.MyConvertToString(blocksAfterOutputWhiting[i], 2, 32)};");
            }
            var resultStringDuoSS = StringMethods.ListToString(closedMessage);
            strBuild.AppendLine($"Closed message block: {resultStringDuoSS};");
        }
        public static int[] OneRoundLog(int[] blocksArray, List<string> subKeys, int roundNum, string fileWay)
        {
            StringBuilder strBuild = new StringBuilder();
            string[] blocksName = {"A", "B", "C", "D"};
            int[] roundResult = new int[4];
            strBuild.AppendLine();
            strBuild.AppendLine($"-------------------------------Round{roundNum}------------------------------");
            strBuild.AppendLine($"Input blocks: [{blocksName[0]}]: {StringMethods.MyConvertToString(blocksArray[0], 2, 32)};");
            for (int i = 1; i < 4; i++)
            {
                strBuild.AppendLine($"              [{blocksName[i]}]: {StringMethods.MyConvertToString(blocksArray[i], 2, 32)};");
            }
            var stringB = StringMethods.MyConvertToString(blocksArray[1], 2, 32);
            for (int i = 0; i < 8; i++)
            {
                stringB = MyMath.LeftCycleShift(stringB);
            }
            strBuild.AppendLine($"Содержимое субблока B циклически сдвигается влево на 8 бит: [{blocksName[1]}]= {stringB};");
            int shiftedB = Convert.ToInt32(stringB, 2);
            var blockAafterG = TwofishAlgo.GFunction(StringMethods.MyConvertToString(blocksArray[0], 2, 32));
            strBuild.AppendLine($"Субблок A обрабатывается операцией g(): [{blocksName[0]}]= {blockAafterG};");
            var blockBafterG = TwofishAlgo.GFunction(StringMethods.MyConvertToString(shiftedB, 2, 32));
            strBuild.AppendLine($"Субблок B также обрабатывается операцией g(): [{blocksName[1]}]= {blockBafterG};");
            var blockAandB = (Convert.ToInt32(blockAafterG, 2) + Convert.ToInt32(blockBafterG, 2)) % Math.Pow(2, 32);
            strBuild.AppendLine($"Субблок B накладывается на A с помощью сложения по модулю 232,\n после чего аналогичным образом выполняется наложение субблока A на субблок B: [{blocksName[0]}]= [{blocksName[1]}]= {StringMethods.MyConvertToString((int)blockAandB,2,32)};");
            var APlusKey = blockAandB + Convert.ToInt32(subKeys.ElementAt(2 * roundNum + 8), 2);
            strBuild.AppendLine($"Фрагмент расширенного ключа K2r+8 (где r — номер текущего раунда, начиная с 0) складывается с субблоком A по модулю 232: [{blocksName[0]}] = {StringMethods.MyConvertToString((int)APlusKey, 2, 32)};");
            var BPlusKey = blockAandB + Convert.ToInt32(subKeys.ElementAt(2 * roundNum + 9), 2);
            strBuild.AppendLine($"Аналогично предыдущему шагу, K2r+9 накладывается на субблок B: [{blocksName[1]}] = {StringMethods.MyConvertToString((int)BPlusKey, 2, 32)};");
            blocksArray[2] = blocksArray[2] ^ (int)APlusKey;
            strBuild.AppendLine($"Субблок A накладывается на C операцией XOR: [{blocksName[2]}] = {StringMethods.MyConvertToString(blocksArray[2], 2, 32)};");
            blocksArray[3] = Convert.ToInt32(MyMath.LeftCycleShift(StringMethods.MyConvertToString(blocksArray[3], 2, 32)), 2);
            strBuild.AppendLine($"Содержимое субблока D циклически сдвигается влево на 1 бит: [{blocksName[3]}] = {StringMethods.MyConvertToString(blocksArray[3], 2, 32)};");
            blocksArray[3] = blocksArray[3] ^ (int)BPlusKey;
            strBuild.AppendLine($"Субблок B накладывается на D операцией XOR: [{blocksName[3]}] = {StringMethods.MyConvertToString(blocksArray[3], 2, 32)};");
            blocksArray[2] = Convert.ToInt32(MyMath.RightCycleShift(StringMethods.MyConvertToString(blocksArray[2], 2, 32)), 2);
            strBuild.AppendLine($"Содержимое субблока C циклически сдвигается вправо на 1 бит: [{blocksName[2]}] = {StringMethods.MyConvertToString(blocksArray[2], 2, 32)};");
            roundResult[0] = blocksArray[2];
            roundResult[1] = blocksArray[3];
            roundResult[2] = blocksArray[0];
            roundResult[3] = blocksArray[1];
            strBuild.AppendLine($"Output blocks: [{blocksName[0]}]: {StringMethods.MyConvertToString(roundResult[0], 2, 32)};");
            for (int i = 1; i < 4; i++)
            {
                strBuild.AppendLine($"              [{blocksName[i]}]: {StringMethods.MyConvertToString(roundResult[i], 2, 32)};");
            }

            File.AppendAllText(fileWay, strBuild.ToString());
            return roundResult;
        }

    }
}
