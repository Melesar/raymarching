using System;
using System.Collections.Generic;
using UnityEngine;

namespace Melesar.Raymarching.Utils
{
    public class RenderTargetsRepository : IDisposable
    {
        private readonly Dictionary<RenderTextureDescriptor, RenderTexture> _textures = new Dictionary<RenderTextureDescriptor, RenderTexture>();

        public RenderTexture GetRT(Camera camera)
        {
            RenderTextureDescriptor descriptor = GetDescriptor(camera);
            if (_textures.TryGetValue(descriptor, out RenderTexture texture))
            {
                return texture;
            }
            
            texture = new RenderTexture(descriptor);
            texture.Create();

            _textures.Add(descriptor, texture);
			
            return texture;
        }

        private static RenderTextureDescriptor GetDescriptor(Camera camera)
        {
            return new RenderTextureDescriptor(camera.pixelWidth, camera.pixelHeight)
            {
                enableRandomWrite = true,
                colorFormat = RenderTextureFormat.ARGBFloat,
                depthBufferBits = 0,
            };
        }
        
        public void Dispose()
        {
            foreach (var entry in _textures)
            {
                entry.Value.Release();
                UnityEngine.Object.DestroyImmediate(entry.Value);
            }
            
            _textures.Clear();
        }
    }
}