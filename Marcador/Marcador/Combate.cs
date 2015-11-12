using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Marcador
{
    class Combate
    {
        public bool ptOro { get; set; }
        private int numKiongos;
        private int difSuperioridad;
        private int numRounds;
        private int _round;        
        private int tiempoRound; //  segundos
        private int _tiempo;
        private competidor chong = new competidor();
        private competidor hong = new competidor();

        public Combate(int numKiongos, int difSuperioridad, int numRounds, int descanso, int tiempoRound)
        {
            this.numKiongos = numKiongos;
            this.difSuperioridad = difSuperioridad;
            this.numRounds = numRounds;            
            this.tiempoRound = tiempoRound;
            this._round = 1;
            _tiempo = tiempoRound;
        }

        public string getPuntosChong { get { return Convert.ToString(chong.getPuntos); } }
        public string getPuntosHong { get { return Convert.ToString(hong.getPuntos); } }
        public int getKiongosChong { get { return chong.getKiongos; } }
        public int getKiongosHong { get { return hong.getKiongos; } }
        public int getNumRound { get { return numRounds; } }
        public int tiempo { get { return _tiempo; } set { _tiempo = value; } }
        public int round { get { return _round; } set { _round = value; } }

        public void puntoChong() { chong.marcaPunto(); }
        public void restaPuntoChong() { chong.quitaPunto(); }
        public void puntoHong() { hong.marcaPunto(); }
        public void restaPuntoHong() { hong.quitaPunto(); }
        public void kiongoChong(){ chong.marcaKiongo(); }
        public void restaKiongoChong() { chong.quitaKiongo(); }        
        public void kiongoHong() { hong.marcaKiongo(); }
        public void restaKiongoHong() { hong.quitaKiongo(); }
        public int ganadorDIferencia()
        {            
            if ((chong.getPuntos - hong.getPuntos) >= difSuperioridad)
                return 1;
            else if ((hong.getPuntos - chong.getPuntos) >= difSuperioridad)
                return 2;           
            return 0;
        }
        public void borraPts()
        {
            chong.borraPts();
            hong.borraPts();
        }


    }
}
