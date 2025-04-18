using EventEase.Client.Models;
using System.Collections.Generic;

namespace EventEase.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>
        {
            new Event { Id = 1, Name = "Music Concert", Date = new DateTime(2025, 5, 20), Location = "Johannesburg" },
            new Event { Id = 2, Name = "Art Exhibition", Date = new DateTime(2025, 6, 15), Location = "Cape Town" },
            new Event { Id = 3, Name = "Tech Conference", Date = new DateTime(2025, 7, 10), Location = "Durban" }
        };

        public List<Event> GetEvents()
        {
            return events;
        }

        public void AddEvent(Event newEvent)
        {
            newEvent.Id = events.Max(e => e.Id) + 1; 
            events.Add(newEvent);
        }

        public Event GetEventById(int id)
        {
            return events.FirstOrDefault(e => e.Id == id);
        }


        private Dictionary<int, List<string>> attendance = new Dictionary<int, List<string>>();

        public void RegisterAttendance(int eventId, string userName)
        {
            if (!attendance.ContainsKey(eventId))
            {
                attendance[eventId] = new List<string>();
            }
            attendance[eventId].Add(userName);
        }

        public List<string> GetAttendees(int eventId)
        {
            return attendance.ContainsKey(eventId) ? attendance[eventId] : new List<string>();
        }



    }
}
