using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
      

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new Model1();
            //List<Studio> studios = new List<Studio>();
            //studios.Add(new Studio() { StudiosName = "343 Studios" });
            //studios.Add(new Studio() { StudiosName = "4A Games" });
            //studios.Add(new Studio() { StudiosName = "505 Games" });
            //studios.Add(new Studio() { StudiosName = "Avalanche Software" });
            //studios.Add(new Studio() { StudiosName = "Bungie Studios" });
            //studios.Add(new Studio() { StudiosName = "Deck13" });
            //studios.Add(new Studio() { StudiosName = "Penguin Software" });
            //studios.Add(new Studio() { StudiosName = "Petroglyph" });
            //studios.Add(new Studio() { StudiosName = "PlayFirst" });
            //studios.Add(new Studio() { StudiosName = "Retro Studios" });
            //context.Studios.AddRange(studios);



            //List<Style> styles = new List<Style>();
            //styles.Add(new Style() { StylesName = "Action" });
            //styles.Add(new Style() { StylesName = "Shooter" });
            //styles.Add(new Style() { StylesName = "Fighting" });
            //styles.Add(new Style() { StylesName = "Stealth" });
            //styles.Add(new Style() { StylesName = "Survival" });
            //context.Styles.AddRange(styles);




            context.SaveChanges();


            List<Game> games = new List<Game>();
            games.Add(new Game()
            {
                GameName = "Tetris",
                Style = Convert.ToString(context.Styles.FirstOrDefault(x => x.StylesName == "Stealth")),
                Studio = Convert.ToString(context.Studios.FirstOrDefault(x => x.StudiosName == "4A Games"))
            });

            context.SaveChanges();

            var listgame = context.Games;
            foreach (Game game in listgame)
            {
                listBox1.Items.Add(game.GameName + " Mode: " + game.Mode + " Studio: " + game.Studio + " Relise: "+ game.Relise+ " Paid: "+ game.Paid);
            }
           


        }
    }
}
