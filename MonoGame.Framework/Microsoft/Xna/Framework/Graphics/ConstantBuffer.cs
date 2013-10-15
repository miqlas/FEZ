﻿// Type: Microsoft.Xna.Framework.Graphics.ConstantBuffer
// Assembly: MonoGame.Framework, Version=3.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 69677294-4E99-4B9C-B72B-CC2D8AA03B63
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.dll

using MonoGame.Utilities;
using OpenTK.Graphics.OpenGL;
using System;

namespace Microsoft.Xna.Framework.Graphics
{
  internal class ConstantBuffer : GraphicsResource
  {
    private int _program = -1;
    private readonly byte[] _buffer;
    private readonly int[] _parameters;
    private readonly int[] _offsets;
    private readonly string _name;
    private ulong _stateKey;
    private bool _dirty;
    private int _location;
    private static ConstantBuffer _lastConstantBufferApplied;

    internal int HashKey { get; private set; }

    static ConstantBuffer()
    {
    }

    public ConstantBuffer(ConstantBuffer cloneSource)
    {
      this.GraphicsDevice = cloneSource.GraphicsDevice;
      this._name = cloneSource._name;
      this._parameters = cloneSource._parameters;
      this._offsets = cloneSource._offsets;
      this._buffer = (byte[]) cloneSource._buffer.Clone();
      this.Initialize();
    }

    public ConstantBuffer(GraphicsDevice device, int sizeInBytes, int[] parameterIndexes, int[] parameterOffsets, string name)
    {
      this.GraphicsDevice = device;
      this._buffer = new byte[sizeInBytes];
      this._parameters = parameterIndexes;
      this._offsets = parameterOffsets;
      this._name = name;
      this.Initialize();
    }

    private void Initialize()
    {
      byte[] numArray = new byte[this._parameters.Length];
      for (int index = 0; index < this._parameters.Length; ++index)
        numArray[index] = (byte) (this._parameters[index] | this._offsets[index]);
      this.HashKey = Hash.ComputeHash(numArray);
    }

    internal void Clear()
    {
      this._program = -1;
    }

    private void SetData(int offset, int rows, int columns, int registers, object data)
    {
      if (registers > 0)
        rows = Math.Min(registers, rows);
      if (rows == 1 && columns == 1)
        Buffer.BlockCopy(!(data is float) ? (!(data is int) ? (Array) BitConverter.GetBytes(((float[]) data)[0]) : (Array) BitConverter.GetBytes((float) (int) data)) : (Array) BitConverter.GetBytes((float) data), 0, (Array) this._buffer, offset, 4);
      else if (rows == 1 || columns == 4)
      {
        int val2 = (data as Array).Length / columns;
        Buffer.BlockCopy(data as Array, 0, (Array) this._buffer, offset, Math.Min(rows, val2) * columns * 4);
      }
      else
      {
        Array src = data as Array;
        int val2 = src.Length / columns;
        int num = columns * 4;
        rows = Math.Min(rows, val2);
        for (int index = 0; index < rows; ++index)
          Buffer.BlockCopy(src, num * index, (Array) this._buffer, offset + 16 * index, columns * 4);
      }
    }

    private int SetParameter(int offset, EffectParameter param)
    {
      if (param.Data == null)
        return 0;
      int num;
      if (param.Elements.Count > 0)
      {
        num = param.RowCount * param.Elements.Count;
        this.SetData(offset, param.RowCount * param.Elements.Count, param.ColumnCount, 0, param.Data);
      }
      else
      {
        switch (param.ParameterType)
        {
          case EffectParameterType.Bool:
          case EffectParameterType.Int32:
          case EffectParameterType.Single:
            if (param.ParameterClass == EffectParameterClass.Matrix)
            {
              num = param.ColumnCount;
              this.SetData(offset, param.ColumnCount, param.RowCount, param.RegisterCount, param.Data);
              break;
            }
            else
            {
              num = param.RowCount;
              this.SetData(offset, param.RowCount, param.ColumnCount, param.RegisterCount, param.Data);
              break;
            }
          default:
            throw new NotImplementedException("Not supported!");
        }
      }
      return num;
    }

    public void Update(EffectParameterCollection parameters)
    {
      if (this._stateKey > EffectParameter.NextStateKey)
        this._stateKey = 0UL;
      for (int index1 = 0; index1 < this._parameters.Length; ++index1)
      {
        int index2 = this._parameters[index1];
        EffectParameter effectParameter = parameters[index2];
        if (effectParameter.StateKey >= this._stateKey)
        {
          int offset = this._offsets[index1];
          this._dirty = true;
          this.SetParameter(offset, effectParameter);
        }
      }
      this._stateKey = EffectParameter.NextStateKey;
    }

    public unsafe void Apply(GraphicsDevice device, int program)
    {
      if (this._program != program)
      {
        int uniformLocation = GL.GetUniformLocation(program, this._name);
        if (uniformLocation == -1)
          return;
        this._program = program;
        this._location = uniformLocation;
        this._dirty = true;
      }
      if (!object.ReferenceEquals((object) this, (object) ConstantBuffer._lastConstantBufferApplied))
        this._dirty = true;
      if (!this._dirty)
        return;
      fixed (byte* numPtr = this._buffer)
        GL.Uniform4(this._location, this._buffer.Length / 16, (float*) numPtr);
      this._dirty = false;
      ConstantBuffer._lastConstantBufferApplied = this;
    }
  }
}
