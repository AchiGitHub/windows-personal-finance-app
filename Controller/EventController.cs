using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp.Controller
{
    class EventController
    {
        private String title;
        private DateTime date;
        private String note;
        private String type;
        private String with;
        private DateTime appointment_from;
        private DateTime appointment_to;

        public EventController(String title, DateTime date, String note, String type, String with, DateTime appointment_from, DateTime appointment_to)
        {
            this.title = title;
            this.date = date;
            this.note = note;
            this.type = type;
            this.with = with;
            this.appointment_from = appointment_from;
            this.appointment_to = appointment_to;
        }

        public void CreateEvent()
        {
            Event newEvent = new Event();
            newEvent.CreateEvent(title, date, note, type, with, appointment_from, appointment_to);
        }
    }
}
