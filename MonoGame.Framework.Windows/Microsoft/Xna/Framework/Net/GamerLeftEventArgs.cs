﻿// Type: Microsoft.Xna.Framework.Net.GamerLeftEventArgs
// Assembly: MonoGame.Framework.Windows, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2107839-320D-467B-B82A-28CB452CC584
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.Windows.dll

using System;

namespace Microsoft.Xna.Framework.Net
{
  public class GamerLeftEventArgs : EventArgs
  {
    private NetworkGamer gamer;

    public NetworkGamer Gamer
    {
      get
      {
        return this.gamer;
      }
    }

    public GamerLeftEventArgs(NetworkGamer aGamer)
    {
      this.gamer = aGamer;
    }
  }
}
