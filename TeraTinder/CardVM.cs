﻿using System;
using TeraDataLite;

namespace TeraTinder
{
    public class CardVM : BaseVM
    {
        private bool _rated;
        public bool CardRated => _rated;
        public event Action Rated;
        public uint PlayerId { get; }
        public string Name { get; }
        public string Job { get; set; }
        public int Level { get; }
        public int Distance { get; }

        public Race Race { get; set; }


        public CardVM(string name, string job, int level, int distance, Race race, uint playerId)
        {
            Name = name;
            Job = job;
            Level = level;
            Distance = distance;
            Race = race;
            PlayerId = playerId;
        }

        public void InvokeRated()
        {

            if (_rated) return;
            _rated = true;
            Rated?.Invoke();
        }
    }
}