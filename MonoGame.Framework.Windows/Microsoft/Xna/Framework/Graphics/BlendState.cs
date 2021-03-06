﻿// Type: Microsoft.Xna.Framework.Graphics.BlendState
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using Microsoft.Xna.Framework;
using OpenTK.Graphics.OpenGL;

namespace Microsoft.Xna.Framework.Graphics
{
  public class BlendState : GraphicsResource
  {
    public static readonly BlendState Additive = new BlendState()
    {
      ColorSourceBlend = Blend.SourceAlpha,
      AlphaSourceBlend = Blend.SourceAlpha,
      ColorDestinationBlend = Blend.One,
      AlphaDestinationBlend = Blend.One
    };
    public static readonly BlendState AlphaBlend = new BlendState()
    {
      ColorSourceBlend = Blend.One,
      AlphaSourceBlend = Blend.One,
      ColorDestinationBlend = Blend.InverseSourceAlpha,
      AlphaDestinationBlend = Blend.InverseSourceAlpha
    };
    public static readonly BlendState NonPremultiplied = new BlendState()
    {
      ColorSourceBlend = Blend.SourceAlpha,
      AlphaSourceBlend = Blend.SourceAlpha,
      ColorDestinationBlend = Blend.InverseSourceAlpha,
      AlphaDestinationBlend = Blend.InverseSourceAlpha
    };
    public static readonly BlendState Opaque = new BlendState()
    {
      ColorSourceBlend = Blend.One,
      AlphaSourceBlend = Blend.One,
      ColorDestinationBlend = Blend.Zero,
      AlphaDestinationBlend = Blend.Zero
    };

    public BlendFunction AlphaBlendFunction { get; set; }

    public Blend AlphaDestinationBlend { get; set; }

    public Blend AlphaSourceBlend { get; set; }

    public Color BlendFactor { get; set; }

    public BlendFunction ColorBlendFunction { get; set; }

    public Blend ColorDestinationBlend { get; set; }

    public Blend ColorSourceBlend { get; set; }

    public ColorWriteChannels ColorWriteChannels { get; set; }

    public ColorWriteChannels ColorWriteChannels1 { get; set; }

    public ColorWriteChannels ColorWriteChannels2 { get; set; }

    public ColorWriteChannels ColorWriteChannels3 { get; set; }

    public int MultiSampleMask { get; set; }

    static BlendState()
    {
    }

    public BlendState()
    {
      this.AlphaBlendFunction = BlendFunction.Add;
      this.AlphaDestinationBlend = Blend.Zero;
      this.AlphaSourceBlend = Blend.One;
      this.BlendFactor = Color.White;
      this.ColorBlendFunction = BlendFunction.Add;
      this.ColorDestinationBlend = Blend.Zero;
      this.ColorSourceBlend = Blend.One;
      this.ColorWriteChannels = ColorWriteChannels.All;
      this.ColorWriteChannels1 = ColorWriteChannels.All;
      this.ColorWriteChannels2 = ColorWriteChannels.All;
      this.ColorWriteChannels3 = ColorWriteChannels.All;
      this.MultiSampleMask = int.MaxValue;
    }

    public override string ToString()
    {
      return string.Format("{0}.{1}", (object) base.ToString(), this != BlendState.Additive ? (this != BlendState.AlphaBlend ? (this != BlendState.NonPremultiplied ? (object) "Opaque" : (object) "NonPremultiplied") : (object) "AlphaBlend") : (object) "Additive");
    }

    internal void ApplyState(GraphicsDevice device)
    {
      GL.Enable(EnableCap.Blend);
      GL.ColorMask((this.ColorWriteChannels & ColorWriteChannels.Red) == ColorWriteChannels.Red, (this.ColorWriteChannels & ColorWriteChannels.Green) == ColorWriteChannels.Green, (this.ColorWriteChannels & ColorWriteChannels.Blue) == ColorWriteChannels.Blue, (this.ColorWriteChannels & ColorWriteChannels.Alpha) == ColorWriteChannels.Alpha);
      GL.BlendEquation(GraphicsExtensions.GetBlendEquationMode(this.ColorBlendFunction));
      GL.BlendFunc(GraphicsExtensions.GetBlendFactorSrc(this.ColorSourceBlend), GraphicsExtensions.GetBlendFactorDest(this.ColorDestinationBlend));
    }
  }
}
