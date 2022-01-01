using System ;
namespace _sequences 
{
    class Program
    {
        static void Main (string [] args)
        {
            //The definition of the sequences
            string[] colors = new string[5] ;

            string[] animals = {"kedi","kopek","kus","maymun","bocek"} ;
            int[] _seq ;
            _seq = new int[5]  ;
            // value allocation to a sequence
            colors[0] = "Blue" ;
            _seq[3] = 10;
            Console.WriteLine(animals[1]);
            Console.WriteLine(colors[0]);
            Console.WriteLine(_seq[3]);
            // Dongulerle dizi kullanimi
            
            Console.WriteLine("Lutfen dizinin eleman sayisini giriniz:") ;
            int _length = int.Parse(Console.ReadLine()) ;
            int[] numberSequence= new int[_length] ;
            for (int i = 0; i < _length ; i++)
                {
                    Console.Write("Lutfen {0}. sayasini giriniz:", i+1) ;
                    numberSequence[i]= int.Parse(Console.ReadLine());

                }
            int sum = 0 ;
            foreach (var number in numberSequence) 
                sum+= number ;
            Console.WriteLine("ortalama:" + sum/_length)    ;



        }
          }
}