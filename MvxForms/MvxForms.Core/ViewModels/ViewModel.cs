﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.ViewModels
{
    public class ViewModel : MvxViewModel
    {
        //public ObservableCollection<Meeting> Meetings { get; set; }
        //List<string> eventNameCollection;
        //List<Color> colorCollection;
        public ViewModel()
        {
            //Meetings = new ObservableCollection<Meeting>();
            //CreateEventNameCollection();
            //CreateColorCollection();
            //CreateAppointments();

        }

        /// <summary>
        /// Creates meetings and stores in a collection.  
        /// </summary>
        //private void CreateAppointments()
        //{
        //    Random randomTime = new Random();
        //    List<Point> randomTimeCollection = GettingTimeRanges();
        //    DateTime date;
        //    DateTime DateFrom = DateTime.Now.AddDays(-10);
        //    DateTime DateTo = DateTime.Now.AddDays(10);
        //    DateTime dataRangeStart = DateTime.Now.AddDays(-3);
        //    DateTime dataRangeEnd = DateTime.Now.AddDays(3);

        //    for (date = DateFrom; date < DateTo; date = date.AddDays(1))
        //    {
        //        if ((DateTime.Compare(date, dataRangeStart) > 0) && (DateTime.Compare(date, dataRangeEnd) < 0))
        //        {
        //            for (int AdditionalAppointmentIndex = 0; AdditionalAppointmentIndex < 3; AdditionalAppointmentIndex++)
        //            {
        //                Meeting meeting = new Meeting();
        //                int hour = (randomTime.Next((int)randomTimeCollection[AdditionalAppointmentIndex].X, (int)randomTimeCollection[AdditionalAppointmentIndex].Y));
        //                meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
        //                meeting.To = (meeting.From.AddHours(1));
        //                meeting.EventName = eventNameCollection[randomTime.Next(9)];
        //                meeting.color = colorCollection[randomTime.Next(9)];
        //                if (AdditionalAppointmentIndex % 3 == 0)
        //                    meeting.AllDay = true;
        //                Meetings.Add(meeting);
        //            }
        //        }
        //        else
        //        {
        //            Meeting meeting = new Meeting();
        //            meeting.From = new DateTime(date.Year, date.Month, date.Day, randomTime.Next(9, 11), 0, 0);
        //            meeting.To = (meeting.From.AddHours(1));
        //            meeting.EventName = eventNameCollection[randomTime.Next(9)];
        //            meeting.color = colorCollection[randomTime.Next(9)];
        //            Meetings.Add(meeting);
        //        }
        //    }
        //}

        ///// <summary>  
        ///// Creates event names collection.  
        ///// </summary>  
        //private void CreateEventNameCollection()
        //{
        //    eventNameCollection = new List<string>();
        //    eventNameCollection.Add("General Meeting");
        //    eventNameCollection.Add("Plan Execution");
        //    eventNameCollection.Add("Project Plan");
        //    eventNameCollection.Add("Consulting");
        //    eventNameCollection.Add("Performance Check");
        //    eventNameCollection.Add("Yoga Therapy");
        //    eventNameCollection.Add("Plan Execution");
        //    eventNameCollection.Add("Project Plan");
        //    eventNameCollection.Add("Consulting");
        //    eventNameCollection.Add("Performance Check");
        //}

        ///// <summary>  
        ///// Creates color collection.  
        ///// </summary>  
        //private void CreateColorCollection()
        //{
        //    colorCollection = new List<Color>();
        //    colorCollection.Add(Color.FromHex("#FF339933"));
        //    colorCollection.Add(Color.FromHex("#FF00ABA9"));
        //    colorCollection.Add(Color.FromHex("#FFE671B8"));
        //    colorCollection.Add(Color.FromHex("#FF1BA1E2"));
        //    colorCollection.Add(Color.FromHex("#FFD80073"));
        //    colorCollection.Add(Color.FromHex("#FFA2C139"));
        //    colorCollection.Add(Color.FromHex("#FFA2C139"));
        //    colorCollection.Add(Color.FromHex("#FFD80073"));
        //    colorCollection.Add(Color.FromHex("#FF339933"));
        //    colorCollection.Add(Color.FromHex("#FFE671B8"));
        //    colorCollection.Add(Color.FromHex("#FF00ABA9"));
        //}

        ///// <summary>
        ///// Gets the time ranges.
        ///// </summary>
        //private List<Point> GettingTimeRanges()
        //{
        //    List<Point> randomTimeCollection = new List<Point>();
        //    randomTimeCollection.Add(new Point(9, 11));
        //    randomTimeCollection.Add(new Point(12, 14));
        //    randomTimeCollection.Add(new Point(15, 17));
        //    return randomTimeCollection;
        //}
    }
    //public class Meeting
    //{
    //    public string EventName { get; set; }
    //    public string Organizer { get; set; }
    //    public string ContactID { get; set; }
    //    public int Capacity { get; set; }
    //    public DateTime From { get; set; }
    //    public DateTime To { get; set; }
    //    public Color color { get; set; }
    //    public bool AllDay { get; set; }
    //}
}

