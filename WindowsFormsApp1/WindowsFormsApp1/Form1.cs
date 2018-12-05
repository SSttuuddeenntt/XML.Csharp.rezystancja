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
        List<String> BazaPelnychSciezek = new List<String>();
        int CurrentElement = 0;
        int State = 0;

        int[] Menu = { 500, 209 };
        int[] Reader = { 516, 326 };

        const int Rezystor = 1;
        const int Cewka = 2;
        const int Kondensator = 3;

        public Form1()
        {
            InitializeComponent();
            WindowSize(Menu);
            LoadOldFiles();
        }

        private void LoadOldFiles()
        {
            BazaPelnychSciezek.Clear();
            LB_Dane.Items.Clear();

            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NudneDane"));
            string[] Baza = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NudneDane"));
            foreach (string plik in Baza)
            {
                string buffer = Path.GetFileName(plik);
                buffer = buffer.Remove(buffer.Count() - 4, 4);
                buffer = buffer.Replace('_', ':');
                LB_Dane.Items.Add(buffer);
                BazaPelnychSciezek.Add(plik);
            }
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Dane.Clear();
            LoadOldFiles();
            VisibleReaderElements(false);
            WindowSize(Menu);
            VisibleMenuElements(true);
            CurrentElement = 0;
            State = 0;
        }

        private void b_LoadR_Click(object sender, EventArgs e)
        {
            b_Load_Click(Rezystor);
        }
        private void b_LoadC_Click(object sender, EventArgs e)
        {
            b_Load_Click(Cewka);
        }
        private void b_LoadK_Click(object sender, EventArgs e)
        {
            b_Load_Click(Kondensator);
        }


        private void b_Load_Click(int typ)
        {
            State = typ;

            String path = "";
            if(LB_Dane.SelectedIndex == -1)
            {
                if(!File.Exists(tb_source.Text))
                {
                    MessageBox.Show("Plik nie znaleziony");
                    return;
                }

                string FileName = DateTime.Now.ToString("dd.MM.yyyy HH_mm_ss") + ".xml";

                File.Copy(tb_source.Text, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NudneDane\\"+ FileName));
            }
            else    path = BazaPelnychSciezek[LB_Dane.SelectedIndex];

            if (!LoadXMLFile(path)) return;

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
            b_LoadK.Visible = Show;
            b_LoadC.Visible = Show;
            b_LoadR.Visible = Show;
            Menu_tytul.Visible = Show;
            b_dir.Visible = Show;
            LB_Dane.Visible = Show;
        }

        private void VisibleReaderElements(bool Show)
        {
            b_L.Visible = CurrentElement > 0 ? Show : false;
            b_R.Visible = CurrentElement < (Dane.Count - 1) ? Show : false;
            b_back.Visible = Show;

            switch (State)
            {
                case Kondensator:
                    {
                        C_RC_Label.Visible = Show;
                        C_RS_Label.Visible = Show;
                        C_C_Label.Visible = Show;
                        C_L_Label.Visible = Show;
                        PB.Image = WindowsFormsApp1.Properties.Resources.Schemat_kondensatora;
                        break;
                    }
                case Cewka:
                    {
                        L_R_Label.Visible = Show;
                        L_C_Label.Visible = Show;
                        L_L_Label.Visible = Show;
                        PB.Image = WindowsFormsApp1.Properties.Resources.Schemat_cewki;
                        break;
                    }
                case Rezystor:
                    {
                        R_R_Label.Visible = Show;
                        R_C_Label.Visible = Show;
                        R_L_Label.Visible = Show;
                        PB.Image = WindowsFormsApp1.Properties.Resources.Schemat_rezystora;
                        break;
                    }
            }

            PB.Visible = Show;
            tytul.Visible = Show;

            R_R_Label.BringToFront();
            R_C_Label.BringToFront();
            R_L_Label.BringToFront();
        }

        private void WindowSize(int[] tab)
        {
            this.Height = tab[1];
            this.Width = tab[0];
        }

        private void UpdateValues()
        {
            switch (State)
            {
                case Kondensator:
                    {
                        C_RC_Label.Text = Dane[CurrentElement].tab[3].ToString() + " Ώ";
                        C_RS_Label.Text = Dane[CurrentElement].tab[2].ToString() + " Ώ";
                        C_C_Label.Text = Dane[CurrentElement].tab[0].ToString() + " F";
                        C_L_Label.Text = Dane[CurrentElement].tab[1].ToString() + " H";
                        tytul.Text = "Kondensator | Dane nr.: " + (CurrentElement + 1).ToString();
                        PB.Image = WindowsFormsApp1.Properties.Resources.Schemat_kondensatora;
                        break;
                    }
                case Cewka:
                    {
                        L_R_Label.Text = Dane[CurrentElement].tab[2].ToString() + " Ώ";
                        L_C_Label.Text = Dane[CurrentElement].tab[0].ToString() + " F";
                        L_L_Label.Text = Dane[CurrentElement].tab[1].ToString() + " H";
                        tytul.Text = "Cewka | Dane nr.: " + (CurrentElement + 1).ToString();
                        PB.Image = WindowsFormsApp1.Properties.Resources.Schemat_cewki;
                        break;
                    }
                case Rezystor:
                    {
                        R_R_Label.Text = Dane[CurrentElement].tab[0].ToString() + " Ώ";
                        R_C_Label.Text = Dane[CurrentElement].tab[1].ToString() + " F";
                        R_L_Label.Text = Dane[CurrentElement].tab[2].ToString() + " H";
                        PB.Image = WindowsFormsApp1.Properties.Resources.Schemat_rezystora;
                        tytul.Text = "Rezystor | Dane nr.: " + (CurrentElement + 1).ToString();
                        break;
                    }
            }
        }

        private bool LoadXMLFile(string path)
        {
            String NazwaPliku = tb_source.Text;
            if (path.Count() > 0) NazwaPliku = path;

          XmlDocument Doc = new XmlDocument();

            try
            {
                Doc.Load(NazwaPliku);
                String[] ElementyRodzice = { "rezystor", "cewka", "kondensator" };
                XmlNode MainTree = Doc.GetElementsByTagName(ElementyRodzice[State - 1]).Item(0);

                String[] ElementyDoZczytania = { "pojemnosc", "indukcyjnosc", "rezystancja", "rezystancjaS", "rezystancjaC" };
                int count = Doc.GetElementsByTagName("element").Count;

                //MessageBox.Show("Znaleziono: " + Doc.GetElementsByTagName(ElementyRodzice[State - 1]).Count.ToString());
                //MessageBox.Show("Ilosc pod elementow:  " + MainTree.ChildNodes.Count.ToString());

                for (int i = 0; i < MainTree.ChildNodes.Count; i++)
                {
                    WartoscChwilowa buffer = new WartoscChwilowa();

                    //MessageBox.Show("Ilosc pod pod elementow:  " + MainTree.ChildNodes[i].ChildNodes.Count.ToString());
                    for (int j = 0; j < MainTree.ChildNodes[i].ChildNodes.Count; j++)
                    {

                        //if (Doc.GetElementsByTagName(ElementyDoZczytania[j]).Count == 0) continue;

                        String value = MainTree.ChildNodes[i].ChildNodes[j].InnerText;

                        value = RemoveNonIntElements(value);
                        int buffer2 = Int32.Parse(value);
                        buffer.tab.Add(buffer2);

                        //MessageBox.Show("Element nr: "+(i + 1).ToString() + " | " + j.ToString() + ": " + buffer.tab[j]);
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
        public List<int> tab = new List<int>();
    }
}
