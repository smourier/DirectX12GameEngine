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
    
    
    public class Gltf
    {
        
        /// <summary>
        /// Backing field for Extensionsused.
        /// </summary>
        private string[] _extensionsused;
        
        /// <summary>
        /// Backing field for Extensionsrequired.
        /// </summary>
        private string[] _extensionsrequired;
        
        /// <summary>
        /// Backing field for Accessors.
        /// </summary>
        private Accessor[] _accessors;
        
        /// <summary>
        /// Backing field for Animations.
        /// </summary>
        private Animation[] _animations;
        
        /// <summary>
        /// Backing field for Asset.
        /// </summary>
        private Asset _asset;
        
        /// <summary>
        /// Backing field for Buffers.
        /// </summary>
        private Buffer[] _buffers;
        
        /// <summary>
        /// Backing field for Bufferviews.
        /// </summary>
        private BufferView[] _bufferviews;
        
        /// <summary>
        /// Backing field for Cameras.
        /// </summary>
        private Camera[] _cameras;
        
        /// <summary>
        /// Backing field for Images.
        /// </summary>
        private Image[] _images;
        
        /// <summary>
        /// Backing field for Materials.
        /// </summary>
        private Material[] _materials;
        
        /// <summary>
        /// Backing field for Meshes.
        /// </summary>
        private Mesh[] _meshes;
        
        /// <summary>
        /// Backing field for Nodes.
        /// </summary>
        private Node[] _nodes;
        
        /// <summary>
        /// Backing field for Samplers.
        /// </summary>
        private Sampler[] _samplers;
        
        /// <summary>
        /// Backing field for Scene.
        /// </summary>
        private System.Nullable<int> _scene;
        
        /// <summary>
        /// Backing field for Scenes.
        /// </summary>
        private Scene[] _scenes;
        
        /// <summary>
        /// Backing field for Skins.
        /// </summary>
        private Skin[] _skins;
        
        /// <summary>
        /// Backing field for Textures.
        /// </summary>
        private Texture[] _textures;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> _extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras _extras;
        
        /// <summary>
        /// Names of glTF extensions used somewhere in this asset.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extensionsUsed")]
        public string[] Extensionsused
        {
            get
            {
                return this._extensionsused;
            }
            set
            {
                if ((value == null))
                {
                    this._extensionsused = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._extensionsused = value;
            }
        }
        
        /// <summary>
        /// Names of glTF extensions required to properly load this asset.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extensionsRequired")]
        public string[] Extensionsrequired
        {
            get
            {
                return this._extensionsrequired;
            }
            set
            {
                if ((value == null))
                {
                    this._extensionsrequired = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._extensionsrequired = value;
            }
        }
        
        /// <summary>
        /// An array of accessors.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("accessors")]
        public Accessor[] Accessors
        {
            get
            {
                return this._accessors;
            }
            set
            {
                if ((value == null))
                {
                    this._accessors = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._accessors = value;
            }
        }
        
        /// <summary>
        /// An array of keyframe animations.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("animations")]
        public Animation[] Animations
        {
            get
            {
                return this._animations;
            }
            set
            {
                if ((value == null))
                {
                    this._animations = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._animations = value;
            }
        }
        
        /// <summary>
        /// Metadata about the glTF asset.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("asset")]
        public Asset Asset
        {
            get
            {
                return this._asset;
            }
            set
            {
                this._asset = value;
            }
        }
        
        /// <summary>
        /// An array of buffers.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("buffers")]
        public Buffer[] Buffers
        {
            get
            {
                return this._buffers;
            }
            set
            {
                if ((value == null))
                {
                    this._buffers = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._buffers = value;
            }
        }
        
        /// <summary>
        /// An array of bufferViews.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bufferViews")]
        public BufferView[] Bufferviews
        {
            get
            {
                return this._bufferviews;
            }
            set
            {
                if ((value == null))
                {
                    this._bufferviews = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._bufferviews = value;
            }
        }
        
        /// <summary>
        /// An array of cameras.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cameras")]
        public Camera[] Cameras
        {
            get
            {
                return this._cameras;
            }
            set
            {
                if ((value == null))
                {
                    this._cameras = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._cameras = value;
            }
        }
        
        /// <summary>
        /// An array of images.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("images")]
        public Image[] Images
        {
            get
            {
                return this._images;
            }
            set
            {
                if ((value == null))
                {
                    this._images = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._images = value;
            }
        }
        
        /// <summary>
        /// An array of materials.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("materials")]
        public Material[] Materials
        {
            get
            {
                return this._materials;
            }
            set
            {
                if ((value == null))
                {
                    this._materials = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._materials = value;
            }
        }
        
        /// <summary>
        /// An array of meshes.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("meshes")]
        public Mesh[] Meshes
        {
            get
            {
                return this._meshes;
            }
            set
            {
                if ((value == null))
                {
                    this._meshes = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._meshes = value;
            }
        }
        
        /// <summary>
        /// An array of nodes.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nodes")]
        public Node[] Nodes
        {
            get
            {
                return this._nodes;
            }
            set
            {
                if ((value == null))
                {
                    this._nodes = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._nodes = value;
            }
        }
        
        /// <summary>
        /// An array of samplers.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("samplers")]
        public Sampler[] Samplers
        {
            get
            {
                return this._samplers;
            }
            set
            {
                if ((value == null))
                {
                    this._samplers = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._samplers = value;
            }
        }
        
        /// <summary>
        /// The index of the default scene.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scene")]
        public System.Nullable<int> Scene
        {
            get
            {
                return this._scene;
            }
            set
            {
                if ((value < 0F))
                {
                    throw new System.ArgumentOutOfRangeException("Scene", value, "Expected value to be greater than or equal to 0");
                }
                this._scene = value;
            }
        }
        
        /// <summary>
        /// An array of scenes.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scenes")]
        public Scene[] Scenes
        {
            get
            {
                return this._scenes;
            }
            set
            {
                if ((value == null))
                {
                    this._scenes = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._scenes = value;
            }
        }
        
        /// <summary>
        /// An array of skins.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("skins")]
        public Skin[] Skins
        {
            get
            {
                return this._skins;
            }
            set
            {
                if ((value == null))
                {
                    this._skins = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._skins = value;
            }
        }
        
        /// <summary>
        /// An array of textures.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("textures")]
        public Texture[] Textures
        {
            get
            {
                return this._textures;
            }
            set
            {
                if ((value == null))
                {
                    this._textures = value;
                    return;
                }
                if ((value.Length < 1u))
                {
                    throw new System.ArgumentException("Array not long enough");
                }
                this._textures = value;
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
        
        public bool ShouldSerializeExtensionsused()
        {
            return ((_extensionsused == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtensionsrequired()
        {
            return ((_extensionsrequired == null) 
                        == false);
        }
        
        public bool ShouldSerializeAccessors()
        {
            return ((_accessors == null) 
                        == false);
        }
        
        public bool ShouldSerializeAnimations()
        {
            return ((_animations == null) 
                        == false);
        }
        
        public bool ShouldSerializeAsset()
        {
            return ((_asset == null) 
                        == false);
        }
        
        public bool ShouldSerializeBuffers()
        {
            return ((_buffers == null) 
                        == false);
        }
        
        public bool ShouldSerializeBufferviews()
        {
            return ((_bufferviews == null) 
                        == false);
        }
        
        public bool ShouldSerializeCameras()
        {
            return ((_cameras == null) 
                        == false);
        }
        
        public bool ShouldSerializeImages()
        {
            return ((_images == null) 
                        == false);
        }
        
        public bool ShouldSerializeMaterials()
        {
            return ((_materials == null) 
                        == false);
        }
        
        public bool ShouldSerializeMeshes()
        {
            return ((_meshes == null) 
                        == false);
        }
        
        public bool ShouldSerializeNodes()
        {
            return ((_nodes == null) 
                        == false);
        }
        
        public bool ShouldSerializeSamplers()
        {
            return ((_samplers == null) 
                        == false);
        }
        
        public bool ShouldSerializeScene()
        {
            return ((_scene == null) 
                        == false);
        }
        
        public bool ShouldSerializeScenes()
        {
            return ((_scenes == null) 
                        == false);
        }
        
        public bool ShouldSerializeSkins()
        {
            return ((_skins == null) 
                        == false);
        }
        
        public bool ShouldSerializeTextures()
        {
            return ((_textures == null) 
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
