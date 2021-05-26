
using EasyCarpet.Domain.Interfaces;
using System;

namespace EasyCarpet.Api.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
