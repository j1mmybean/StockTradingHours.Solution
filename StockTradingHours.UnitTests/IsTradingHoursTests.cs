using StockTradingHours.Utility;
namespace StockTradingHours.UnitTests
{
    public class IsTradingHoursTests
    {
        [TestCase("2022-12-23 9:00:00")]
        [TestCase("2022-12-23 13:30:00")]
        [TestCase("2022-12-26 9:00:00")]
        [TestCase("2022-12-26 13:30:00")]
        public void IsTradingHours_�������ɶ�_�Ǧ^true(string dt_string)
        {
            DateTime source = Convert.ToDateTime(dt_string);
            bool actual = TradingHours.IsTradingHours(source);
            Assert.IsTrue(actual);
        }



        [TestCase("2022-12-23 8:59:59")]
        [TestCase("2022-12-23 13:30:01")]
        [TestCase("2022-12-26 8:59:59")]
        [TestCase("2022-12-26 13:30:01")]
        public void IsTradingHours_����D����ɶ�_�Ǧ^false(string dt_string)
        {
            DateTime source = Convert.ToDateTime(dt_string);
            bool actual = TradingHours.IsTradingHours(source);
            Assert.IsFalse(actual);
        }
        [TestCase("2022-12-24 9:00:00")]
        [TestCase("2022-12-24 13:30:00")]
        [TestCase("2022-12-25 9:00:00")]
        [TestCase("2022-12-25 13:30:00")]
        public void IsTradingHours_�������ɶ�_�Ǧ^false(string dt_string)
        {
            DateTime source = Convert.ToDateTime(dt_string);
            bool actual = TradingHours.IsTradingHours(source);
            Assert.IsFalse(actual);
        }
    }
}