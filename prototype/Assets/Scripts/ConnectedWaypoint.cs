using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    public class ConnectedWaypoint : MonoBehaviour
    {
        [SerializeField]
        protected float _connectivityRadius = 50f;

        List<ConnectedWaypoint> _connections;

        // Start is called before the first frame update
        public void Start()
        {
            GameObject[] allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint"); //get all waypoint objects in scene

            _connections = new List<ConnectedWaypoint>(); //create list of waypoint refs

            for(int i = 0; i < allWaypoints.Length; i++)
            {
                ConnectedWaypoint nextWaypoint = allWaypoints[i].GetComponent<ConnectedWaypoint>(); //check for connected waypoint

                if(nextWaypoint != null) //if found + not null
                {
                    if(Vector3.Distance(this.transform.position, nextWaypoint.transform.position) <= connecti)
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}