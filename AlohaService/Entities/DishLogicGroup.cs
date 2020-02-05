﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlohaService.Entities
{
    public class DishLogicGroup : Interfaces.IRealTimeUpdater
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public long PositionForPrint { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? UpdatedDate { get; set; }
        public Guid LastUpdatedSession { get; set; }
    }
}