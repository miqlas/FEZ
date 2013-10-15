﻿// Type: Microsoft.Xna.Framework.Net.QualityOfService
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using System;

namespace Microsoft.Xna.Framework.Net
{
  public class QualityOfService
  {
    public TimeSpan AverageRoundtripTime
    {
      get
      {
        return TimeSpan.MinValue;
      }
    }

    public int BytesPerSecondDownstream
    {
      get
      {
        return 0;
      }
    }

    public int BytesPerSecondUpstream
    {
      get
      {
        return 0;
      }
    }

    public bool IsAvailable
    {
      get
      {
        return false;
      }
    }

    public TimeSpan MinimumRoundtripTime
    {
      get
      {
        return TimeSpan.MinValue;
      }
    }
  }
}