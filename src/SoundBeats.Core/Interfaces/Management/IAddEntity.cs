﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Core.Interfaces.Management
{
    public interface IAddEntity<TKey>
    {
        public TKey Id { get; set; }
        public int AccountIdCreationDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
