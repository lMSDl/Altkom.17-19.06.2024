﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    internal class Person : ICloneable, IRestorable<Person>, INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person person)
        {
            firstName = person.FirstName;
            lastName = person.LastName;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
