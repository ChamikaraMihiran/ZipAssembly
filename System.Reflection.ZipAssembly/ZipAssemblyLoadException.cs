// Copyright (c) 2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace System.Reflection
{
    using System;

    /// <summary>
    /// A exception that is raised when the
    /// assembly cannot be loaded from a zip file.
    /// </summary>
    public class  ZipAssemblyLoadException : Exception
    {
        /// <summary>
        /// A exception that is raised when the
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        public ZipAssemblyLoadException() : base()
        {
        }

        /// <summary>
        /// A exception that is raised when the
        /// assembly cannot be loaded from a zip file.
        /// </summary>
        public ZipAssemblyLoadException(string str) : base(str)
        {
        }
    }
}
