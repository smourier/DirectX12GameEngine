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
    
    
    public class MaterialPbrMetallicRoughness
    {
        
        /// <summary>
        /// Backing field for Basecolorfactor.
        /// </summary>
        private float[] _basecolorfactor = new float[] {
                1F,
                1F,
                1F,
                1F};
        
        /// <summary>
        /// Backing field for Basecolortexture.
        /// </summary>
        private TextureInfo _basecolortexture;
        
        /// <summary>
        /// Backing field for Metallicfactor.
        /// </summary>
        private float _metallicfactor = 1F;
        
        /// <summary>
        /// Backing field for Roughnessfactor.
        /// </summary>
        private float _roughnessfactor = 1F;
        
        /// <summary>
        /// Backing field for Metallicroughnesstexture.
        /// </summary>
        private TextureInfo _metallicroughnesstexture;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> _extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras _extras;
        
        /// <summary>
        /// The material's base color factor.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("baseColorFactor")]
        public float[] Basecolorfactor
        {
            get
            {
                return this._basecolorfactor;
            }
            set
            {
                if ((value == null))
                {
                    this._basecolorfactor = value;
                    return;
                }
                if ((value.Length < 4u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                if ((value.Length > 4u))
                {
                    throw new System.ArgumentException("Array too long");
                }
                int index = 0;
                for (index = 0; (index < value.Length); index = (index + 1))
                {
                    if ((value[index] < 0F))
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                for (index = 0; (index < value.Length); index = (index + 1))
                {
                    if ((value[index] > 1F))
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                this._basecolorfactor = value;
            }
        }
        
        /// <summary>
        /// The base color texture.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("baseColorTexture")]
        public TextureInfo Basecolortexture
        {
            get
            {
                return this._basecolortexture;
            }
            set
            {
                this._basecolortexture = value;
            }
        }
        
        /// <summary>
        /// The metalness of the material.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metallicFactor")]
        public float Metallicfactor
        {
            get
            {
                return this._metallicfactor;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Metallicfactor", value, "Expected value to be greater than or equal to 0");
                }
                if ((value > 1F))
                {
                    throw new System.ArgumentOutOfRangeException("Metallicfactor", value, "Expected value to be less than or equal to 1");
                }
                this._metallicfactor = value;
            }
        }
        
        /// <summary>
        /// The roughness of the material.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roughnessFactor")]
        public float Roughnessfactor
        {
            get
            {
                return this._roughnessfactor;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Roughnessfactor", value, "Expected value to be greater than or equal to 0");
                }
                if ((value > 1F))
                {
                    throw new System.ArgumentOutOfRangeException("Roughnessfactor", value, "Expected value to be less than or equal to 1");
                }
                this._roughnessfactor = value;
            }
        }
        
        /// <summary>
        /// The metallic-roughness texture.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metallicRoughnessTexture")]
        public TextureInfo Metallicroughnesstexture
        {
            get
            {
                return this._metallicroughnesstexture;
            }
            set
            {
                this._metallicroughnesstexture = value;
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
        
        public bool ShouldSerializeBasecolorfactor()
        {
            return (_basecolorfactor.SequenceEqual(new float[] {
                        1F,
                        1F,
                        1F,
                        1F}) == false);
        }
        
        public bool ShouldSerializeBasecolortexture()
        {
            return ((_basecolortexture == null) 
                        == false);
        }
        
        public bool ShouldSerializeMetallicfactor()
        {
            return ((_metallicfactor == 1F) 
                        == false);
        }
        
        public bool ShouldSerializeRoughnessfactor()
        {
            return ((_roughnessfactor == 1F) 
                        == false);
        }
        
        public bool ShouldSerializeMetallicroughnesstexture()
        {
            return ((_metallicroughnesstexture == null) 
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