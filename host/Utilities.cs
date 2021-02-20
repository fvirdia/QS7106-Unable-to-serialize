// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
using System;
using System.Diagnostics;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Convert;

static class Utilities
{
    public static bool[] Bits(int x)
    {
        Trace.Assert(x < 256);
        Trace.Assert(x >= 0);
        bool[] bits = new bool[8];

        for (int i = 0; i < 8; i++)
        {
            bits[i] = (x & (1 << i)) > 0 ? true : false;
        }

        return bits;
    }

    public static QArray<bool> nBits(int n, bool val)
    {
        bool[] bits = new bool[n];

        for (int i = 0; i < n; i++)
        {
            bits[i] = val;
        }

        return new QArray<bool>(bits);
    }

    public static QArray<bool> QBits(int x)
    {
        return new QArray<bool>(Bits(x)); // new QArray<Result>(Bits(x));
    }

    public static QArray<bool> nQBits(int n, bool val)
    {
        bool[] bits = new bool[n];
        for (int i = 0; i < n; i++)
        {
            bits[i] = val ? true : false;
        }
        return new QArray<bool>(bits);
    }

    public static void PrintBits(bool[] bits)
    {
        for (int i = 8; i > 0; i--)
        {
            Console.Write("{0:d}", bits[i - 1]);
        }
        Console.Write("\n");
    }

    public static void PrintBits(int[] bits)
    {
        for (int i = 8; i > 0; i--)
        {
            Console.Write("{0:d}", bits[i - 1]);
        }
        Console.Write("\n");
    }

    public static void PrintBits(IQArray<long> bits)
    {
        for (int i = 8; i > 0; i--)
        {
            Console.Write("{0:d}", bits[i - 1]);
        }
        Console.Write("\n");
    }

    public static void PrintBits(IQArray<Result> bits)
    {
        for (int i = 8; i > 0; i--)
        {
            Console.Write("{0:d}", bits[i - 1]);
        }
        Console.Write("\n");
    }

    public static void PrintBits(IQArray<Boolean> bits)
    {
        bool t;
        t = bits[0];
        for (int i = 8; i > 0; i--)
        {
            Console.Write("{0:d}", bits[i - 1]);
        }
        Console.Write("\n");
    }
}