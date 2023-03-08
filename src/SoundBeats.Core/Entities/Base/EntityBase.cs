﻿using SoundBeats.Core.Interfaces.Management;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities.Base
{
    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey Id { get; set; }
        //public int AccountIdCreationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }

        //public int? AccountIdUpdateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? LastDeletedBy { get; set; }
        //public int? AccountIdDeleteDate { get; set; }
    }
}
