using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleMan.Extensions
{
    public static class MathCalculations
    {
        /// <summary>
        /// Get equidistant points positions on circle
        /// </summary>
        /// <param name="_radius">Radius of the circle</param>
        /// <param name="_pointsNumber">Number of points</param>
        /// <returns></returns>
        public static Vector2[] GetPointsOnCircle(float _radius, int _pointsNumber)
        {
            Vector2[] l_points = new Vector2[_pointsNumber];


            float l_degrees = 360;
            float l_angle = 360 / _pointsNumber;


            for (int i = 0; i < _pointsNumber; i++)
            {
                l_points[i] = new Vector2((float)System.Math.Cos((l_degrees) * Mathf.Deg2Rad) * _radius,
                                                    (float)System.Math.Sin((l_degrees) * Mathf.Deg2Rad) * _radius);


                l_degrees -= l_angle;
            }


            return l_points;
        }


        /// <summary>
        /// Get equidistant points positions on circle
        /// </summary>
        /// <param name="_center">Center of the circle</param>
        /// <param name="_radius">Radius of the circle</param>
        /// <param name="_pointsNumber">Number of points</param>
        /// <returns></returns>
        public static Vector2[] GetPointsOnCircle(Vector2 _center, float _radius, int _pointsNumber)
        {
            Vector2[] l_points = new Vector2[_pointsNumber];

  
            float l_degrees = 360;
            float l_angle = 360 / _pointsNumber;


            for (int i = 0; i < _pointsNumber; i++)
            {
                l_points[i] = _center + new Vector2((float)System.Math.Cos((l_degrees) * Mathf.Deg2Rad) * _radius,
                                                    (float)System.Math.Sin((l_degrees) * Mathf.Deg2Rad) * _radius);


                l_degrees -= l_angle;
            }


            return l_points;
        }



        


        /// <summary>
        /// Get point on circle by angle
        /// </summary>
        /// <param name="_length"> Radius of circle </param>
        /// <param name="_angle"> Target angle </param>
        /// <returns></returns>
        public static Vector2 GetDirectionByAngle(float _length, float _angle)
        {

            //Coversion euler's angle to radians  
            _angle *= Mathf.PI / 180;


            //Set crosshair position
            Vector2 l_position = new Vector2(_length * (float)Math.Cos(_angle),
                                             _length * (float)Math.Sin(_angle));


            return l_position;
        }


        /// <summary>
        /// Get point on circle by angle
        /// </summary>
        /// <param name="_center"> Center of circle </param>
        /// <param name="_radius"> Radius of circle </param>
        /// <param name="_angle"> Target angle </param>
        /// <returns></returns>
        public static Vector2 GetPointOnCircle(Vector2 _center, float _radius, float _angle)
        {
            
            //Coversion euler's angle to radians  
            _angle *= Mathf.PI / 180;


            //Set crosshair position
            Vector2 l_position = new Vector2(_radius * (float)Math.Cos(_angle), 
                                             _radius * (float)Math.Sin(_angle));


            return l_position + _center;
        }


        /// <summary>
        /// Get point on circle by angle
        /// </summary>
        /// <param name="_center"> Center of circle </param>
        /// <param name="_radius"> Radius of circle </param>
        /// <param name="_angle"> Target angle </param>
        /// <returns></returns>
        public static Vector2 GetPointOnCircle(float _radius, float _angle)
        {

            //Coversion euler's angle to radians  
            _angle *= Mathf.PI / 180;


            //Set crosshair position
            Vector2 l_position = new Vector2(_radius * (float)Math.Cos(_angle),
                                             _radius * (float)Math.Sin(_angle));


            return l_position;
        }
    }
}