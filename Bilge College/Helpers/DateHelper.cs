using System;
using System.Text;

namespace Bilge_College.Helpers
{
    public  class DateHelper
    {
        public  string timeSpan(DateTime t)
        {
            var ss =DateTime.Now;

            StringBuilder stringBuilder = new StringBuilder();
            TimeSpan fark = ss.Subtract(t);
            if (fark.Days > 0)
                stringBuilder.Append($"{fark.Days} Gün ");
            if(fark.Hours > 0)
                stringBuilder.Append($"{fark.Hours} Saat ");
            if (fark.Minutes > 0)
                stringBuilder.Append($"{fark.Minutes} Dakika ");
            return stringBuilder.ToString();
        }
    }
}
