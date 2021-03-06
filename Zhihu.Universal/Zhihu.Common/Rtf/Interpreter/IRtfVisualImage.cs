﻿// -- FILE ------------------------------------------------------------------
// name       : IRtfVisualImage.cs
// project    : RTF Framelet
// created    : Leon Poyyayil - 2008.05.22
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland
// --------------------------------------------------------------------------

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace Itenso.Rtf
{

    // ------------------------------------------------------------------------
    public interface IRtfVisualImage : IRtfVisual
    {
        string ImportFileName { get; }
        // ----------------------------------------------------------------------
        RtfVisualImageFormat Format { get; }

        // ----------------------------------------------------------------------
        RtfTextAlignment Alignment { get; }

        // ----------------------------------------------------------------------
        int Width { get; }

        // ----------------------------------------------------------------------
        int Height { get; }

        // ----------------------------------------------------------------------
        int DesiredWidth { get; }

        // ----------------------------------------------------------------------
        int DesiredHeight { get; }

        // ----------------------------------------------------------------------
        int ScaleWidthPercent { get; }

        // ----------------------------------------------------------------------
        int ScaleHeightPercent { get; }

        // ----------------------------------------------------------------------
        string ImageDataHex { get; }

        // ----------------------------------------------------------------------
        byte[] ImageDataBinary { get; }

        // ----------------------------------------------------------------------
        BitmapImage ImageForDrawing { get; }

    } // interface IRtfVisualImage

} // namespace Itenso.Rtf
// -- EOF -------------------------------------------------------------------
