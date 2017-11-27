using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake3
{
    class Enemigo : objeto
    {
        Enemigo siguiente;
        public Enemigo()
        {
            this.x = generar(78);
            this.y = generar(39);
            siguiente = null;
        }
        public void dibujar(Graphics g)
        {
            if (siguiente != null)
            {
                siguiente.dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, 10, 30);
        }
        public void colocar()
        {
            this.x = generar(78);
            this.y = generar(39);
        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
        public int verXobs()
        {
            return this.x;
        }
        public int verYobs()
        {
            return this.y;
        }

        public void meter()
        {
            if (siguiente == null)
            {
                siguiente = new Enemigo();
            }
            else
            {
                siguiente.meter();
            }
        }

        public Enemigo verSiguiente()
        {
            return siguiente;
        }
    }
}
