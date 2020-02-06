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
                        
namespace UnitsNet.NumberExtensions.NumberToElectricConductance
{
    /// <summary>
    /// A number to ElectricConductance Extensions
    /// </summary>
    public static class NumberToElectricConductanceExtensions
    {
        /// <inheritdoc cref="ElectricConductance.FromMicrosiemens(UnitsNet.QuantityValue)" />
        public static ElectricConductance Microsiemens<T>(this T value) =>
            ElectricConductance.FromMicrosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductance.FromMillisiemens(UnitsNet.QuantityValue)" />
        public static ElectricConductance Millisiemens<T>(this T value) =>
            ElectricConductance.FromMillisiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductance.FromSiemens(UnitsNet.QuantityValue)" />
        public static ElectricConductance Siemens<T>(this T value) =>
            ElectricConductance.FromSiemens(Convert.ToDouble(value));

    }
}
