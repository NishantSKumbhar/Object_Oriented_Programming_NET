using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Interface
{
    internal class VideoEncoder
    {
        private readonly MailService _mailService;

        public VideoEncoder()
        {
            _mailService= new MailService();
        }
        public void Encode(Video video)
        {
            _mailService.Send(new Mail());
        }
    }
}
