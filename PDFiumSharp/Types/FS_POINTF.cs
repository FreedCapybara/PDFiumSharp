#region Copyright and License
/*
This file is part of PDFiumSharp, a wrapper around the PDFium library for the .NET framework.
Copyright (C) 2017 Tobias Meyer
License: Microsoft Reciprocal License (MS-RL)
*/
#endregion
using System;
using System.Runtime.InteropServices;

namespace PDFiumSharp.Types
{
	[StructLayout(LayoutKind.Sequential)]
	public struct FS_POINTF
    {
		public float X { get; }
		public float Y { get; }

		public FS_POINTF(float x, float y)
		{
			X = x;
			Y = y;
		}
	}
}
