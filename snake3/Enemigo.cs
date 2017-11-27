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
        public Enemigo()
        {
            this.x = generar(102);
            this.y = generar(50);
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), this.x, this.y, 30, 50);
        }
        public void colocar()
        {
            this.x = generar(102);
            this.y = generar(50);
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
    }
}
