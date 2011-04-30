﻿/*
 * C# / XNA  port of Bullet (c) 2011 Mark Neale <xexuxjy@hotmail.com>
 *
 * Bullet Continuous Collision Detection and Physics Library
 * Copyright (c) 2003-2008 Erwin Coumans  http://www.bulletphysics.com/
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the authors be held liable for any damages arising from
 * the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose, 
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would be
 *    appreciated but is not required.
 * 2. Altered source versions must be plainly marked as such, and must not be
 *    misrepresented as being the original software.
 * 3. This notice may not be removed or altered from any source distribution.
 */


namespace BulletXNA.LinearMath
{
    public struct UShortVector3
    {
        public ushort X;
        public ushort Y;
        public ushort Z;

        public void min(ref UShortVector3 a)
        {
            if (X > a.X) X = a.X;
            if (Y > a.Y) Y = a.Y;
            if (Z > a.Z) Z = a.Z;
        }

        public void max(ref UShortVector3 a)
        {
            if (X < a.X) X = a.X;
            if (Y < a.Y) Y = a.Y;
            if (Z < a.Z) Z = a.Z;
        }
    }

}