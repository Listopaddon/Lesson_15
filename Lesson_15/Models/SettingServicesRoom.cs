using System;

namespace Lesson_15.Models
{
    public class SettingServicesRoom
    {
        public int quantityPerson { get; private set; }
        public DateTime timeMeet { get; private set; }

        public SettingServicesRoom(int quantityPerson, DateTime timeMeet)
        {
            this.quantityPerson = quantityPerson;
            this.timeMeet = timeMeet;
        }
    }
}
