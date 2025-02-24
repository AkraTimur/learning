﻿using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }
        public Vector Add (Vector vector)
        {
            return Geometry.Add(this, vector);
        }
        public bool  Belongs (Segment segment)
        {
            return Geometry.IsVectorInSegment(this, segment);
        }
        
    }
}
