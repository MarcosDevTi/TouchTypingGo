﻿using System.Threading.Tasks;

namespace TouchTypingGo.Infra.CrossCutting.Identity.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
