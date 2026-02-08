/*
Abel Doyle
RCET 2265
Spring Semester 2026
BetterCalculator
https://github.com/abeldoyl/FortuneCookie.git
*/


namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fortune = new string[7];
            Random random = new Random();

            fortune[0] = "Don't worry your code's not bugged it's just being difficult";
            fortune[1] = "Never forget your grounds";
            fortune[2] = "A lab checkoff a day makes Tim okay";
            fortune[3] = "If component is found broken it was most likely Ashton";
            fortune[4] = "Diode chain will be end of humanity and Cam is okay with that";
            fortune[5] = "No matter what anyone says Luke^2 is the MVP of the program";
            fortune[6] = "You can be mean as long as it's okay and funny to others";

            //read fortune
            for (int i = 0; i < 1; i++)
            {
                int n = random.Next(0, 7);
                Console.WriteLine($"{fortune[n]}");
            }

            //pause
            Console.Read();
        }
    }
}
