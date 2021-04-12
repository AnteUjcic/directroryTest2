using System;
using System.IO;


namespace DirectoryTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = "$My Documents/ testNiOP /",ime,prezime,godrod,email;

            Console.WriteLine("ime: ");
            ime=Console.ReadLine();
            Console.WriteLine("prezime: ");
            prezime = Console.ReadLine();
            Console.WriteLine("god_rodenja: ");
            godrod = Console.ReadLine();
            Console.WriteLine("E-mail: ");
            email = Console.ReadLine();

            addRecord(ime, prezime, godrod, email,putanja);
           

        
            Console.ReadKey();

        }
        public static void addRecord(string ime, string prezime, string godrod, string email,string putanja)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(putanja))
                {

                   object p = File.WriteLine(ime + "," + prezime + "," + godrod + "," + email);
                }
                
            
            }
            catch (Exception ex)
            {
                throw new ApplicationException("OOOOPS ",ex );
            }
        }
    }
}
 