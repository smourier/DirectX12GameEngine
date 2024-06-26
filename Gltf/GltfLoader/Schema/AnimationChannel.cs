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
    
    
    public class AnimationChannel
    {
        
        /// <summary>
        /// Backing field for Sampler.
        /// </summary>
        private int _sampler;
        
        /// <summary>
        /// Backing field for Target.
        /// </summary>
        private AnimationChannelTarget _target;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> _extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras _extras;
        
        /// <summary>
        /// The index of a sampler in this animation used to compute the value for the target.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sampler")]
        public int Sampler
        {
            get
            {
                return this._sampler;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Sampler", value, "Expected value to be greater than or equal to 0");
                }
                this._sampler = value;
            }
        }
        
        /// <summary>
        /// The index of the node and TRS property to target.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("target")]
        public AnimationChannelTarget Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
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
        
        public bool ShouldSerializeTarget()
        {
            return ((_target == null) 
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
