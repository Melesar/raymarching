using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using RectInt = UnityEngine.RectInt;

namespace Melesar.Raymarching.Utils
{
    public class TempCommandBuffer : IDisposable
    {
        private readonly CommandBuffer _commandBuffer;

        public void ConvertTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
        {
            _commandBuffer.ConvertTexture(src, dst);
        }

        public void ConvertTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
        {
            _commandBuffer.ConvertTexture(src, srcElement, dst, dstElement);
        }

        public void RequestAsyncReadback(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, callback);
        }

        public void RequestAsyncReadback(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, size, offset, callback);
        }

        public void RequestAsyncReadback(Texture src, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, callback);
        }

        public void RequestAsyncReadback(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, mipIndex, callback);
        }

        public void RequestAsyncReadback(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, mipIndex, dstFormat, callback);
        }

        public void RequestAsyncReadback(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, mipIndex, dstFormat, callback);
        }

        public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth,
            Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, mipIndex, x, width, y, height, z, depth, callback);
        }

        public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth,
            TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
        }

        public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth,
            GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback)
        {
            _commandBuffer.RequestAsyncReadback(src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, int size, int offset,
            Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, size, offset, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, mipIndex, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat,
            Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, mipIndex, dstFormat, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat,
            Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, mipIndex, dstFormat, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y,
            int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, mipIndex, x, width, y, height, z, depth, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y,
            int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
        }

        public void RequestAsyncReadbackIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y,
            int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) where T : struct
        {
            _commandBuffer.RequestAsyncReadbackIntoNativeArray(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
        }

        public void SetInvertCulling(bool invertCulling)
        {
            _commandBuffer.SetInvertCulling(invertCulling);
        }

        public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val)
        {
            _commandBuffer.SetComputeFloatParam(computeShader, nameID, val);
        }

        public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val)
        {
            _commandBuffer.SetComputeIntParam(computeShader, nameID, val);
        }

        public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val)
        {
            _commandBuffer.SetComputeVectorParam(computeShader, nameID, val);
        }

        public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values)
        {
            _commandBuffer.SetComputeVectorArrayParam(computeShader, nameID, values);
        }

        public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val)
        {
            _commandBuffer.SetComputeMatrixParam(computeShader, nameID, val);
        }

        public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values)
        {
            _commandBuffer.SetComputeMatrixArrayParam(computeShader, nameID, values);
        }

        public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
        {
            _commandBuffer.SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer);
        }

        public void SetRayTracingShaderPass(RayTracingShader rayTracingShader, string passName)
        {
            _commandBuffer.SetRayTracingShaderPass(rayTracingShader, passName);
        }

        public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes)
        {
            _commandBuffer.CopyCounterValue(src, dst, dstOffsetBytes);
        }

        public void Clear()
        {
            _commandBuffer.Clear();
        }

        public void ClearRandomWriteTargets()
        {
            _commandBuffer.ClearRandomWriteTargets();
        }

        public void SetViewport(Rect pixelRect)
        {
            _commandBuffer.SetViewport(pixelRect);
        }

        public void EnableScissorRect(Rect scissor)
        {
            _commandBuffer.EnableScissorRect(scissor);
        }

        public void DisableScissorRect()
        {
            _commandBuffer.DisableScissorRect();
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format,
            int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format,
            int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite, memorylessMode);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format,
            int antiAliasing, bool enableRandomWrite)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format,
            int antiAliasing)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, antiAliasing);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format,
            RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode,
            bool useDynamicScale)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode, useDynamicScale);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format,
            RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite, memorylessMode);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format,
            RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format,
            RenderTextureReadWrite readWrite, int antiAliasing)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format,
            RenderTextureReadWrite readWrite)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer, filter);
        }

        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height, depthBuffer);
        }

        public void GetTemporaryRT(int nameID, int width, int height)
        {
            _commandBuffer.GetTemporaryRT(nameID, width, height);
        }

        public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
        {
            _commandBuffer.GetTemporaryRT(nameID, desc, filter);
        }

        public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc)
        {
            _commandBuffer.GetTemporaryRT(nameID, desc);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            GraphicsFormat format, int antiAliasing, bool enableRandomWrite, bool useDynamicScale)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite, useDynamicScale);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            GraphicsFormat format, int antiAliasing, bool enableRandomWrite)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            GraphicsFormat format, int antiAliasing)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, antiAliasing);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            GraphicsFormat format)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            RenderTextureFormat format, RenderTextureReadWrite readWrite)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format, readWrite);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter,
            RenderTextureFormat format)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter, format);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer, FilterMode filter)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer, filter);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices, int depthBuffer)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices, depthBuffer);
        }

        public void GetTemporaryRTArray(int nameID, int width, int height, int slices)
        {
            _commandBuffer.GetTemporaryRTArray(nameID, width, height, slices);
        }

        public void ReleaseTemporaryRT(int nameID)
        {
            _commandBuffer.ReleaseTemporaryRT(nameID);
        }

        public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
        {
            _commandBuffer.ClearRenderTarget(clearDepth, clearColor, backgroundColor, depth);
        }

        public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
        {
            _commandBuffer.ClearRenderTarget(clearDepth, clearColor, backgroundColor);
        }

        public void SetGlobalFloat(int nameID, float value)
        {
            _commandBuffer.SetGlobalFloat(nameID, value);
        }

        public void SetGlobalInt(int nameID, int value)
        {
            _commandBuffer.SetGlobalInt(nameID, value);
        }

        public void SetGlobalVector(int nameID, Vector4 value)
        {
            _commandBuffer.SetGlobalVector(nameID, value);
        }

        public void SetGlobalColor(int nameID, Color value)
        {
            _commandBuffer.SetGlobalColor(nameID, value);
        }

        public void SetGlobalMatrix(int nameID, Matrix4x4 value)
        {
            _commandBuffer.SetGlobalMatrix(nameID, value);
        }

        public void EnableShaderKeyword(string keyword)
        {
            _commandBuffer.EnableShaderKeyword(keyword);
        }

        public void DisableShaderKeyword(string keyword)
        {
            _commandBuffer.DisableShaderKeyword(keyword);
        }

        public void SetViewMatrix(Matrix4x4 view)
        {
            _commandBuffer.SetViewMatrix(view);
        }

        public void SetProjectionMatrix(Matrix4x4 proj)
        {
            _commandBuffer.SetProjectionMatrix(proj);
        }

        public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
        {
            _commandBuffer.SetViewProjectionMatrices(view, proj);
        }

        public void SetGlobalDepthBias(float bias, float slopeBias)
        {
            _commandBuffer.SetGlobalDepthBias(bias, slopeBias);
        }

        public void SetExecutionFlags(CommandBufferExecutionFlags flags)
        {
            _commandBuffer.SetExecutionFlags(flags);
        }

        public void SetGlobalFloatArray(int nameID, float[] values)
        {
            _commandBuffer.SetGlobalFloatArray(nameID, values);
        }

        public void SetGlobalVectorArray(int nameID, Vector4[] values)
        {
            _commandBuffer.SetGlobalVectorArray(nameID, values);
        }

        public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values)
        {
            _commandBuffer.SetGlobalMatrixArray(nameID, values);
        }

        public void SetGlobalBuffer(int nameID, ComputeBuffer value)
        {
            _commandBuffer.SetGlobalBuffer(nameID, value);
        }

        public void BeginSample(string name)
        {
            _commandBuffer.BeginSample(name);
        }

        public void EndSample(string name)
        {
            _commandBuffer.EndSample(name);
        }

        public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size)
        {
            _commandBuffer.SetGlobalConstantBuffer(buffer, nameID, offset, size);
        }

        public void IncrementUpdateCount(RenderTargetIdentifier dest)
        {
            _commandBuffer.IncrementUpdateCount(dest);
        }

        public void SetInstanceMultiplier(uint multiplier)
        {
            _commandBuffer.SetInstanceMultiplier(multiplier);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt)
        {
            _commandBuffer.SetRenderTarget(rt);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
        {
            _commandBuffer.SetRenderTarget(rt, loadAction, storeAction);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction,
            RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction,
            RenderBufferStoreAction depthStoreAction)
        {
            _commandBuffer.SetRenderTarget(rt, colorLoadAction, colorStoreAction, depthLoadAction, depthStoreAction);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
        {
            _commandBuffer.SetRenderTarget(rt, mipLevel);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
        {
            _commandBuffer.SetRenderTarget(rt, mipLevel, cubemapFace);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
        {
            _commandBuffer.SetRenderTarget(rt, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
        {
            _commandBuffer.SetRenderTarget(color, depth);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
        {
            _commandBuffer.SetRenderTarget(color, depth, mipLevel);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
        {
            _commandBuffer.SetRenderTarget(color, depth, mipLevel, cubemapFace);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace,
            int depthSlice)
        {
            _commandBuffer.SetRenderTarget(color, depth, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction,
            RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction,
            RenderBufferStoreAction depthStoreAction)
        {
            _commandBuffer.SetRenderTarget(color, colorLoadAction, colorStoreAction, depth, depthLoadAction, depthStoreAction);
        }

        public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
        {
            _commandBuffer.SetRenderTarget(colors, depth);
        }

        public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel,
            CubemapFace cubemapFace, int depthSlice)
        {
            _commandBuffer.SetRenderTarget(colors, depth, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice)
        {
            _commandBuffer.SetRenderTarget(binding, mipLevel, cubemapFace, depthSlice);
        }

        public void SetRenderTarget(RenderTargetBinding binding)
        {
            _commandBuffer.SetRenderTarget(binding);
        }

        public void Release()
        {
            _commandBuffer.Release();
        }

        public GraphicsFence CreateAsyncGraphicsFence()
        {
            return _commandBuffer.CreateAsyncGraphicsFence();
        }

        public GraphicsFence CreateAsyncGraphicsFence(SynchronisationStage stage)
        {
            return _commandBuffer.CreateAsyncGraphicsFence(stage);
        }

        public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
        {
            return _commandBuffer.CreateGraphicsFence(fenceType, stage);
        }

        public void WaitOnAsyncGraphicsFence(GraphicsFence fence)
        {
            _commandBuffer.WaitOnAsyncGraphicsFence(fence);
        }

        public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage)
        {
            _commandBuffer.WaitOnAsyncGraphicsFence(fence, stage);
        }

        public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage)
        {
            _commandBuffer.WaitOnAsyncGraphicsFence(fence, stage);
        }

        public void SetComputeFloatParam(ComputeShader computeShader, string name, float val)
        {
            _commandBuffer.SetComputeFloatParam(computeShader, name, val);
        }

        public void SetComputeIntParam(ComputeShader computeShader, string name, int val)
        {
            _commandBuffer.SetComputeIntParam(computeShader, name, val);
        }

        public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
        {
            _commandBuffer.SetComputeVectorParam(computeShader, name, val);
        }

        public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values)
        {
            _commandBuffer.SetComputeVectorArrayParam(computeShader, name, values);
        }

        public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val)
        {
            _commandBuffer.SetComputeMatrixParam(computeShader, name, val);
        }

        public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values)
        {
            _commandBuffer.SetComputeMatrixArrayParam(computeShader, name, values);
        }

        public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
        {
            _commandBuffer.SetComputeFloatParams(computeShader, name, values);
        }

        public void SetComputeFloatParams(ComputeShader computeShader, int nameID, params float[] values)
        {
            _commandBuffer.SetComputeFloatParams(computeShader, nameID, values);
        }

        public void SetComputeIntParams(ComputeShader computeShader, string name, params int[] values)
        {
            _commandBuffer.SetComputeIntParams(computeShader, name, values);
        }

        public void SetComputeIntParams(ComputeShader computeShader, int nameID, params int[] values)
        {
            _commandBuffer.SetComputeIntParams(computeShader, nameID, values);
        }

        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
        {
            _commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, name, rt);
        }

        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt)
        {
            _commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt);
        }

        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt,
            int mipLevel)
        {
            _commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, name, rt, mipLevel);
        }

        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt,
            int mipLevel)
        {
            _commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt, mipLevel);
        }

        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt,
            int mipLevel, RenderTextureSubElement element)
        {
            _commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, name, rt, mipLevel, element);
        }

        public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt,
            int mipLevel, RenderTextureSubElement element)
        {
            _commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt, mipLevel, element);
        }

        public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer)
        {
            _commandBuffer.SetComputeBufferParam(computeShader, kernelIndex, name, buffer);
        }

        public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY,
            int threadGroupsZ)
        {
            _commandBuffer.DispatchCompute(computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
        }

        public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
        {
            _commandBuffer.DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset);
        }

        public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure)
        {
            _commandBuffer.BuildRayTracingAccelerationStructure(accelerationStructure);
        }

        public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name,
            RayTracingAccelerationStructure rayTracingAccelerationStructure)
        {
            _commandBuffer.SetRayTracingAccelerationStructure(rayTracingShader, name, rayTracingAccelerationStructure);
        }

        public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID,
            RayTracingAccelerationStructure rayTracingAccelerationStructure)
        {
            _commandBuffer.SetRayTracingAccelerationStructure(rayTracingShader, nameID, rayTracingAccelerationStructure);
        }

        public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer)
        {
            _commandBuffer.SetRayTracingBufferParam(rayTracingShader, name, buffer);
        }

        public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer)
        {
            _commandBuffer.SetRayTracingBufferParam(rayTracingShader, nameID, buffer);
        }

        public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt)
        {
            _commandBuffer.SetRayTracingTextureParam(rayTracingShader, name, rt);
        }

        public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt)
        {
            _commandBuffer.SetRayTracingTextureParam(rayTracingShader, nameID, rt);
        }

        public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val)
        {
            _commandBuffer.SetRayTracingFloatParam(rayTracingShader, name, val);
        }

        public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val)
        {
            _commandBuffer.SetRayTracingFloatParam(rayTracingShader, nameID, val);
        }

        public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, params float[] values)
        {
            _commandBuffer.SetRayTracingFloatParams(rayTracingShader, name, values);
        }

        public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, params float[] values)
        {
            _commandBuffer.SetRayTracingFloatParams(rayTracingShader, nameID, values);
        }

        public void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val)
        {
            _commandBuffer.SetRayTracingIntParam(rayTracingShader, name, val);
        }

        public void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val)
        {
            _commandBuffer.SetRayTracingIntParam(rayTracingShader, nameID, val);
        }

        public void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, params int[] values)
        {
            _commandBuffer.SetRayTracingIntParams(rayTracingShader, name, values);
        }

        public void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, params int[] values)
        {
            _commandBuffer.SetRayTracingIntParams(rayTracingShader, nameID, values);
        }

        public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val)
        {
            _commandBuffer.SetRayTracingVectorParam(rayTracingShader, name, val);
        }

        public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val)
        {
            _commandBuffer.SetRayTracingVectorParam(rayTracingShader, nameID, val);
        }

        public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, params Vector4[] values)
        {
            _commandBuffer.SetRayTracingVectorArrayParam(rayTracingShader, name, values);
        }

        public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, params Vector4[] values)
        {
            _commandBuffer.SetRayTracingVectorArrayParam(rayTracingShader, nameID, values);
        }

        public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val)
        {
            _commandBuffer.SetRayTracingMatrixParam(rayTracingShader, name, val);
        }

        public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val)
        {
            _commandBuffer.SetRayTracingMatrixParam(rayTracingShader, nameID, val);
        }

        public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, params Matrix4x4[] values)
        {
            _commandBuffer.SetRayTracingMatrixArrayParam(rayTracingShader, name, values);
        }

        public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, params Matrix4x4[] values)
        {
            _commandBuffer.SetRayTracingMatrixArrayParam(rayTracingShader, nameID, values);
        }

        public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth,
            Camera camera = null)
        {
            _commandBuffer.DispatchRays(rayTracingShader, rayGenName, width, height, depth, camera);
        }

        public void GenerateMips(RenderTexture rt)
        {
            _commandBuffer.GenerateMips(rt);
        }

        public void ResolveAntiAliasedSurface(RenderTexture rt, RenderTexture target = null)
        {
            _commandBuffer.ResolveAntiAliasedSurface(rt, target);
        }

        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass,
            MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
        }

        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
        {
            _commandBuffer.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass);
        }

        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
        {
            _commandBuffer.DrawMesh(mesh, matrix, material, submeshIndex);
        }

        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
        {
            _commandBuffer.DrawMesh(mesh, matrix, material);
        }

        public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
        {
            _commandBuffer.DrawRenderer(renderer, material, submeshIndex, shaderPass);
        }

        public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
        {
            _commandBuffer.DrawRenderer(renderer, material, submeshIndex);
        }

        public void DrawRenderer(Renderer renderer, Material material)
        {
            _commandBuffer.DrawRenderer(renderer, material);
        }

        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount,
            int instanceCount, MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
        }

        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount,
            int instanceCount)
        {
            _commandBuffer.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount);
        }

        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
        {
            _commandBuffer.DrawProcedural(matrix, material, shaderPass, topology, vertexCount);
        }

        public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass,
            MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount, properties);
        }

        public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass,
            MeshTopology topology, int indexCount, int instanceCount)
        {
            _commandBuffer.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount, instanceCount);
        }

        public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass,
            MeshTopology topology, int indexCount)
        {
            _commandBuffer.DrawProcedural(indexBuffer, matrix, material, shaderPass, topology, indexCount);
        }

        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology,
            ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology,
            ComputeBuffer bufferWithArgs, int argsOffset)
        {
            _commandBuffer.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
        }

        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology,
            ComputeBuffer bufferWithArgs)
        {
            _commandBuffer.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs);
        }

        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass,
            MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass,
            MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
        {
            _commandBuffer.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset);
        }

        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass,
            MeshTopology topology, ComputeBuffer bufferWithArgs)
        {
            _commandBuffer.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs);
        }

        public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count,
            MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
        }

        public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count)
        {
            _commandBuffer.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count);
        }

        public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices)
        {
            _commandBuffer.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices);
        }

        public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count,
            MaterialPropertyBlock properties = null)
        {
            _commandBuffer.DrawMeshInstancedProcedural(mesh, submeshIndex, material, shaderPass, count, properties);
        }

        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass,
            ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
        {
            _commandBuffer.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
        }

        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass,
            ComputeBuffer bufferWithArgs, int argsOffset)
        {
            _commandBuffer.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset);
        }

        public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass,
            ComputeBuffer bufferWithArgs)
        {
            _commandBuffer.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs);
        }

        public void DrawOcclusionMesh(RectInt normalizedCamViewport)
        {
            _commandBuffer.DrawOcclusionMesh(normalizedCamViewport);
        }

        public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt)
        {
            _commandBuffer.SetRandomWriteTarget(index, rt);
        }

        public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue)
        {
            _commandBuffer.SetRandomWriteTarget(index, buffer, preserveCounterValue);
        }

        public void SetRandomWriteTarget(int index, ComputeBuffer buffer)
        {
            _commandBuffer.SetRandomWriteTarget(index, buffer);
        }

        public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
        {
            _commandBuffer.CopyTexture(src, dst);
        }

        public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
        {
            _commandBuffer.CopyTexture(src, srcElement, dst, dstElement);
        }

        public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement,
            int dstMip)
        {
            _commandBuffer.CopyTexture(src, srcElement, srcMip, dst, dstElement, dstMip);
        }

        public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth,
            int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
        {
            _commandBuffer.CopyTexture(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest)
        {
            _commandBuffer.Blit(source, dest);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset)
        {
            _commandBuffer.Blit(source, dest, scale, offset);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
        {
            _commandBuffer.Blit(source, dest, mat);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
        {
            _commandBuffer.Blit(source, dest, mat, pass);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
        {
            _commandBuffer.Blit(source, dest);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset)
        {
            _commandBuffer.Blit(source, dest, scale, offset);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
        {
            _commandBuffer.Blit(source, dest, mat);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
        {
            _commandBuffer.Blit(source, dest, mat, pass);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice)
        {
            _commandBuffer.Blit(source, dest, sourceDepthSlice, destDepthSlice);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset,
            int sourceDepthSlice, int destDepthSlice)
        {
            _commandBuffer.Blit(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, int destDepthSlice)
        {
            _commandBuffer.Blit(source, dest, mat, pass, destDepthSlice);
        }

        public void SetGlobalFloat(string name, float value)
        {
            _commandBuffer.SetGlobalFloat(name, value);
        }

        public void SetGlobalInt(string name, int value)
        {
            _commandBuffer.SetGlobalInt(name, value);
        }

        public void SetGlobalVector(string name, Vector4 value)
        {
            _commandBuffer.SetGlobalVector(name, value);
        }

        public void SetGlobalColor(string name, Color value)
        {
            _commandBuffer.SetGlobalColor(name, value);
        }

        public void SetGlobalMatrix(string name, Matrix4x4 value)
        {
            _commandBuffer.SetGlobalMatrix(name, value);
        }

        public void SetGlobalFloatArray(string propertyName, List<float> values)
        {
            _commandBuffer.SetGlobalFloatArray(propertyName, values);
        }

        public void SetGlobalFloatArray(int nameID, List<float> values)
        {
            _commandBuffer.SetGlobalFloatArray(nameID, values);
        }

        public void SetGlobalFloatArray(string propertyName, float[] values)
        {
            _commandBuffer.SetGlobalFloatArray(propertyName, values);
        }

        public void SetGlobalVectorArray(string propertyName, List<Vector4> values)
        {
            _commandBuffer.SetGlobalVectorArray(propertyName, values);
        }

        public void SetGlobalVectorArray(int nameID, List<Vector4> values)
        {
            _commandBuffer.SetGlobalVectorArray(nameID, values);
        }

        public void SetGlobalVectorArray(string propertyName, Vector4[] values)
        {
            _commandBuffer.SetGlobalVectorArray(propertyName, values);
        }

        public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values)
        {
            _commandBuffer.SetGlobalMatrixArray(propertyName, values);
        }

        public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
        {
            _commandBuffer.SetGlobalMatrixArray(nameID, values);
        }

        public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values)
        {
            _commandBuffer.SetGlobalMatrixArray(propertyName, values);
        }

        public void SetGlobalTexture(string name, RenderTargetIdentifier value)
        {
            _commandBuffer.SetGlobalTexture(name, value);
        }

        public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
        {
            _commandBuffer.SetGlobalTexture(nameID, value);
        }

        public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element)
        {
            _commandBuffer.SetGlobalTexture(name, value, element);
        }

        public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
        {
            _commandBuffer.SetGlobalTexture(nameID, value, element);
        }

        public void SetGlobalBuffer(string name, ComputeBuffer value)
        {
            _commandBuffer.SetGlobalBuffer(name, value);
        }

        public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
        {
            _commandBuffer.SetShadowSamplingMode(shadowmap, mode);
        }

        public void SetSinglePassStereo(SinglePassStereoMode mode)
        {
            _commandBuffer.SetSinglePassStereo(mode);
        }

        public void IssuePluginEvent(IntPtr callback, int eventID)
        {
            _commandBuffer.IssuePluginEvent(callback, eventID);
        }

        public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data)
        {
            _commandBuffer.IssuePluginEventAndData(callback, eventID, data);
        }

        public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest,
            uint commandParam, uint commandFlags)
        {
            _commandBuffer.IssuePluginCustomBlit(callback, command, source, dest, commandParam, commandFlags);
        }

        public void IssuePluginCustomTextureUpdate(IntPtr callback, Texture targetTexture, uint userData)
        {
            _commandBuffer.IssuePluginCustomTextureUpdate(callback, targetTexture, userData);
        }

        public void IssuePluginCustomTextureUpdateV1(IntPtr callback, Texture targetTexture, uint userData)
        {
            _commandBuffer.IssuePluginCustomTextureUpdateV1(callback, targetTexture, userData);
        }

        public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData)
        {
            _commandBuffer.IssuePluginCustomTextureUpdateV2(callback, targetTexture, userData);
        }

        public GraphicsFence CreateGPUFence(SynchronisationStage stage)
        {
            return _commandBuffer.CreateAsyncGraphicsFence(stage);
        }

        public GraphicsFence CreateGPUFence()
        {
            return _commandBuffer.CreateAsyncGraphicsFence();
        }

        public void WaitOnGPUFence(GraphicsFence fence, SynchronisationStage stage)
        {
            _commandBuffer.WaitOnAsyncGraphicsFence(fence, stage);
        }

        public void WaitOnGPUFence(GraphicsFence fence)
        {
            _commandBuffer.WaitOnAsyncGraphicsFence(fence);
        }

        public string name
        {
            get => _commandBuffer.name;
            set => _commandBuffer.name = value;
        }

        public int sizeInBytes => _commandBuffer.sizeInBytes;

        public static implicit operator CommandBuffer(TempCommandBuffer cmd)
        {
            return cmd._commandBuffer;
        }

        public TempCommandBuffer(string name)
        {
            _commandBuffer = CommandBufferPool.Get(name);
        }

        public void Dispose()
        {
            CommandBufferPool.Release(_commandBuffer);
        }
    }
}