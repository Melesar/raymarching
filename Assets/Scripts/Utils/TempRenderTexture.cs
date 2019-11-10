using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Melesar.Raymarching.Utils
{
    public class TempRenderTexture : IDisposable
    {
        private readonly RenderTexture _rt;

        public int GetInstanceID()
        {
            return _rt.GetInstanceID();
        }

        public string name
        {
            get => _rt.name;
            set => _rt.name = value;
        }

        public HideFlags hideFlags
        {
            get => _rt.hideFlags;
            set => _rt.hideFlags = value;
        }

        public IntPtr GetNativeTexturePtr()
        {
            return _rt.GetNativeTexturePtr();
        }

        public void IncrementUpdateCount()
        {
            _rt.IncrementUpdateCount();
        }

        public int mipmapCount => _rt.mipmapCount;

        public bool isReadable => _rt.isReadable;

        public TextureWrapMode wrapMode
        {
            get => _rt.wrapMode;
            set => _rt.wrapMode = value;
        }

        public TextureWrapMode wrapModeU
        {
            get => _rt.wrapModeU;
            set => _rt.wrapModeU = value;
        }

        public TextureWrapMode wrapModeV
        {
            get => _rt.wrapModeV;
            set => _rt.wrapModeV = value;
        }

        public TextureWrapMode wrapModeW
        {
            get => _rt.wrapModeW;
            set => _rt.wrapModeW = value;
        }

        public FilterMode filterMode
        {
            get => _rt.filterMode;
            set => _rt.filterMode = value;
        }

        public int anisoLevel
        {
            get => _rt.anisoLevel;
            set => _rt.anisoLevel = value;
        }

        public float mipMapBias
        {
            get => _rt.mipMapBias;
            set => _rt.mipMapBias = value;
        }

        public Vector2 texelSize => _rt.texelSize;

        public uint updateCount => _rt.updateCount;

        public Hash128 imageContentsHash
        {
            get => _rt.imageContentsHash;
            set => _rt.imageContentsHash = value;
        }

        public IntPtr GetNativeDepthBufferPtr()
        {
            return _rt.GetNativeDepthBufferPtr();
        }

        public void DiscardContents(bool discardColor, bool discardDepth)
        {
            _rt.DiscardContents(discardColor, discardDepth);
        }

        public void MarkRestoreExpected()
        {
            _rt.MarkRestoreExpected();
        }

        public void DiscardContents()
        {
            _rt.DiscardContents();
        }

        public void ResolveAntiAliasedSurface()
        {
            _rt.ResolveAntiAliasedSurface();
        }

        public void ResolveAntiAliasedSurface(RenderTexture target)
        {
            _rt.ResolveAntiAliasedSurface(target);
        }

        public void SetGlobalShaderProperty(string propertyName)
        {
            _rt.SetGlobalShaderProperty(propertyName);
        }

        public bool Create()
        {
            return _rt.Create();
        }

        public void Release()
        {
            _rt.Release();
        }

        public bool IsCreated()
        {
            return _rt.IsCreated();
        }

        public void GenerateMips()
        {
            _rt.GenerateMips();
        }

        public void ConvertToEquirect(RenderTexture equirect, Camera.MonoOrStereoscopicEye eye = Camera.MonoOrStereoscopicEye.Mono)
        {
            _rt.ConvertToEquirect(equirect, eye);
        }

        public Vector2 GetTexelOffset()
        {
            return _rt.GetTexelOffset();
        }

        public int width
        {
            get => _rt.width;
            set => _rt.width = value;
        }

        public int height
        {
            get => _rt.height;
            set => _rt.height = value;
        }

        public TextureDimension dimension
        {
            get => _rt.dimension;
            set => _rt.dimension = value;
        }

        public GraphicsFormat graphicsFormat
        {
            get => _rt.graphicsFormat;
            set => _rt.graphicsFormat = value;
        }

        public bool useMipMap
        {
            get => _rt.useMipMap;
            set => _rt.useMipMap = value;
        }

        public bool sRGB => _rt.sRGB;

        public VRTextureUsage vrUsage
        {
            get => _rt.vrUsage;
            set => _rt.vrUsage = value;
        }

        public RenderTextureMemoryless memorylessMode
        {
            get => _rt.memorylessMode;
            set => _rt.memorylessMode = value;
        }

        public RenderTextureFormat format
        {
            get => _rt.format;
            set => _rt.format = value;
        }

        public GraphicsFormat stencilFormat
        {
            get => _rt.stencilFormat;
            set => _rt.stencilFormat = value;
        }

        public bool autoGenerateMips
        {
            get => _rt.autoGenerateMips;
            set => _rt.autoGenerateMips = value;
        }

        public int volumeDepth
        {
            get => _rt.volumeDepth;
            set => _rt.volumeDepth = value;
        }

        public int antiAliasing
        {
            get => _rt.antiAliasing;
            set => _rt.antiAliasing = value;
        }

        public bool bindTextureMS
        {
            get => _rt.bindTextureMS;
            set => _rt.bindTextureMS = value;
        }

        public bool enableRandomWrite
        {
            get => _rt.enableRandomWrite;
            set => _rt.enableRandomWrite = value;
        }

        public bool useDynamicScale
        {
            get => _rt.useDynamicScale;
            set => _rt.useDynamicScale = value;
        }

        public bool isPowerOfTwo
        {
            get => _rt.isPowerOfTwo;
            set => _rt.isPowerOfTwo = value;
        }

        public RenderBuffer colorBuffer => _rt.colorBuffer;

        public RenderBuffer depthBuffer => _rt.depthBuffer;

        public int depth
        {
            get => _rt.depth;
            set => _rt.depth = value;
        }

        public RenderTextureDescriptor descriptor
        {
            get => _rt.descriptor;
            set => _rt.descriptor = value;
        }

        public bool generateMips
        {
            get => _rt.autoGenerateMips;
            set => _rt.autoGenerateMips = value;
        }

        public bool isCubemap
        {
            get => _rt.isCubemap;
            set => _rt.isCubemap = value;
        }

        public bool isVolume
        {
            get => _rt.isVolume;
            set => _rt.isVolume = value;
        }
        
        public static implicit operator RenderTexture (TempRenderTexture rt)
        {
            return rt._rt;
        }

        public TempRenderTexture(RenderTextureDescriptor descriptor)
        {
            _rt = RenderTexture.GetTemporary(descriptor);
        }
        
        public void Dispose()
        {
            RenderTexture.ReleaseTemporary(_rt);
        }
    }
}