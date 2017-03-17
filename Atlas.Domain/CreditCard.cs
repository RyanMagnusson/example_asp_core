using System;
using NodaTime;

namespace Atlas.Domain
{
 

    public class ExpirationDate 
    {
        private int _month;
        private int _year;
        
        public int Month 
        { 
            get 
            {
                return _month;
            }
            set 
            {
                if (_month < 1 || _month > 12)
                    throw new System.ArgumentOutOfRangeException("A Month must be between 1 and 12");
                
                _month = value;
            } 
        }

        public int Year 
        { 
            get
            {
                return _year;   
            }

            set
            {
                _year = value;
            } 
        }

        public bool IsExpired 
        {
            get
            {
                ZonedDateTime now = SystemClock.Instance.GetCurrentInstant().InUtc();
                return now.Year > _year 
                            || (now.Year == _year && now.Month > _month);
            }
        }
    }

    public class CreditCard
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string SecurityCode { get; set; }
        public ExpirationDate ExpirationDate { get; set; }
        public string City { get; set; }
        public long Capacity { get; set; }
    }
}