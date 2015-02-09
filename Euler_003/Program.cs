﻿using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args) {
        maxfactor(600851475143);
        Console.ReadKey();
    }
        
static private ulong maxfactor (ulong n)
{
    unchecked
    {
        while (n > 3 && 0 == (n & 1)) n >>= 1;

        uint k = 3;
        ulong k2 = 9;
        ulong delta = 16;
        while (k2 <= n)
        {
            if (n % k == 0)
            {
                n /= k;
            }
            else
            {
                k += 2;
                if (k2 + delta < delta) return n;
                k2 += delta;
                delta += 8;
            }
        }
    }
    Console.WriteLine(n);

    return n;}}