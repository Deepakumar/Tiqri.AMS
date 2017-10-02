// <copyright file="AccidentCategory.cs" company="Tiqri Ltd">
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

namespace Tiqri.AMS.Model
{
    public class AccidentCategory : EntityBase
    {
        public string Name { get; set; }

        public virtual IList<Accident> AccidentList { get; set; }
    }
}
