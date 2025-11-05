using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrediHanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int nDischi = 0;
        int nPassaggi = 0;
        List<Panel> dischiList = new List<Panel>();
        Random rnd = new Random();
        int baseW = 100; 
        int stepW = 15;

        List<Panel> sorg = new List<Panel>();
        List<Panel> dest = new List<Panel>();
        List<Panel> ausi = new List<Panel>();


        private void InizioTurno()
        {
            // Pulisco eventuali dischi vecchi
            foreach (Panel p in dischiList)
                this.Controls.Remove(p);

            dischiList.Clear();
            sorg.Clear();
            dest.Clear();
            ausi.Clear();


            for (int i = 0; i < nDischi; i++)
            {
                Panel panel = new Panel();

               
                panel.BackColor = Colore(i);

                
                panel.Height = 15;
                panel.Width = baseW - i * stepW;

                sorg.Add(panel);
                this.Controls.Add(panel);
                dischiList.Add(panel);

                
                PiazzaDiscoSuPiolo(panel, pnl_ya, i);
            }
        }

        private Color Colore(int c)
        {
            switch (c)
            {
                case 0: 
                    return Color.Red;
                case 1: 
                    return Color.Green;
                case 2: 
                    return Color.Blue;
                case 3:
                    return Color.Yellow;
                case 4: 
                    return Color.Orange;
                case 5: 
                    return Color.Purple;
                case 6: 
                    return Color.Magenta;
                default: 
                    return Color.Black;
            }
        }

        void PiazzaDiscoSuPiolo(Panel disco, Panel piolo, int posizione)
        {
            
            int baseY = piolo.Bottom;


            int y = baseY - ((posizione + 1) * disco.Height) - 6;


            int x = piolo.Left + (piolo.Width - disco.Width) / 2;

            disco.Location = new Point(x, y);//li posiziona uno per uno
            disco.BringToFront(); //per portare in primo piano
        }

        private void btn_invio_Click_1(object sender, EventArgs e)
        {
            //per posizionare tutti dischi
            btn_invio.Enabled = false;
            nDischi = (int)num_dischi.Value;
            InizioTurno();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            if (dischiList.Count > 0 && nDischi != 0)
            {
                nPassaggi = 0;
                btn_start.Enabled = false;
                lst_passaggi.Items.Clear();
                await Hanoi(nDischi, sorg, dest, ausi, pnl_ya, pnl_yc, pnl_yb);
                MessageBox.Show($"Fine esecuzione con {nPassaggi} passaggi");

                //altrimenti problemi con asincronismo
                btn_start.Enabled = true;
                btn_invio.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fare submit per creare elementi");
            }
        }

        private async Task Hanoi(int n, List<Panel> sorg, List<Panel> dest, List<Panel> aux, Panel pnlSorg, Panel pnlDest, Panel pnlAux)
        {
            if (n == 1)
            {
                //spostameno
                await SpostamentoDisco(sorg, dest, pnlSorg, pnlDest);
                return;
            }

            await Hanoi(n - 1, sorg, aux, dest, pnlSorg, pnlAux, pnlDest);
            await SpostamentoDisco(sorg, dest, pnlSorg, pnlDest);
            await Hanoi(n - 1, aux, dest, sorg, pnlAux, pnlDest, pnlSorg);
        }

        private async Task SpostamentoDisco(List<Panel> from, List<Panel> to, Panel pnlFrom, Panel pnlTo)
        {
            if (from.Count == 0) 
            { 
                return;
            }

            //da per esempio A a B sposta il panel della lista from su to per gestire movimento
            Panel disco = from[from.Count - 1];
            from.RemoveAt(from.Count - 1);
            to.Add(disco);


            
            nPassaggi++;
            //aggiorno
            lst_passaggi.Items.Add($"{GetNome(pnlFrom.Name)} -> {GetNome(pnlTo.Name)}");
            lst_passaggi.SelectedIndex = lst_passaggi.Items.Count - 1;

            //nnnew posizion
            int posizione = to.Count - 1;
            PiazzaDiscoSuPiolo(disco, pnlTo, posizione);

            //pausa 300ms altrimenti non si vede bene movimento
            await Task.Delay(300);
        }

        //ottiene nome (a b c) da nome del panel
        private string GetNome(string nome)
        {
            string RealGST;
            switch (nome)
            {
                case "pnl_ya":
                    RealGST = "A";
                    break;
                case "pnl_yb":
                    RealGST = "B";
                    break;
                case "pnl_yc":
                    RealGST = "C";
                    break;
                default:
                    throw new ArgumentException("Nome non valido");
            }
            return RealGST;
        }
    }
}
