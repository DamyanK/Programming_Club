using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_16
{
    class Mp3
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturnString, int returnLength, int callBack);

        public void Open(string fileName)
        {
            string format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(format, fileName);
            mciSendString(command, null, 0, 0);
        }

        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
    }
}
