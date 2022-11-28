using System;

namespace Lesson_15.Models
{
    public class RoomMeet
    {
        int quantityPerson;
        DateTime timeMeet;

        public RoomMeet(SettingServicesRoom setting)
        {
            this.quantityPerson = setting.quantityPerson;
            this.timeMeet = setting.timeMeet;
        }

        public void GetSettings()
        {
            Console.WriteLine($"Quantity person is {quantityPerson}");
            Console.WriteLine($"Time meet will over at {timeMeet.Hour} o'clock");
        }
    }
}
