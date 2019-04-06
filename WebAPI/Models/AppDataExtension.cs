using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public static class AppDataExtension
    {
        public static void EnsureDBSeeded(this PaymentDetailContext context)
        {
            if(!context.PaymentDetails.Any())
            {
                context.AddRange(new PaymentDetail[]
                    {
                    new PaymentDetail()
                    {
                        PMId = 1,
                        CardNumber = "1234567890123456",
                        CardOwnerName = "Vinay Adiga",
                        CVV = "256",
                        ExpirationDate = "12/12"
                    },

                    new PaymentDetail()
                    {
                        PMId = 1,
                        CardNumber = "0123456789987456",
                        CardOwnerName = "Pushpendra Singh",
                        CVV = "256",
                        ExpirationDate = "01/12"
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
