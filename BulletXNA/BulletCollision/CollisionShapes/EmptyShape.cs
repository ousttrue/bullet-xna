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

using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using BulletXNA.BullettCollision.BroadphaseCollision;
using System.Diagnostics;

namespace BulletXNA.BulletCollision.CollisionShapes
{
    public class EmptyShape : ConcaveShape
    {
        public EmptyShape()
        {
            m_shapeType = BroadphaseNativeTypes.EMPTY_SHAPE_PROXYTYPE;
        }

        public override void Cleanup()
        {
            base.Cleanup();
        }

        public override void GetAabb(ref Matrix t,out Vector3 aabbMin,out Vector3 aabbMax)
        {
            float fmargin = GetMargin();
            Vector3 margin = new Vector3(fmargin,fmargin,fmargin);
	        aabbMin = t.Translation - margin;
	        aabbMax = t.Translation + margin;
        }

        public override void SetLocalScaling(ref Vector3 scaling)
	    {
		    m_localScaling = scaling;
	    }

        public override Vector3 GetLocalScaling()
	    {
		    return m_localScaling;
	    }

        public override void CalculateLocalInertia(float mass, ref Vector3 inertia)
        {
            Debug.Assert(false);
        }
	
	    public override String GetName()
	    {
		    return "Empty";
	    }

        public override void ProcessAllTriangles(ITriangleCallback callback, ref Vector3 vec1, ref Vector3 vec2)
	    {
	    }


        protected Vector3 m_localScaling;
    }
}