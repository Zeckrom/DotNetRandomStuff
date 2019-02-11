using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        /// steps to create an event:
        /// 1- Define a delegate
        /// 2- Define an event based on that delegate
        /// 3- Raise the event

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event EventHandler<VideoEventArgs> VideoEncoded;

        // public event EventHandler<VideoEventArgs> VideoEncoded; // use this for dataless event

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() {Video = video});
        }
    }
}