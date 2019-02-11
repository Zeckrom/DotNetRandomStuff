using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1"};
            var videoEncoder = new VideoEncoder(); // hedha el publisher
            var mailService = new MailService(); // hedha el subscriber
            var messageService = new MessageService(); // hedha subscriber e5er

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
