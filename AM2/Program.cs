using System.IO;
using NAudio;
using NAudio.Wave;

namespace AM2;
class Program
{
    static void Main(string[] args)
    {
        DetermineFrequency determine = new DetermineFrequency();

        string filePath = "wav_org/guitar.wav";

        using(var audio = new AudioFileReader(filePath))
        using(var outputDevice = new WaveOutEvent())
            {
            outputDevice.Init(audio);
            outputDevice.Play();

            while(outputDevice.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(1000);
            }

            }
        


        Console.ReadKey();
    }
}

