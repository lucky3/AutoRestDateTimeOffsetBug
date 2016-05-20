﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1.Models
{
    public partial class OffsetWrapper
    {
        private DateTimeOffset? _offset;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OffsetWrapper class.
        /// </summary>
        public OffsetWrapper()
        {
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type OffsetWrapper
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Offset != null)
            {
                outputObject["Offset"] = this.Offset.Value;
            }
            return outputObject;
        }
    }
}
