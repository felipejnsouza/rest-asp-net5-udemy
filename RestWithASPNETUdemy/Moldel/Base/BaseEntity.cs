﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Moldel.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
