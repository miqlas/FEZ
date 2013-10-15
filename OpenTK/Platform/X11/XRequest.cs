﻿// Type: OpenTK.Platform.X11.XRequest
// Assembly: OpenTK, Version=1.1.0.0, Culture=neutral, PublicKeyToken=bad199fe84eb3df4
// MVID: FE2CFFE8-B942-430E-8C15-E783DB6F0AD6
// Assembly location: F:\Program Files (x86)\FEZ\OpenTK.dll

namespace OpenTK.Platform.X11
{
  internal enum XRequest : byte
  {
    X_CreateWindow = (byte) 1,
    X_ChangeWindowAttributes = (byte) 2,
    X_GetWindowAttributes = (byte) 3,
    X_DestroyWindow = (byte) 4,
    X_DestroySubwindows = (byte) 5,
    X_ChangeSaveSet = (byte) 6,
    X_ReparentWindow = (byte) 7,
    X_MapWindow = (byte) 8,
    X_MapSubwindows = (byte) 9,
    X_UnmapWindow = (byte) 10,
    X_UnmapSubwindows = (byte) 11,
    X_ConfigureWindow = (byte) 12,
    X_CirculateWindow = (byte) 13,
    X_GetGeometry = (byte) 14,
    X_QueryTree = (byte) 15,
    X_InternAtom = (byte) 16,
    X_GetAtomName = (byte) 17,
    X_ChangeProperty = (byte) 18,
    X_DeleteProperty = (byte) 19,
    X_GetProperty = (byte) 20,
    X_ListProperties = (byte) 21,
    X_SetSelectionOwner = (byte) 22,
    X_GetSelectionOwner = (byte) 23,
    X_ConvertSelection = (byte) 24,
    X_SendEvent = (byte) 25,
    X_GrabPointer = (byte) 26,
    X_UngrabPointer = (byte) 27,
    X_GrabButton = (byte) 28,
    X_UngrabButton = (byte) 29,
    X_ChangeActivePointerGrab = (byte) 30,
    X_GrabKeyboard = (byte) 31,
    X_UngrabKeyboard = (byte) 32,
    X_GrabKey = (byte) 33,
    X_UngrabKey = (byte) 34,
    X_AllowEvents = (byte) 35,
    X_GrabServer = (byte) 36,
    X_UngrabServer = (byte) 37,
    X_QueryPointer = (byte) 38,
    X_GetMotionEvents = (byte) 39,
    X_TranslateCoords = (byte) 40,
    X_WarpPointer = (byte) 41,
    X_SetInputFocus = (byte) 42,
    X_GetInputFocus = (byte) 43,
    X_QueryKeymap = (byte) 44,
    X_OpenFont = (byte) 45,
    X_CloseFont = (byte) 46,
    X_QueryFont = (byte) 47,
    X_QueryTextExtents = (byte) 48,
    X_ListFonts = (byte) 49,
    X_ListFontsWithInfo = (byte) 50,
    X_SetFontPath = (byte) 51,
    X_GetFontPath = (byte) 52,
    X_CreatePixmap = (byte) 53,
    X_FreePixmap = (byte) 54,
    X_CreateGC = (byte) 55,
    X_ChangeGC = (byte) 56,
    X_CopyGC = (byte) 57,
    X_SetDashes = (byte) 58,
    X_SetClipRectangles = (byte) 59,
    X_FreeGC = (byte) 60,
    X_ClearArea = (byte) 61,
    X_CopyArea = (byte) 62,
    X_CopyPlane = (byte) 63,
    X_PolyPoint = (byte) 64,
    X_PolyLine = (byte) 65,
    X_PolySegment = (byte) 66,
    X_PolyRectangle = (byte) 67,
    X_PolyArc = (byte) 68,
    X_FillPoly = (byte) 69,
    X_PolyFillRectangle = (byte) 70,
    X_PolyFillArc = (byte) 71,
    X_PutImage = (byte) 72,
    X_GetImage = (byte) 73,
    X_PolyText8 = (byte) 74,
    X_PolyText16 = (byte) 75,
    X_ImageText8 = (byte) 76,
    X_ImageText16 = (byte) 77,
    X_CreateColormap = (byte) 78,
    X_FreeColormap = (byte) 79,
    X_CopyColormapAndFree = (byte) 80,
    X_InstallColormap = (byte) 81,
    X_UninstallColormap = (byte) 82,
    X_ListInstalledColormaps = (byte) 83,
    X_AllocColor = (byte) 84,
    X_AllocNamedColor = (byte) 85,
    X_AllocColorCells = (byte) 86,
    X_AllocColorPlanes = (byte) 87,
    X_FreeColors = (byte) 88,
    X_StoreColors = (byte) 89,
    X_StoreNamedColor = (byte) 90,
    X_QueryColors = (byte) 91,
    X_LookupColor = (byte) 92,
    X_CreateCursor = (byte) 93,
    X_CreateGlyphCursor = (byte) 94,
    X_FreeCursor = (byte) 95,
    X_RecolorCursor = (byte) 96,
    X_QueryBestSize = (byte) 97,
    X_QueryExtension = (byte) 98,
    X_ListExtensions = (byte) 99,
    X_ChangeKeyboardMapping = (byte) 100,
    X_GetKeyboardMapping = (byte) 101,
    X_ChangeKeyboardControl = (byte) 102,
    X_GetKeyboardControl = (byte) 103,
    X_Bell = (byte) 104,
    X_ChangePointerControl = (byte) 105,
    X_GetPointerControl = (byte) 106,
    X_SetScreenSaver = (byte) 107,
    X_GetScreenSaver = (byte) 108,
    X_ChangeHosts = (byte) 109,
    X_ListHosts = (byte) 110,
    X_SetAccessControl = (byte) 111,
    X_SetCloseDownMode = (byte) 112,
    X_KillClient = (byte) 113,
    X_RotateProperties = (byte) 114,
    X_ForceScreenSaver = (byte) 115,
    X_SetPointerMapping = (byte) 116,
    X_GetPointerMapping = (byte) 117,
    X_SetModifierMapping = (byte) 118,
    X_GetModifierMapping = (byte) 119,
    X_NoOperation = (byte) 127,
  }
}
