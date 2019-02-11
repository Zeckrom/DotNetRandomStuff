using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsGay { get; set; }
        public Origin Origin { get; set; }
        public string Gender { get; set; }
        public bool IsDisgusted { get; set; }

        public Person()
        {

        }
        public Person(string firstName, Origin origin, string gender, int age)
        {
            this.IsGay = false;
            this.FirstName = firstName;
            this.Origin = origin;
            this.Gender = gender;
            this.Age = age;
            this.IsDisgusted = false;
        }

        public void TurningGayEmergency()
        {
            IsGay = true;
        }

        public void Migrate(Origin origin)
        {
            this.Origin = origin;
        }

        public void Stanna()
        {
            this.Age += 10;
        }

        //public async Task FapAsync(string url)
        //{
        //    var webClient = new WebClient();
        //    var html = await webClient.DownloadStringTaskAsync(url);

        //    using (var streamWriter = new StreamWriter(@"d:\result.html"))
        //    {
        //        await streamWriter.WriteAsync(html);
        //    }
        //}

        public void JerkOut()
        {
            var pleasure = 1;

            while (pleasure < 1000)
            {
                Console.WriteLine("fap fap fap");
                pleasure++;
            }
            Console.WriteLine("ahhhhhhh");
            this.IsDisgusted = true;
        }
    }
}
