using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleMan.Extensions;


public class MathCalcDemo : MonoBehaviour
{
    //******     FIELDS AND PROPERTIES   	******\\
    [SerializeField]
    private float m_speed = 5;

    [SerializeField]
    private float m_distance = 5;


    private Transform m_satellite;
    private float m_angle;



    //******    	    METHODS  	  	    ******\\
    private void Start()
    {
        //Create satellite sphere
        m_satellite = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
        m_satellite.parent = transform;
    }

    void Update()
    {
        //Increace angle
        m_angle += m_speed * Time.deltaTime;


        //Set satellite position
        m_satellite.localPosition = MathCalculations.GetDirectionByAngle(m_distance, m_angle);
    }
}
