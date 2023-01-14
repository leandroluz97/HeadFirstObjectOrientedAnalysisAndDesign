using System.Timers;

namespace ToddAndGinaApp
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Fido barks to let be out");
            Bark bark = new Bark("woof");
            Bark unkonwBark = new Bark("coof");
            DogDoor dogDoor = new DogDoor();
            dogDoor.AddAllowedBark(bark);
            Remote remote = new Remote(dogDoor);
            BarkRecognizer barkRecognizer = new BarkRecognizer(dogDoor);
            //Console.WriteLine("Gina hear Fido's barking");
            //remote.PressButton();
            Console.WriteLine("The bark recognizer recognize bark");
            barkRecognizer.Recognizer(unkonwBark);
            Console.ReadLine();
        }      
    }
}
