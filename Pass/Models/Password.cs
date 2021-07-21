using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pass.Models
{
    public class Password
    {
        String idClient;
        String code;
        DateTime start;
        DateTime end;

        public DateTime End { get => end; set => end = value; }
        public DateTime Start { get => start; set => start = value; }
        public string Code { get => code; set => code = value; }
        public string IdClient { get => idClient; set => idClient = value; }

        public Password(String userId, DateTime timer)
        {
            this.idClient = userId;
            this.start = timer;
            this.end = timer.AddSeconds(30);
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            this.code = new String(stringChars);


        }

    }
}