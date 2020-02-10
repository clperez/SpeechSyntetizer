using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Speech
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            var voices = synth.GetInstalledVoices(CultureInfo.GetCultureInfo("ES-es"));

            synth.SelectVoice(synth.GetInstalledVoices().Single(x => x.VoiceInfo.Name.Contains("Helena")).VoiceInfo.Name); //Raul/Laura/Helena

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            //synth.Speak("Hola Anabel");
            //Console.ReadKey();
            //synth.Speak("¿Como estas?");
            //Console.ReadKey();
            //synth.Speak("¿Como se llama tu perrito?");
            //Console.ReadKey();
            //synth.Speak("¿Como se llama tu cole?");
            //Console.ReadKey();

            synth.Speak("Hola Chombita.");
            Console.ReadKey();
            synth.Speak("Tienes que irte a la cama ya");
            Console.ReadKey();
            synth.Speak("¿Te veo mañana?");
            Console.ReadKey();
            synth.Speak("Ve con mama, y hazle caso en todo.");
            Console.ReadKey();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
