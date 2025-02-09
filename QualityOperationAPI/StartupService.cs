﻿using Utils.Services;

namespace QualityOperaterAPI
{
    public class StartupService
    {
        public static void InitialService(IServiceCollection services)
        {
            /* --- Repositories --- */

            services.AddTransient<IEmailService, EmailService>();
            //EmailService : IEmailService


            /* --- Services --- */

        }
    }
}
