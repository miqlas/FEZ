﻿// Type: Newtonsoft.Json.Converters.IXmlDeclaration
// Assembly: Newtonsoft.Json, Version=4.5.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed
// MVID: DB013E7B-84E7-4AE6-A132-56DC73318C48
// Assembly location: F:\Program Files (x86)\FEZ\Newtonsoft.Json.dll

namespace Newtonsoft.Json.Converters
{
  internal interface IXmlDeclaration : IXmlNode
  {
    string Version { get; }

    string Encoding { get; set; }

    string Standalone { get; set; }
  }
}
