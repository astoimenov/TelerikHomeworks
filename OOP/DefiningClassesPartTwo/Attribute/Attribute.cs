﻿/*11. Create a [Version] attribute that can be applied to structures, classes, interfaces,
 *    enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
 *    Apply the version attribute to a sample class and display its version at runtime.*/

using System;

[VersionAttribute("5.11")]

class Attribute
{
    static void Main()
    {
        object[] versionAttributes = typeof(Attribute).GetCustomAttributes(typeof(VersionAttribute), false);

        Console.WriteLine("[Version] {0}", versionAttributes[0]);
    }
}