using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainGenRandomObj : MonoBehaviour {



    public GameObject Object;
    public int count;// кол-во создаваемых объектов
    public float RminX, RmaxX, RminZ, RmaxZ;//Границы значений координат

   

    // Use this for initialization
    void Start () {
        for (int i = 0; i < count; i++)
        {
            var point = new Vector3(0, 0, 0);

            point.x = Random.Range(RminX, RmaxX);
            point.z = Random.Range(RminZ, RmaxZ);
            point.y = Terrain.activeTerrain.SampleHeight(point);
            GameObject.Instantiate(Object, point, transform.rotation);
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
