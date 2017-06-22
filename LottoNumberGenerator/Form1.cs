using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Windows.Forms;

namespace LottoNumberGenerator
{
    public partial class Form1 : Form
    {
        const string csvFileName = "results.csv";
        DateTime timestamp;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayNoDrawEnteredMessage()
        {
            MessageBox.Show("Please enter a number of draws.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            string buffer = String.Empty;

            if (nudNumberOfDraws.Text != String.Empty)
            {
                int a = Convert.ToInt32(nudNumberOfDraws.Text);
                if (a != 0)
                {
                    txtPreview.Clear();
                    for (int i = 0; i < a; i++)
                    {
                        if (buffer != String.Empty)
                        {
                            buffer += Environment.NewLine;
                        }

                        List<int> numbers = new List<int>();
                        do
                        {
                            int number;
                            do
                            {
                                number = rndm.Next(1, 50); // od 1 do 49
                            }
                            while (numbers.IndexOf(number) != -1);
                            numbers.Add(number);
                            buffer += number.ToString() + " ";
                        }
                        while (numbers.Count < 6);
                        buffer = buffer.Substring(0, buffer.Length - 1);
                    }
                    timestamp = DateTime.Now;
                    txtPreview.Text = buffer;
                    btnExportToCsv.Enabled = true;
                }
                else
                {
                    DisplayNoDrawEnteredMessage();
                }
            }
            else
            {
                DisplayNoDrawEnteredMessage();
            }
        }

        private void btnExportToCsv_Click(object sender, EventArgs e)
        {
            try
            {
                using (var textWriter = File.AppendText(csvFileName))
                using (var csv = new CsvWriter(textWriter))
                {
                    csv.Configuration.Encoding = Encoding.UTF8;
                    csv.Configuration.Delimiter = ";";

                    // wypisz kolumny (w przypadku nowego/pustego pliku)
                    if (new FileInfo(csvFileName).Length == 0)
                    {
                        csv.WriteField("Timestamp");
                        csv.WriteField("NumberOne");
                        csv.WriteField("NumberTwo");
                        csv.WriteField("NumberThree");
                        csv.WriteField("NumberFour");
                        csv.WriteField("NumberFive");
                        csv.WriteField("NumberSix");
                        csv.NextRecord();
                    }

                    string[] lines = txtPreview.Text.Split(new string[] { Environment.NewLine },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (var line in lines)
                    {
                        string[] numbers = line.Split(new char[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries);

                        // wypisz wartości wierszy
                        csv.WriteField(timestamp.ToString("o")); // zwraca i wypisuje uniwersalny format daty i godziny
                        foreach (var number in numbers)
                        {
                            csv.WriteField(number);
                        }
                        csv.NextRecord();
                    }
                }

                btnExportToCsv.Enabled = false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Access denied to \"{csvFileName}\". Please check if the file is reachable and can be modified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}