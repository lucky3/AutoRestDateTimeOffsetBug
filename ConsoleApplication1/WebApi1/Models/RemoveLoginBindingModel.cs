﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1.Models
{
    public partial class RemoveLoginBindingModel
    {
        private string _loginProvider;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string LoginProvider
        {
            get { return this._loginProvider; }
            set { this._loginProvider = value; }
        }
        
        private string _providerKey;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string ProviderKey
        {
            get { return this._providerKey; }
            set { this._providerKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoveLoginBindingModel class.
        /// </summary>
        public RemoveLoginBindingModel()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RemoveLoginBindingModel class
        /// with required arguments.
        /// </summary>
        public RemoveLoginBindingModel(string loginProvider, string providerKey)
            : this()
        {
            if (loginProvider == null)
            {
                throw new ArgumentNullException("loginProvider");
            }
            if (providerKey == null)
            {
                throw new ArgumentNullException("providerKey");
            }
            this.LoginProvider = loginProvider;
            this.ProviderKey = providerKey;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type RemoveLoginBindingModel
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.LoginProvider == null)
            {
                throw new ArgumentNullException("LoginProvider");
            }
            if (this.ProviderKey == null)
            {
                throw new ArgumentNullException("ProviderKey");
            }
            if (this.LoginProvider != null)
            {
                outputObject["LoginProvider"] = this.LoginProvider;
            }
            if (this.ProviderKey != null)
            {
                outputObject["ProviderKey"] = this.ProviderKey;
            }
            return outputObject;
        }
    }
}
