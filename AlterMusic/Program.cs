using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;
using System.Media;
using System.Diagnostics;

namespace AlterMusic;
class Program
{
    static void Main(string[] args)
    {

        // Open the wave file for reading
        WaveFileReader waveFileReader = new WaveFileReader(@"../wave_sounds/guitar.wav");

            // Create a WaveChannel32 from the WaveFileReader
            var waveChannel32 = new WaveChannel32(waveFileReader);

            // Amplify the audio waveform by a factor of 2
            MultiplexingSampleProvider sampleProvider = new MultiplexingSampleProvider(new ISampleProvider[] {(ISampleProvider)waveChannel32, (ISampleProvider)waveChannel32 }, 2);
            var amplitudeFactor = 0.0f;
            var volumeProvider = new VolumeSampleProvider(sampleProvider) { Volume = amplitudeFactor };

        // Write the output to a new wave file
        WaveFileWriter waveFileWriter = new WaveFileWriter("altered/output.wav", volumeProvider.WaveFormat);
                float[] buffer = new float[waveFileReader.WaveFormat.AverageBytesPerSecond * 4];
                 byte[] bufferWrite = new byte[waveFileReader.WaveFormat.AverageBytesPerSecond * 4];
                int read = 0;
                while ((read = volumeProvider.Read(buffer, 0, buffer.Length)) > 0)
                {
                    waveFileWriter.Write(bufferWrite, 0, read);
                }
        }




    }


