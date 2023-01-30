using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprettendeBall
{

 
    internal class Ball
    {

        private int _col;
        private int _row;
        private int _speedCol;
        private int _speedRow;
        private string _Høyde;









        public Ball(int col, int row, int speedCol, int speedRow, string høyde)
        {
            _col = col;
            _row = row;
            _speedCol = speedCol;
            _speedRow = speedRow;
            _Høyde = høyde;

        }

     
        

       

        public void Show()
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _row;
            LageFirkant();
        }

        public void LageFirkant()
        {


            Console.Write(_Høyde);
            
              
                


            
          



        }



        public void Move()
        {
            _col += _speedCol; // bestemmer plasserig fra venstre side
            _row += _speedRow; // bestemmer plassering fra topp

            if (_col <= 0 || _col >= Console.WindowWidth - 1) _speedCol = -_speedCol; // 
           if (_row <= 0 || _row >= Console.WindowHeight - 1) _speedRow = -_speedRow;
        }
    }
}
// første loop : 5, 4, 1, 1
