using P01.Stream_Progress.Models.Interfaces;

namespace P01.Stream_Progress.Models
{
    public class StreamProgressInfo
    {
        private IStreamable file;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return file.BytesSent * 100 / file.Length;
        }
    }
}
