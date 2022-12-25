using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingHours.Utility
{
    public static class TradingHours
    {
        /// <summary>
        /// 交易時間在周一至周五的上午九點至下午一點半
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool IsTradingHours(DateTime dt)
        {
            return ((int)dt.DayOfWeek >= 1 && (int)dt.DayOfWeek <= 5 &&
                    dt.TimeOfDay >= TimeSpan.FromHours(9) &&
                    dt.TimeOfDay <= TimeSpan.FromHours(13.5));
        }
    }
}
