using NAudio.Wave;


namespace TestingCrafting
{
    public class Audios
    {
        public void PlayAudioCorrect()
        {
            var CorrectAudio = "C:\\Users\\denzd\\Desktop\\Testing\\TestingCrafting\\TestingCrafting\\Audio\\Correct.mp3";
            using (var AudioFile = new AudioFileReader(CorrectAudio)) 
            using(var OutputDevice = new WaveOutEvent())
            {
                OutputDevice.Init(AudioFile);
                OutputDevice.Volume = 1.0f;
                OutputDevice.Play();
                while (OutputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                    OutputDevice.Stop();
                }
            }
        }
        public void MistakeAudioPlay()
        {
            var MistakeAudio = "C:\\Users\\denzd\\Desktop\\Testing\\TestingCrafting\\TestingCrafting\\Audio\\Mistake.mp3";
            using (var AudioFile = new AudioFileReader(MistakeAudio))
            using (var OutputDevice = new WaveOutEvent())
            {
                OutputDevice.Init(AudioFile);
                OutputDevice.Volume = 1.0f;
                OutputDevice.Play();
                while (OutputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                    OutputDevice.Stop();
                }
            }
        }
    }
}
