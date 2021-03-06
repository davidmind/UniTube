﻿using System;

namespace UniTube.Controls
{
    /// <summary>
    /// Provides data for the <see cref="HamburgerMenu.DisplayModeChanged"/> event.
    /// </summary>
    public sealed class HamburgerMenuDisplayModeChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the new display mode.
        /// </summary>
        public HamburgerMenuDisplayMode DisplayMode { get; internal set; }
    }
}
