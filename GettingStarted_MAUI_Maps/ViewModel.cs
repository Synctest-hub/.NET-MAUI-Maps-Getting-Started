using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace GettingStarted_MAUI_Maps
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model("New South Wales", "New\nSouth Wales", 1));
            Data.Add(new Model("Queensland", "Queensland",2));
            Data.Add(new Model("Northern Territory", "Northern\nTerritory",3));
            Data.Add(new Model("Victoria", "Victoria",4));
            Data.Add(new Model("Tasmania", "Tasmania",5));
            Data.Add(new Model("Western Australia", "Western Australia",6));
            Data.Add(new Model("South Australia", "South Australia",7));
        }

        public class Model
        {
            public string State { get; set; }
            public string StateCode { get; set; }
            public int ID { get; set; }

            public Model(string state, string stateCode, int id)
            {
                State = state;
                StateCode = stateCode;
                ID = id;
            }
        }
    }
}
