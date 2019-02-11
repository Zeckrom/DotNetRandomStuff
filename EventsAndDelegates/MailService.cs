using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailsService: Sending stuff beep beep" + e.Video.Title);
        }

    }
}