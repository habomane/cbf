using System;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace AM2;

public class DetermineFrequency
{


  /***  public void ReduceAudio(string input)
    {
        IWaveProvider reader = new WaveFileReader(@input);

        if(reader.WaveFormat.Encoding != WaveFormatEncoding.Pcm ||
            (reader.WaveFormat.BitsPerSample != 16 && reader.WaveFormat.BitsPerSample != 32))
        {
            reader = new WaveFormatConversionStream(new WaveFormat(44100, 32, 1), (WaveFileReader)reader);
        }


        WaveToSampleProvider waveProvider = new WaveToSampleProvider(reader);
        SampleToWaveProvider16 sample24 = new SampleToWaveProvider16(waveProvider);
        ISampleProvider wavSample = sample24.ToSampleProvider();
        ISampleProvider[] sample = new ISampleProvider[] {wavSample, wavSample };
        MultiplexingSampleProvider sampleProvider = new MultiplexingSampleProvider(sample, 2);
        float amplitude = 0.0f;
        VolumeSampleProvider volume = new VolumeSampleProvider(sampleProvider) { Volume = amplitude };

        WaveFileWriter writer = new WaveFileWriter("wav_output/output.wav", volume.WaveFormat);

        float[] buffer = new float[writer.WaveFormat.AverageBytesPerSecond * 4];
        byte[] bufferWrite = new byte[writer.WaveFormat.AverageBytesPerSecond * 4];

        int read;

        while((read = volume.Read(buffer, 0, buffer.Length)) > 0)
        {
            writer.Write(bufferWrite, 0, bufferWrite.Length);
        }

        if(writer.Length == sample.Length)
        {
            Console.WriteLine("Success!");
        }
    }
  **/

}

