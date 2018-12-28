using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;
using MvxForms.Core.Model;

namespace MvxForms.Core.ViewModels
{
    public class CustomMvxFormsViewModel : MvxViewModel
    {
        public ObservableCollection<Meeting> Meetings { get; set; }
        //public ObservableCollection<Meeting> meetings { get; set; }
        
        public CustomMvxFormsViewModel()
        {
            Meetings = new ObservableCollection<Meeting>();

            for (int i = 0; i < 15; i++)
            {
                Meetings.Add(new Meeting() 
                { 
                    EventName = "Client Meeting", 
                    From = new DateTime(2018, 5, 1, 9, 0, 0).AddDays(i), 
                    To = new DateTime(2018, 5, 1, 11, 0, 0).AddDays(i),
                    Color = Color.Green
                });
            }
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
    }
}