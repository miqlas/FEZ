﻿// Type: FezEngine.Effects.Structures.SemanticMappedVector3
// Assembly: FezEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 11F00D13-0150-47CC-B906-98B362969219
// Assembly location: F:\Program Files (x86)\FEZ\FezEngine.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FezEngine.Effects.Structures
{
  public class SemanticMappedVector3 : SemanticMappedParameter<Vector3>
  {
    public SemanticMappedVector3(EffectParameterCollection parent, string semanticName)
      : base(parent, semanticName)
    {
    }

    protected override void DoSet(Vector3 value)
    {
      this.parameter.SetValue(value);
      this.firstSet = false;
    }
  }
}
