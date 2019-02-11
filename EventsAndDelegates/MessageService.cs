using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: beep beep..." + args.Video.Title);
        }
    }
}