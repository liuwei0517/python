using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                mailMsg.To.Add(new MailAddress("849098101@qq.com"));
                mailMsg.From = new MailAddress("faith163163@163.com", "joy");
                //可选，设置回信地址 
               // mailMsg.ReplyTo.="***";
                // 邮件主题
                mailMsg.Subject = "邮件主题C#测试";
                // 邮件正文内容
                string text = "欢迎使用阿里云邮件推送";
                string html = @"欢迎使用<a href=""https://dm.console.aliyun.com"">邮件推送</a>";
                mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
                mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));
                // 添加附件
                //string file = "D:\\1.txt";
                //Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
                //mailMsg.Attachments.Add(data);
                //邮件推送的SMTP地址和端口
                SmtpClient smtpClient = new SmtpClient("smtpdm.aliyun.com", 25);
                // 使用SMTP用户名和密码进行验证
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("faith163163@163.com", "lwf123");
                smtpClient.Credentials = credentials;
                smtpClient.Send(mailMsg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public string sendemail()
        {
            
            return "";
        }
    }
}