﻿using System;

namespace SocketIo.Core.Tests
{
    public class RandomPort : Random
	{

		public RandomPort() : base()
		{

		}

		public ushort NextPort()
		{
			return (ushort)Next(ushort.MinValue, ushort.MaxValue);
		}

		public static ushort Get()
		{
			return new RandomPort().NextPort();
		}
	}
}
