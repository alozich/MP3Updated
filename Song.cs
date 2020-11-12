using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoxSharp;


namespace MP3
{
    class Song
    {
        private AudioInfo info;
        private string fileName;
        private int durationSec;

        public Song()
        {
            fileName = null;
            durationSec = 0;
        }
        public Song(string file)
        {
            fileName = file;
            SetAudioInfo(fileName);
            SetDuration();
        }

        private void SetDuration()
        {
            TimeSpan t = info.Duration;
            durationSec = t.Seconds + (t.Minutes * 60);
        }

        private void SetAudioInfo(string file)
        {
            using (Sox sox = new Sox("C:\\Program Files (x86)\\sox-14-4-1\\sox.exe"))
            {
                info = sox.GetInfo(file);
            }
        }


    }
}
