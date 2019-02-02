﻿using System;
using System.Collections.Generic;
using System.Text;
using static DFF.Api.Models.Enums.TicketEnums;

namespace DFF.Api.Models.Tickets
{
    public class TicketDetailsDto : TicketDto
    {
        //TODO Dictionary avaible seats and its Classes
        public Class Class { get; set; }
        public ushort Seat { get; set; }
        public string PlainName { get; set; }
    }
}
