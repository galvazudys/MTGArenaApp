using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace MTGArenaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("cards.json"))
            {
                string json = file.ReadToEnd();
                var cardsCollection = JsonConvert.DeserializeObject<Cards.Rootobject>(json);

                listBox1.DataSource = cardsCollection.Cards;
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "grpId";

                textBox1.Text = listBox1.SelectedIndex.ToString();


            }



        }

        private Cards.Rootobject GetCardCollection()
        {
            using (StreamReader file = new StreamReader("cards.json"))
            {
                string json = file.ReadToEnd();
                return JsonConvert.DeserializeObject<Cards.Rootobject>(json);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cards = GetCardCollection();
            pictureBox1.ImageLocation = "https://img.scryfall.com/cards" + cards.Cards[listBox1.SelectedIndex].images.normal;
            textBox1.Text = cards.Cards[listBox1.SelectedIndex].artist;
            label1.Height = 40;
            label1.Text = cards.Cards[listBox1.SelectedIndex].name;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
