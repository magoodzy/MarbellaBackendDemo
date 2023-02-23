using MailKit;
using MailKit.Security;
using MarbellaMS.IRepositories;
using MarbellaMS.Requests;
using MarbellaMS.ViewModel;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MarbellaMS.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailServiceRepository mailService;
        public MailController(IMailServiceRepository mailService)
        {
            this.mailService = mailService;
        }
        [HttpPost("send")]
        public  IActionResult SendMail([FromBody] MailRequest request)
        {
            try
            {
                 mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpPost("CreateCalender")]
        public async Task <IActionResult> CreateCalender([FromBody] CreateMailCalenderRequest request)
        {
            try
            {
                var x=await mailService.CreateCalender(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

         [HttpPost("Read_Emails")]
        public async Task <IActionResult> Read_Emails()
        {
            Pop3Client pop3Client = new Pop3Client();
            pop3Client.Connect("pop.gmail.com", 995, true);
            pop3Client.Authenticate("remon.abuelezz@gmail.com", "RT45ab7j8@@");
            //pop3Client.Connect("Outlook.office365.com", _mailSettings.Port, SecureSocketOptions.Auto);

            //pop3Client.Authenticate(_mailSettings.Mail, _mailSettings.Password);

            int count = pop3Client.GetMessageCount();
            List<EmailModel> emails = new List<EmailModel>();
            int counter = 0;
            for (int i = count; i >= 1; i--)
            {
                Message message = pop3Client.GetMessage(i);
                EmailModel email = new EmailModel()
                {
                    MessageNumber = i,
                    From = string.Format("<a href = 'mailto:{1}'>{0}</a>", message.Headers.From.DisplayName, message.Headers.From.Address),
                    Subject = message.Headers.Subject,
                    DateSent = message.Headers.DateSent
                };
                MessagePart body = message.FindFirstHtmlVersion();
                if (body != null)
                {
                    email.Body = body.GetBodyAsText();
                }
                else
                {
                    body = message.FindFirstPlainTextVersion();
                    if (body != null)
                    {
                        email.Body = body.GetBodyAsText();
                    }
                }
                emails.Add(email);
                counter++;
                if (counter > 2)
                {
                    break;
                }
            }

            return Ok (emails);


        }


    }
}