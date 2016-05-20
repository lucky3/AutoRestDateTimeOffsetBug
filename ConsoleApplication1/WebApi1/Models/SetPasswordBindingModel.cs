﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1.Models
{
    public partial class SetPasswordBindingModel
    {
        private string _confirmPassword;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ConfirmPassword
        {
            get { return this._confirmPassword; }
            set { this._confirmPassword = value; }
        }
        
        private string _newPassword;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string NewPassword
        {
            get { return this._newPassword; }
            set { this._newPassword = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SetPasswordBindingModel class.
        /// </summary>
        public SetPasswordBindingModel()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SetPasswordBindingModel class
        /// with required arguments.
        /// </summary>
        public SetPasswordBindingModel(string newPassword)
            : this()
        {
            if (newPassword == null)
            {
                throw new ArgumentNullException("newPassword");
            }
            this.NewPassword = newPassword;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type SetPasswordBindingModel
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.NewPassword == null)
            {
                throw new ArgumentNullException("NewPassword");
            }
            if (this.ConfirmPassword != null)
            {
                outputObject["ConfirmPassword"] = this.ConfirmPassword;
            }
            if (this.NewPassword != null)
            {
                outputObject["NewPassword"] = this.NewPassword;
            }
            return outputObject;
        }
    }
}
