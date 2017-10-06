// <copyright file="EntityBase.cs" company="Tiqri Ltd">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Deepakumar</author>
// <date>28/09/2017</date>
// <summary></summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.Model.Enum;

namespace Tiqri.AMS.Model
{
    public abstract class EntityBase
    {
        public int? ID { get; set; }

        public byte[] TimeStamp { get; set; }

        private State _state;
        public State State { get { return _state; } set { _state = value; } }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
