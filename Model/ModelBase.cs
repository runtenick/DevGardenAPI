﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelBase
    {
        #region Properties

        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion
    }
}
