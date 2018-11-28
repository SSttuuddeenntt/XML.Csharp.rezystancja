using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
//C:\Users\Radzio\Desktop\base.xml
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<WartoscChwilowa> Dane = new List<WartoscChwilowa>();
        int CurrentElement = 0;

        /*int[] Menu = { 480, 256 };
        int[] Reader = { 685, 400 };*/
        int[] Menu = { 362, 209 };
        int[] Reader = { 516, 326 };

        public Form1()
        {
            InitializeComponent();
            WindowSize(Menu);
        }


        private void b_Load_Click(object sender, EventArgs e)
        {
            if (!LoadXMLFile()) return;

            VisibleMenuElements(false);
            WindowSize(Reader);
            UpdateValues();
            VisibleReaderElements(true);
        }

        private void b_L_Click(object sender, EventArgs e)
        {
            CurrentElement--;
            VisibleReaderElements(true);
            UpdateValues();
        }

        private void b_R_Click(object sender, EventArgs e)
        {
            CurrentElement++;
            VisibleReaderElements(true);
            UpdateValues();
        }

        private void b_dir_Click(object sender, EventArgs e)
        {
            OpenFileDialog O_Path = new OpenFileDialog();
            O_Path.Filter = "All Files (*.xml)|*.xml";
            O_Path.FilterIndex = 1;
            O_Path.Multiselect = false;

            if (O_Path.ShowDialog() == DialogResult.OK)
            {
                tb_source.Text = O_Path.FileName;
            }
        }

        public String RemoveNonIntElements(string ToEdit)
        {
            String alfabet = "1234567890";
            String Output = ToEdit;
            for (int z = 0; z < Output.Length; z++)
            {
                bool JestTamNyga = false;

                for (int y = 0; y < alfabet.Length; y++)
                {
                    if (Output[z] == alfabet[y]) JestTamNyga = true;
                }

                if (!JestTamNyga)
                {
                    Output = Output.Remove(z, 1);
                    z--;
                }
            }
            return Output;
        }

        private void VisibleMenuElements(bool Show)
        {
            tb_source.Visible = Show;
            b_Load.Visible = Show;
            Menu_tytul.Visible = Show;
            b_dir.Visible = Show;
        }

        private void VisibleReaderElements(bool Show)
        {
            b_L.Visible = CurrentElement > 0 ? true : false;
            b_R.Visible = CurrentElement < (Dane.Count - 1) ? true : false;

            PB.Visible = true;
            R_Label.Visible = true;
            C_Label.Visible = true;
            L_Label.Visible = true;
            tytul.Visible = true;

            R_Label.BringToFront();
            C_Label.BringToFront();
            L_Label.BringToFront();
        }

        private void WindowSize(int[] tab)
        {
            this.Height = tab[1];
            this.Width = tab[0];
        }

        private void UpdateValues()
        {
            R_Label.Text = Dane[CurrentElement].tab[0].ToString() + " Ώ";
            C_Label.Text = Dane[CurrentElement].tab[1].ToString() + " L";
            L_Label.Text = Dane[CurrentElement].tab[2].ToString() + " H";
            tytul.Text = "Dane nr.: " + (CurrentElement + 1).ToString();
        }

        private bool LoadXMLFile()
        {
            String NazwaPliku = tb_source.Text;

            XmlDocument Doc = new XmlDocument();

            try
            {
                Doc.Load(NazwaPliku);
                //MessageBox.Show("Dokument załadowany");

                String[] ElementyDoZczytania = { "rezystancja", "pojemnosc", "indukcyjnosc" };
                int count = Doc.GetElementsByTagName("element").Count;

                for (int i = 0; i < count; i++)
                {
                    WartoscChwilowa buffer = new WartoscChwilowa();

                    for (int j = 0; j < 3; j++)
                    {
                        String value = Doc.GetElementsByTagName(ElementyDoZczytania[j]).Item(i).InnerText;

                        value = RemoveNonIntElements(value);
                        buffer.tab[j] = Int32.Parse(value);

                        //MessageBox.Show("Element nr: "+(i + 1).ToString() + " | " + ElementyDoZczytania[j] + ": " + buffer.tab[j]);
                    }
                    Dane.Add(buffer);
                }
            }
            catch (XmlException error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
            catch (DirectoryNotFoundException error)
            {
                MessageBox.Show(error.Message);
                return false;
            }

            return true;
        }
    }

    public class WartoscChwilowa
    {
        public int[] tab = { 0, 0, 0 };
    }
}
