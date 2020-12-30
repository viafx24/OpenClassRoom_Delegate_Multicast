using System;

namespace OpenClassRoom_Delegate_Multicast
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 4, 1, 6, 10, 8, 5 };
            new TrieurDeTableau().DemoTri(tableau);
        }
    }

    public class TrieurDeTableau
    {
        private delegate void DelegateTri(int[] tableau);

        private void TriAscendant(int[] tableau)
        {
            Array.Sort(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private void TriDescendant(int[] tableau)
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
        }

        public void DemoTri(int[] tableau)
        {
            DelegateTri tri = TriAscendant;
            tri += TriDescendant;
            tri(tableau);
        }
    }
}
