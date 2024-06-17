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
    
    
    public class MaterialOcclusionTextureInfo
    {
        
        /// <summary>
        /// Backing field for Index.
        /// </summary>
        private int _index;
        
        /// <summary>
        /// Backing field for Texcoord.
        /// </summary>
        private int _texcoord = 0;
        
        /// <summary>
        /// Backing field for Strength.
        /// </summary>
        private float _strength = 1F;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> _extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras _extras;
        
        /// <summary>
        /// The index of the texture.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("index")]
        public int Index
        {
            get
            {
                return this._index;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Index", value, "Expected value to be greater than or equal to 0");
                }
                this._index = value;
            }
        }
        
        /// <summary>
        /// The set index of texture's TEXCOORD attribute used for texture coordinate mapping.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("texCoord")]
        public int Texcoord
        {
            get
            {
                return this._texcoord;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Texcoord", value, "Expected value to be greater than or equal to 0");
                }
                this._texcoord = value;
            }
        }
        
        /// <summary>
        /// A scalar multiplier controlling the amount of occlusion applied.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("strength")]
        public float Strength
        {
            get
            {
                return this._strength;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Strength", value, "Expected value to be greater than or equal to 0");
                }
                if ((value > 1F))
                {
                    throw new System.ArgumentOutOfRangeException("Strength", value, "Expected value to be less than or equal to 1");
                }
                this._strength = value;
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
        
        public bool ShouldSerializeTexcoord()
        {
            return ((_texcoord == 0) 
                        == false);
        }
        
        public bool ShouldSerializeStrength()
        {
            return ((_strength == 1F) 
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