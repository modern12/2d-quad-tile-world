using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public GameObject groundTilePrefab;
    public int mapWidth = 32;
    public int mapHeight = 32;

    void Awake()
    {
        instance = this;
        BuildGround();
        Physics.gravity = new Vector3(0, 0, 9.81f); //change gravity towards Z axis
    }

    /*
	void Start () {
        
	}
    */

    public void BuildGround()
    {
        for (int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                GameObject go = (GameObject)Instantiate(groundTilePrefab, new Vector3 (i,j,0), Quaternion.identity);
                go.transform.parent = GameObject.Find("GroundTiles").transform;
            }
        }
    }

}
