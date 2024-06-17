//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GltfLoader.Schema
{
    using System.Linq;
    using System.Runtime.Serialization;
    
    
    public class Buffer
    {
        
        /// <summary>
        /// Backing field for Uri.
        /// </summary>
        private string _uri;
        
        /// <summary>
        /// Backing field for Bytelength.
        /// </summary>
        private int _bytelength;
        
        /// <summary>
        /// Backing field for Name.
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> _extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras _extras;
        
        /// <summary>
        /// The uri of the buffer.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uri")]
        public string Uri
        {
            get
            {
                return this._uri;
            }
            set
            {
                this._uri = value;
            }
        }
        
        /// <summary>
        /// The length of the buffer in bytes.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("byteLength")]
        public int Bytelength
        {
            get
            {
                return this._bytelength;
            }
            set
            {
                if ((value < 1F))
                {
                    throw new System.ArgumentOutOfRangeException("Bytelength", value, "Expected value to be greater than or equal to 1");
                }
                this._bytelength = value;
            }
        }
        
        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        /// <summary>
        /// Dictionary object with extension-specific objects.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extensions")]
        public System.Collections.Generic.Dictionary<string, object> Extensions
        {
            get
            {
                return this._extensions;
            }
            set
            {
                this._extensions = value;
            }
        }
        
        /// <summary>
        /// Application-specific data.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extras")]
        public Extras Extras
        {
            get
            {
                return this._extras;
            }
            set
            {
                this._extras = value;
            }
        }
        
        public bool ShouldSerializeUri()
        {
            return ((_uri == null) 
                        == false);
        }
        
        public bool ShouldSerializeName()
        {
            return ((_name == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtensions()
        {
            return ((_extensions == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtras()
        {
            return ((_extras == null) 
                        == false);
        }
    }
}
