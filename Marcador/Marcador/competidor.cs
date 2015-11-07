using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcador
{
    class competidor
    {
        private int puntos = 0;
        private int kiongos = 0;
        public void marcaPunto()
        {
            puntos++;            
        }
        public void marcaKiongo()
        {
            kiongos++;
        }
        public int getPuntos { get { return puntos; } }
        public int getKiongos { get { return kiongos; } }
        public void quitaPunto()
        {
            puntos--;
        }
        public void quitaKiongo()
        {
            kiongos--;
        }
        public void borraPts()
        {
            puntos = 0;
        }
    }
}
