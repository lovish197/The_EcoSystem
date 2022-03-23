using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LA.Framework
{
    [System.Serializable]
    public class Vector
    {
        public float m_X;
        public float m_Y;
        public float m_Z;

        public Vector(float a_X = 0, float a_Y = 0, float a_Z = 0f)
        {
            m_X = a_X;
            m_Y = a_Y;
            m_Z = a_Z;
        }

        /// <summary>
        /// It do the vector addition 
        /// </summary>
        /// <param name="a_V"> Pass a Vector you wants to add in the curr Vector</param>
        public void Add(Vector a_V)
        {
            m_X += a_V.m_X;
            m_Y += a_V.m_Y;
            m_Z += a_V.m_Z;
        }

        /// <summary>
        /// Subtracts a vector from a vector
        /// </summary>
        /// <param name="a_V">Pass a Vector you wants to subtract from the curr Vector</param>
        public void Subtract(Vector a_V)
        {
            m_X -= a_V.m_X;
            m_Y -= a_V.m_Y;
            m_Z -= a_V.m_Z;
        }

        /// <summary>
        /// Scale a vector
        /// </summary>
        /// <param name="a_n">Pass the value the vector must scale with</param>
        public void Multiply(float a_n)
        {
            m_X *= a_n;
            m_Y *= a_n;
            m_Z *= a_n;
        }

        /// <summary>
        /// Descale a Vector
        /// </summary>
        /// <param name="a_n">Pass the value the vector must descale with</param>
        public void Divide(float a_n)
        {
            m_X /= a_n;
            m_Y /= a_n;
            m_Z /= a_n;
        }

        /// <summary>
        /// Gets the magnitude(Length) of the vector
        /// </summary>
        public float Magnitude()
        {
            return Mathf.Sqrt(m_X * m_X + m_Y * m_Y + m_Z * m_Z);
        }

        /// <summary>
        /// Normalize the Vector (Convert it to a Unit Vector)
        /// </summary>
        public void Normalize()
        {
            float l_Mag = this.Magnitude();
            try
            {
                if (l_Mag != 0)
                    Divide(l_Mag);
            }
            catch(Exception)
            {
                Debug.LogError("Vector with the magnitude 0 can't be normalized");
            }
        }

        /// <summary>
        /// If magnitude of a vector increase by certain limit set it to the maximum cap
        /// </summary>
        /// <param name="a_Max">the max the magnitude can be</param>
        public void Limit(float a_Max)
        {
            if(Magnitude() > a_Max)
            {
                Normalize();
                Multiply(a_Max);
            }
        }
        /// <summary>
        /// Returns  A random Unit vector of any direction
        /// </summary>
        /// <returns> A random Unit vector of any direction</returns>
        public static Vector RandomVector()
        {
            Vector l_ThisVector = new Vector(0, 0, 0);

            Vector l_RandomVector = new Vector(UnityEngine.Random.Range(-1, 2),
                UnityEngine.Random.Range(-1, 2),
                UnityEngine.Random.Range(-1, 2));

            l_ThisVector.Add(l_RandomVector);

            l_ThisVector.Normalize();
            return l_ThisVector;
        }
    }
}
