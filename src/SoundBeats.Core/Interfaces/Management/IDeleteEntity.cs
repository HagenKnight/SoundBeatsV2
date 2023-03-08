﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Core.Interfaces.Management
{
    public interface IDeleteEntity<TKey> : IAddEntity<TKey>
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        //public int? AccountIdDeleteDate { get; set; }

        public string? LastDeletedBy { get; set; }
    }
}
