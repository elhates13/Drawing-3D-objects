using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Matrixs
    {
        public static float[,] GetTranslationMatrix(float trX, float trY, float trZ)
        {
            return new float[,]
            {
                { 1, 0, 0, trX},
                { 0, 1, 0, trY},
                { 0, 0, 1, trZ},
                { 0, 0, 0,   1}
            };
        }

        public static float[,] GetScalingMatrix(float sx, float sy, float sz)
        {
            return new float[,]
            {
                { sx, 0, 0, 0},
                { 0, sy, 0, 0},
                { 0, 0, sz, 0},
                { 0, 0,  0, 1}
            };
        }

        public static float[,] GetRotationXMatrix(float angle)
        {
            float rad = angle * (float)Math.PI / 180f;
            return new float[,]
            {
                { 1,                    0,                     0, 0},
                { 0, (float)Math.Cos(rad), -(float)Math.Sin(rad), 0},
                { 0, (float)Math.Sin(rad),  (float)Math.Cos(rad), 0},
                { 0,                    0,                     0, 1}
            };
        }

        public static float[,] GetRotationYMatrix(float angle)
        {
            float rad = angle * (float)Math.PI / 180f;
            return new float[,]
            {
                { (float)Math.Cos(rad), 0, (float)Math.Sin(rad),  0 },
                {                    0, 1,                    0,  0 },
                { -(float)Math.Sin(rad), 0, (float)Math.Cos(rad), 0 },
                {                    0,  0,                    0, 1 }
            };
        }

        public static float[,] GetRotationZMatrix(float angle)
        {
            float rad = angle * (float)Math.PI / 180f;
            return new float[,]
            {
                { (float)Math.Cos(rad), (float)-Math.Sin(rad), 0, 0 },
                { (float)Math.Sin(rad), (float)Math.Cos(rad), 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
        }

        public static float[,] GetShearMatrixX(float shy, float shz)
        {
            return new float[,]
            {
                { 1, shy, shz, 0 },
                { 0,   1,   0, 0 },
                { 0,   0,   1, 0 },
                { 0,   0,   0, 1 }
            };
        }

        public static float[,] GetShearMatrixY(float shx, float shz)
        {
            return new float[,]
            {
                {   1, 0,   0, 0 },
                { shx, 1, shz, 0 },
                {   0, 0,   1, 0 },
                {   0, 0,   0, 1 }
            };
        }

        public static float[,] GetShearMatrixZ(float shx, float shy)
        {
            return new float[,]
            {
                {   1,   0, 0, 0 },
                {   0,   1, 0, 0 },
                { shx, shy, 1, 0 },
                {   0,   0, 0, 1 }
            };
        }

        public static float[,] GetOPPMatrix(float prX, float prY, float prZ)
        {
            return new float[,]
            {
                {    1   ,    0   ,   0    , 0},
                {    0   ,    1   ,   0    , 0},
                {    0   ,    0   ,   1    , 0},
                { 1 / prX, 1 / prY, 1 / prZ, 1}
            };
        }

        public static float[,] GetOPPMatrixX(float prX)
        {
            return new float[,]
            {
                {    1   , 0, 0, 0},
                {    0   , 1, 0, 0},
                {    0   , 0, 1, 0},
                { 1 / prX, 0, 0, 1}
            };
        }

        public static float[,] GetOPPMatrixY(float prY)
        {
            return new float[,]
            {
                { 1,    0   , 0, 0},
                { 0,    1   , 0, 0},
                { 0,    0   , 1, 0},
                { 0, 1 / prY, 0, 1}
            };
        }

        public static float[,] GetOPPMatrixZ(float prZ)
        {
            return new float[,]
            {
                { 1, 0,    0   , 0},
                { 0, 1,    0   , 0},
                { 0, 0,    1   , 0},
                { 0, 0, 1 / prZ, 1}
            };
        }
    }
}
