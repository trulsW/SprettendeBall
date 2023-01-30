namespace SprettendeBall
{
    internal class Program
    {
        static void Main(string[] args)
        {


            

           
            var ball = new Rektangel();
            
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();
                ball.Show();
                

                ball.Move();
                
                
                Thread.Sleep(50);
            }



        }
    }
}