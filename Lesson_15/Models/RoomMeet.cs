using Microsoft.Extensions.Options;
using System;

namespace Lesson_15.Models
{
    public class RoomMeet
    {
        private readonly SettingServicesRoom options;
        public RoomMeet(IOptions<SettingServicesRoom> options)
        {
            this.options = options.Value;
        }

        public string GetSettings()
        {
            return $"Quantity person is {options.quantityPerson}, Time is {options.timeMeet}";
        }
    }
}
