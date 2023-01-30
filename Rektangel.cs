using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprettendeBall
{
    internal class Rektangel
    {

        public string _Høyde = "###";

        private Ball[] rektangel;


        public Rektangel()
        {
            rektangel = new Ball[]
            {
                new Ball(15,3,1,1, _Høyde),
                new Ball(15,4,1,1, _Høyde),
                new Ball(15,5,1,1, _Høyde),
            };

           
            
        }

        //public void GettHight(int Høyde)
        //{
        //    Høyde = 3;

        //    for (int i = 0; i < Høyde; i++)
        //    {
        //        Console.Write(Høyde);
        //    }

        //}

        public void Show()
        {
            foreach (var ball in rektangel)
            {
                ball.Show();
            }
        }

        public void Move()
        {
            foreach (var ball in rektangel)
            {
                ball.Move();
            }
        }


     

    }

}
