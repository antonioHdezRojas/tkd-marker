using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Whatever;

namespace Marcador
{
    
    public partial class frmCombate : Form
    {
        public string _tiempoRound;
        public string _noRounds;
        public int _tiempoD;        
        public frmCombate()
        {
            InitializeComponent();
        }        
        private void btnPuntoRojo_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            com.puntoHong();
            txtHong.Text = com.getPuntosHong;
            if (com.ptOro == true)
                ganador(2);
            if (pnlGanadorAzul.Visible == true || pnlGanadorRojo.Visible == true)
                if (int.Parse(com.getPuntosHong) > int.Parse(com.getPuntosChong))
                    ganador(2);            
        }                
        Combate com;
        GamepadState a = new GamepadState(SlimDX.XInput.UserIndex.One);
        GamepadState b = new GamepadState(SlimDX.XInput.UserIndex.Two);
        GamepadState c = new GamepadState(SlimDX.XInput.UserIndex.Three);     
        //puntos asignados por cada juez
        int ptRojo1, ptRojo2, ptRojo3;
        int ptAzul1, ptAzul2, ptAzul3;
        //pts a la cara asignados por cada juez
        int caraAzul1, caraAzul2, caraAzul3;
        int caraRojo1, caraRojo2, caraRojo3;
        Thread aux;
        //tiempo que dura vivo el hilo de cada punto
        int x = 1000;
        ThreadStart delA;
        ThreadStart delB;
        ThreadStart delC;
        ThreadStart delPts;
        Thread hiloJuez1;
        Thread hiloJuez2;
        Thread hiloJuez3;
        Thread hiloPuntos;
        private void Form1_Load(object sender, EventArgs e)
        {            
            frmCombate f = new frmCombate();
            f.Focus();         
            com = new Combate(10,12,int.Parse(_noRounds),60,int.Parse(_tiempoRound));
            Detener.Enabled = false;
            
            int min = int.Parse(_tiempoRound) / 60;
            int seg = int.Parse(_tiempoRound) - (min * 60);
            txtCronometro.Text = min.ToString() + ":" + seg.ToString();
            txtRound.Text = com.round.ToString();            
        }

        private void btnPuntoAzul_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            com.puntoChong();
            txtChong.Text = com.getPuntosChong;
            if (com.ptOro == true)
                ganador(1);
            if (pnlGanadorAzul.Visible == true || pnlGanadorRojo.Visible == true)
                if (int.Parse(com.getPuntosHong) < int.Parse(com.getPuntosChong))
                    ganador(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiongoRojo_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            com.kiongoHong();
            switch (com.getKiongosHong)
            {
                case 1:
                    txtHongKiongo1.Visible = true;
                    break;
                case 2:
                    txtHongKiongo1.BackColor = System.Drawing.Color.Red;
                    com.puntoChong();
                    if (com.ptOro == true)
                        ganador(1);
                    break;
                case 3:
                    txtHongKiongo2.Visible = true;
                    break;
                case 4:
                    txtHongKiongo2.BackColor = System.Drawing.Color.Red;
                    com.puntoChong();
                    break;
                case 5:
                    txtHongKiongo3.Visible = true;
                    break;
                case 6:
                    txtHongKiongo3.BackColor = System.Drawing.Color.Red;
                    com.puntoChong();
                    break;
                case 7:
                    txtHongKiongo4.Visible = true;
                    break;
                case 8:
                    txtHongKiongo4.BackColor = System.Drawing.Color.Red;
                    com.puntoChong();
                    break;
                case 9:
                    txtHongKiongo5.Visible = true;
                    break;
                case 10:
                    txtHongKiongo5.BackColor = System.Drawing.Color.Red;
                    com.puntoChong();
                    txtHong.Visible = false;
                    ganador(1);
                        break;
            }
            txtChong.Text = com.getPuntosChong;
        }

        private void btnKiongoAzul_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            com.kiongoChong();
            switch (com.getKiongosChong)
            {
                case 1:
                    txtChongKiongo1.Visible = true;
                    break;
                case 2:
                    txtChongKiongo1.BackColor = System.Drawing.Color.Red;
                    com.puntoHong();
                    if (com.ptOro == true)
                        ganador(2);
                    break;
                case 3:
                    txtChongKiongo2.Visible = true;
                    break;
                case 4:
                    txtChongKiongo2.BackColor = System.Drawing.Color.Red;
                    com.puntoHong();
                    break;
                case 5:
                    txtChongKiongo3.Visible = true;
                    break;
                case 6:
                    txtChongKiongo3.BackColor = System.Drawing.Color.Red;
                    com.puntoHong();
                    break;
                case 7:
                    txtChongKiongo4.Visible = true;
                    break;
                case 8:
                    txtChongKiongo4.BackColor = System.Drawing.Color.Red;
                    com.puntoHong();
                    break;
                case 9:
                    txtChongKiongo5.Visible = true;
                    break;
                case 10:
                    txtChongKiongo5.BackColor = System.Drawing.Color.Red;
                    com.puntoHong();
                    txtChong.Visible = false;
                    ganador(2);
                    break;
            }
            txtHong.Text = com.getPuntosHong;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {            
            tmrRound.Enabled = true;
            tmrRound.Start();
            Detener.Enabled = true;
            btnKiongoAzul.Enabled = false;
            btnKiongoRojo.Enabled = false;
            btnPuntoAzul.Enabled = false;
            btnPuntoRojo.Enabled = false;
            btnQuitaKiongoR.Enabled = false;
            btnQuitaPuntoR.Enabled = false;
            btnQuitaPuntoA.Enabled = false;
            btnQuitaKiongoA.Enabled = false;
            btnIniciar.Enabled = false;                            
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            tmrRound.Stop();           
            btnKiongoAzul.Enabled = true;
            btnKiongoRojo.Enabled = true;
            btnPuntoAzul.Enabled = true;
            btnPuntoRojo.Enabled = true;
            btnQuitaKiongoR.Enabled = true;
            btnQuitaPuntoR.Enabled = true;
            btnQuitaPuntoA.Enabled = true;
            btnQuitaKiongoA.Enabled = true;
            btnIniciar.Enabled = true;
            Detener.Enabled = false;
        }

        private void tmrRound_Tick(object sender, EventArgs e)
        {
            com.tiempo--;            
            txtCronometro.Text = tiempo();
            if (com.tiempo == 0)
            {
                tmrRound.Stop();                                
                if (com.round < int.Parse(_noRounds))
                {
                    com.tiempo = int.Parse(_tiempoRound);
                    com.round++;
                    Detener.PerformClick();
                    txtRound.Text = com.round.ToString();
                    frmDescanso d = new frmDescanso();
                    d._tiempo = _tiempoD;
                    d.Show();
                }
                else
                {
                    if (com.getPuntosChong == com.getPuntosHong)
                    {
                        com.tiempo = int.Parse(_tiempoRound);
                        com.ptOro = true;
                        com.round++;
                        com.borraPts();
                        txtChong.Text = com.getPuntosChong;
                        txtHong.Text = com.getPuntosHong;
                        txtRound.Text = "0";
                        txtCronometro.Text = tiempo();
                        frmDescanso d = new frmDescanso();
                        d._tiempo = _tiempoD;
                        d.Show();
                    }
                    else
                    {
                        int x;
                        if (int.Parse(com.getPuntosChong) > int.Parse(com.getPuntosHong))
                            x = 1;
                        else
                            x = 2;
                        ganador(x);
                    }
                }                          
            }
        }

        public void ganador(int x)
        {
            btnTiempoMedico.Enabled = false;
            if (btnIniciar.Enabled == false)
                Detener.PerformClick();
            txtCronometro.Visible = false;
            if (x == 1)
            {
                pnlGanadorAzul.Visible = true;
                pnlGanadorRojo.Visible = false;
                txtHong.Visible = false;
            }
            else
            {
                pnlGanadorAzul.Visible = false;
                pnlGanadorRojo.Visible = true;
                txtChong.Visible = false;
            }
            matarHilos();
        }

        private void frmCombate_Activated(object sender, EventArgs e)
        {
            txtCronometro.Text = tiempo();
            delA = new ThreadStart(juez1);
            delB = new ThreadStart(juez2);
            delC = new ThreadStart(juez3);
            delPts = new ThreadStart(puntos);
            hiloJuez1 = new Thread(delA);
            hiloJuez2 = new Thread(delB);
            hiloJuez3 = new Thread(delC);
            hiloPuntos = new Thread(delPts);
            hiloJuez1.Start();
            hiloJuez2.Start();
            hiloJuez3.Start();
            hiloPuntos.Start();
        }

        private void btnQuitaPuntoR_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            com.restaPuntoHong();
            txtHong.Text = com.getPuntosHong.ToString();
        }

        private void btnQuitaKiongoR_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            if (com.getKiongosHong>0)
                com.restaKiongoHong();
            switch (com.getKiongosHong)
            {
                case 9:
                    txtHongKiongo5.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoChong();
                    txtChong.Text = com.getPuntosChong.ToString();
                    break;
                case 8:
                    txtHongKiongo5.Visible = false;
                    break;
                case 7:
                    txtHongKiongo4.BackColor = System.Drawing.Color.Yellow;
                   com.restaPuntoChong();
                    txtChong.Text = com.getPuntosChong.ToString();
                    break;
                case 6:
                    txtHongKiongo4.Visible = false;
                    break;
                case 5:
                    txtHongKiongo3.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoChong();
                    txtChong.Text = com.getPuntosChong.ToString();
                    break;
                case 4:
                    txtHongKiongo3.Visible = false;
                    break;
                case 3:
                    txtHongKiongo2.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoChong();
                    txtChong.Text = com.getPuntosChong.ToString();
                    break;
                case 2:
                    txtHongKiongo2.Visible = false;
                    break;
                case 1:
                    txtHongKiongo1.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoChong();
                    txtChong.Text = com.getPuntosChong.ToString();
                    break;
                case 0:
                    txtHongKiongo1.Visible = false;
                    break;                                   
            }
        }

        private void btnRestaPuntoA_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            com.restaPuntoChong();
            txtChong.Text = com.getPuntosChong.ToString();
        }

        private void btnRestaKiongoA_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            if (com.getKiongosChong > 0)
                com.restaKiongoChong();
            switch (com.getKiongosChong)
            {
                case 9:
                    txtChongKiongo5.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoHong();
                    txtHong.Text = com.getPuntosHong.ToString();
                    break;
                case 8:
                    txtChongKiongo5.Visible = false;
                    break;
                case 7:
                    txtChongKiongo4.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoHong();
                    txtHong.Text = com.getPuntosHong.ToString();
                    break;
                case 6:
                    txtChongKiongo4.Visible = false;
                    break;
                case 5:
                    txtChongKiongo3.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoHong();
                    txtHong.Text = com.getPuntosHong.ToString();
                    break;
                case 4:
                    txtChongKiongo3.Visible = false;
                    break;
                case 3:
                    txtChongKiongo2.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoHong();
                    txtHong.Text = com.getPuntosHong.ToString();
                    break;
                case 2:
                    txtChongKiongo2.Visible = false;
                    break;
                case 1:
                    txtChongKiongo1.BackColor = System.Drawing.Color.Yellow;
                    com.restaPuntoHong();
                    txtHong.Text = com.getPuntosHong.ToString();
                    break;
                case 0:
                    txtChongKiongo1.Visible = false;
                    break;
            }
        }
        private void juez1()
        {
            //permite que un hilo haga modificaciones en un hilo distinto
            CheckForIllegalCrossThreadCalls = false;
            //inicia un ciclo infinito que se ejecutara mientras dure la pelea 
            do
            {
                a.Update();               
                if (a.LeftTrigger > 0.5f)
                {
                    while (a.LeftTrigger != 0)
                        a.Update();
                    ptRojo1++;
                    //inicia para indicar que el juez a marcado un punto a hong
                    aux = new Thread(new ThreadStart(limPtRojo1));
                    aux.Start();                    
                }
                else if (a.RightTrigger > 0.5f)
                {
                    while (a.RightTrigger != 0)
                        a.Update();
                    ptAzul1++;
                    //inicia para indicar que el juez a marcado un punto a chong
                    aux = new Thread(new ThreadStart(limPtAzul1));
                    aux.Start();
                }
                if (a.LeftShoulder == true)
                {
                    while (a.LeftShoulder == true)
                        a.Update();
                    caraRojo1++;
                    //inicia para indicar que el juez a marcado un golpe a la cara a hong
                    aux = new Thread(new ThreadStart(limCaraRojo1));
                    aux.Start();
                }
                else if (a.RightShoulder == true)
                {
                    while (a.RightShoulder == true)
                        a.Update();
                    caraAzul1++;
                    //inicia para indicar que el juez a marcado un golpe a la cara a chong
                    aux = new Thread(new ThreadStart(limCaraAzul1));
                    aux.Start();
                }                
            } while (true);
        }
        private void juez2()
        {
            CheckForIllegalCrossThreadCalls = false;
            do
            {
                b.Update();                
                if (b.LeftTrigger > 0.5f)
                {
                    while (b.LeftTrigger != 0)
                        b.Update();
                    ptRojo2++;
                    aux = new Thread(new ThreadStart(limPtRojo2));
                    aux.Start();
                }
                else if (b.RightTrigger > 0.5f)
                {
                    while (b.RightTrigger != 0)
                        b.Update();
                    ptAzul2++;
                    aux = new Thread(new ThreadStart(limPtAzul2));
                    aux.Start();
                }
                if (b.LeftShoulder == true)
                {
                    while (b.LeftShoulder == true)
                        b.Update();
                    caraRojo2++;
                    aux = new Thread(new ThreadStart(limCaraRojo2));
                    aux.Start();
                }
                else if (b.RightShoulder == true)
                {
                    while (b.RightShoulder == true)
                        b.Update();
                    caraAzul2++;
                    aux = new Thread(new ThreadStart(limCaraAzul2));
                aux.Start();
                }                
            } while (true);
        }
        private void juez3()
        {
            //permite que un hilo haga modificaciones en un hilo distinto
            CheckForIllegalCrossThreadCalls = false;
            //inicia un ciclo infinito que se ejecutara mientras dure la pelea 
            do
            {
                c.Update();               
                if (c.LeftTrigger > 0.5f)
                {
                    while (c.LeftTrigger != 0)
                        c.Update();
                    ptRojo3++;
                    //inicia para indicar que el juez a marcado un punto a hong
                    aux = new Thread(new ThreadStart(limPtRojo3));
                    aux.Start();
                }
                else if (c.RightTrigger > 0.5f)
                {
                    while (c.RightTrigger != 0)
                        c.Update();
                    ptAzul3++;
                    //inicia para indicar que el juez a marcado un punto a chong
                    aux = new Thread(new ThreadStart(limPtAzul3));
                    aux.Start();
                }
                if (c.LeftShoulder == true)
                {
                    while (c.LeftShoulder == true)
                        c.Update();
                    caraRojo3++;
                    //inicia para indicar que el juez a marcado un golpe a la cara a hong
                    aux = new Thread(new ThreadStart(limCaraRojo3));
                    aux.Start();
                }
                else if (c.RightShoulder == true)
                {
                    while (c.RightShoulder == true)
                        c.Update();
                    caraAzul3++;
                    //inicia para indicar que el juez a marcado un golpe a la cara a chong
                    aux = new Thread(new ThreadStart(limCaraAzul3));
                    aux.Start();
                }                
            } while (true);
        }
        private void puntos()
        {
            do
            {
                CheckForIllegalCrossThreadCalls = false;
                if ((ptAzul1 > 0 && ptAzul2 > 0) || (ptAzul1 > 0 && ptAzul3 > 0) || (ptAzul2 > 0 && ptAzul3 > 0))
                {
                    if(Detener.Enabled != false)
                        com.puntoChong();
                    if (ptAzul1 > 0)
                        ptAzul1--;
                    if (ptAzul2 > 0)
                        ptAzul2--;
                    if (ptAzul3 > 0)
                        ptAzul3--;
                }
                if ((ptRojo1 > 0 && ptRojo2 > 0) || (ptRojo1 > 0 && ptRojo3 > 0) || (ptRojo2 > 0 && ptRojo3 > 0))
                {
                    if (Detener.Enabled != false)
                        com.puntoHong();
                    if (ptRojo1 > 0)
                        ptRojo1--;
                    if (ptRojo2 > 0)
                        ptRojo2--;
                    if (ptRojo3 > 0)
                        ptRojo3--;
                }
                if ((caraAzul1 > 0 && caraAzul2 > 0) || (caraAzul1 > 0 && caraAzul3 > 0) || (caraAzul2 > 0 && caraAzul3 > 0))
                {
                    if (Detener.Enabled != false)
                    {
                        com.puntoChong();
                        com.puntoChong();
                        com.puntoChong();
                    }
                    if (caraAzul1 > 0)
                        caraAzul1--;
                    if (caraAzul2 > 0)
                        caraAzul2--;
                    if (caraAzul3 > 0)
                        caraAzul3--;
                }
                if ((caraRojo1 > 0 && caraRojo2 > 0) || (caraRojo1 > 0 && caraRojo3 > 0) || (caraRojo2 > 0 && caraRojo3 > 0))
                {
                    if (Detener.Enabled != false)
                    {
                        com.puntoHong();
                        com.puntoHong();
                        com.puntoHong();
                    }
                    if (caraRojo1 > 0)
                        caraRojo1--;
                    if (caraRojo2 > 0)
                        caraRojo2--;
                    if (caraRojo3 > 0)
                        caraRojo3--;
                }
                txtChong.Text = com.getPuntosChong;
                txtHong.Text = com.getPuntosHong;
                if (ptAzul1 > 0 || caraAzul1 > 0)
                    txtJuez1A.Visible = true;
                else
                    txtJuez1A.Visible = false;
                if (ptAzul2 > 0 || caraAzul2 > 0)
                    txtJuez2A.Visible = true;
                else
                    txtJuez2A.Visible = false;
                if (ptAzul3 > 0 || caraAzul3 > 0)
                    txtJuez3A.Visible = true;
                else
                    txtJuez3A.Visible = false;
                if (ptRojo1 > 0 || caraRojo1 > 0)
                    txtJuez1R.Visible = true;
                else
                    txtJuez1R.Visible = false;
                if (ptRojo2 > 0 || caraRojo2 > 0)
                    txtJuez2R.Visible = true;
                else
                    txtJuez2R.Visible = false;
                if (ptRojo3 > 0 || caraRojo3 > 0)
                    txtJuez3R.Visible = true;
                else
                    txtJuez3R.Visible = false;
                if (com.ptOro == true && (int.Parse(com.getPuntosChong) > 0 || int.Parse(com.getPuntosHong) > 0))
                    ptOro();
            } while (true);
        }
        //crea un hilo que muere al transcurrir el tiempo indicado en x si no se marca punto
        private void limPtAzul1()
        {
            Thread.Sleep(x);
            if (ptAzul1 > 0)
                ptAzul1--;
        }
        private void limPtAzul2()
        {
            Thread.Sleep(x);
            if (ptAzul2 > 0)
                ptAzul2--;
        }
        private void limPtAzul3()
        {
            Thread.Sleep(x);
            if (ptAzul3 > 0)
                ptAzul3--;
        }
        private void limPtRojo1()
        {
            Thread.Sleep(x);
            if (ptRojo1 > 0)
                ptRojo1--;
        }
        private void limPtRojo2()
        {
            Thread.Sleep(x);
            if (ptRojo2 > 0)
                ptRojo2--;
        }
        private void limPtRojo3()
        {
            Thread.Sleep(x);
            if (ptRojo3 > 0)
                ptRojo3--;
        }
        private void limCaraAzul1()
        {
            Thread.Sleep(x);
            if (caraAzul1 > 0)
                caraAzul1--;
        }
        private void limCaraAzul2()
        {
            Thread.Sleep(x);
            if (caraAzul2 > 0)
                caraAzul2--;
        }

        private void frmCombate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                btnTiempoMedico.PerformClick();                         
        }

        private string tiempo()
        {
            string aux ="";
            int min, seg;
            if ((com.tiempo / 5) >= 60)
            {
                min = 3;
                seg = com.tiempo - 300;
            }
            else if ((com.tiempo / 4) >= 60)
            {
                min = 4;
                seg = com.tiempo - 240;
            }
            else if ((com.tiempo / 3) >= 60)
            {
                min = 3;
                seg = com.tiempo - 180;
            }
            else if ((com.tiempo / 2) >= 60)
            {
                min = 2;
                seg = com.tiempo - 120;
            }
            else if (com.tiempo >= 60)
            {
                min = 1;
                seg = com.tiempo - 60;
            }
            else
            {
                min = 0;
                seg = com.tiempo;
            }
            aux = min.ToString() + ":";
            if (seg > 9)
                aux += seg;
            else
                aux += "0" + seg;
            return aux;
        }    
        private void btnTiempoMas_Click(object sender, EventArgs e)
        {
            com.tiempo++;
            txtCronometro.Text = tiempo();
        }
        private void btnTiempoMenos_Click(object sender, EventArgs e)
        {
            if(com.tiempo>2)
                com.tiempo--;
            txtCronometro.Text = tiempo();
        }

        private void limCaraAzul3()
        {
            Thread.Sleep(x);
            if (caraAzul3 > 0)
                caraAzul3--;
        }
        private void limCaraRojo1()
        {
            Thread.Sleep(x);
            if (caraRojo1 > 0)
                caraRojo1--;
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            btnTiempoMedico.Focus();
            frmDescanso d = new frmDescanso();
            d._tiempo = 60;
            d.Show();                  
        }

        private void limCaraRojo2()
        {
            Thread.Sleep(x);
            if (caraRojo2 > 0)
                caraRojo2--;
        }
        private void limCaraRojo3()
        {
            Thread.Sleep(x);
            if (caraRojo2 > 0)
                caraRojo2--;
        }

        private void btnTiempoMedico_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Enabled == false)            
                Detener.PerformClick();
            else if(Detener.Enabled == false)            
                btnIniciar.PerformClick();            
        }

        private void ptOro()
        {
            if (btnIniciar.Enabled == false)
                Detener.PerformClick();
            if (int.Parse(com.getPuntosChong) > 0)
                ganador(1);
            else if (int.Parse(com.getPuntosHong) > 0)
                ganador(2);                        
        }

        private void txtChong_TextChanged(object sender, EventArgs e)
        {

        }
        private void matarHilos()
        {
            hiloJuez1.Abort();
            hiloJuez2.Abort();
            hiloJuez3.Abort();
            hiloPuntos.Abort();
        }

        private void frmCombate_FormClosed(object sender, FormClosedEventArgs e)
        {
            matarHilos();
        }

        private void frmCombate_Deactivate(object sender, EventArgs e)
        {
            matarHilos();            
        }
    }
}