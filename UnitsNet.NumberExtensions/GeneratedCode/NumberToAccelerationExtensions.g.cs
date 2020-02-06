﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
                        
namespace UnitsNet.NumberExtensions.NumberToAcceleration
{
    /// <summary>
    /// A number to Acceleration Extensions
    /// </summary>
    public static class NumberToAccelerationExtensions
    {
        /// <inheritdoc cref="Acceleration.FromCentimetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration CentimetersPerSecondSquared<T>(this T value) =>
            Acceleration.FromCentimetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromDecimetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration DecimetersPerSecondSquared<T>(this T value) =>
            Acceleration.FromDecimetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromFeetPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration FeetPerSecondSquared<T>(this T value) =>
            Acceleration.FromFeetPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromInchesPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration InchesPerSecondSquared<T>(this T value) =>
            Acceleration.FromInchesPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKilometersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration KilometersPerSecondSquared<T>(this T value) =>
            Acceleration.FromKilometersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKnotsPerHour(UnitsNet.QuantityValue)" />
        public static Acceleration KnotsPerHour<T>(this T value) =>
            Acceleration.FromKnotsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKnotsPerMinute(UnitsNet.QuantityValue)" />
        public static Acceleration KnotsPerMinute<T>(this T value) =>
            Acceleration.FromKnotsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKnotsPerSecond(UnitsNet.QuantityValue)" />
        public static Acceleration KnotsPerSecond<T>(this T value) =>
            Acceleration.FromKnotsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration MetersPerSecondSquared<T>(this T value) =>
            Acceleration.FromMetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMicrometersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration MicrometersPerSecondSquared<T>(this T value) =>
            Acceleration.FromMicrometersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMillimetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration MillimetersPerSecondSquared<T>(this T value) =>
            Acceleration.FromMillimetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromNanometersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration NanometersPerSecondSquared<T>(this T value) =>
            Acceleration.FromNanometersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromStandardGravity(UnitsNet.QuantityValue)" />
        public static Acceleration StandardGravity<T>(this T value) =>
            Acceleration.FromStandardGravity(Convert.ToDouble(value));

    }
}
