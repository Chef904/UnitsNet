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
                        
namespace UnitsNet.NumberExtensions.NumberToElectricPotential
{
    /// <summary>
    /// A number to ElectricPotential Extensions
    /// </summary>
    public static class NumberToElectricPotentialExtensions
    {
        /// <inheritdoc cref="ElectricPotential.FromKilovolts(UnitsNet.QuantityValue)" />
        public static ElectricPotential Kilovolts<T>(this T value) =>
            ElectricPotential.FromKilovolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(UnitsNet.QuantityValue)" />
        public static ElectricPotential Megavolts<T>(this T value) =>
            ElectricPotential.FromMegavolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(UnitsNet.QuantityValue)" />
        public static ElectricPotential Microvolts<T>(this T value) =>
            ElectricPotential.FromMicrovolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(UnitsNet.QuantityValue)" />
        public static ElectricPotential Millivolts<T>(this T value) =>
            ElectricPotential.FromMillivolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromVolts(UnitsNet.QuantityValue)" />
        public static ElectricPotential Volts<T>(this T value) =>
            ElectricPotential.FromVolts(Convert.ToDouble(value));

    }
}
