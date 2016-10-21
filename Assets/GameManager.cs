using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public GameObject groundTilePrefab;
    public GameObject asphaltTilePrefab;
    public GameObject concreteSlabTilePrefab;

    [Range(64, 256)]
    public int mapWidth = 64;
    [Range(64, 256)]
    public int mapHeight = 64;

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

                if (i == 3 || i == 9)
                {
                    GameObject go = (GameObject)Instantiate(concreteSlabTilePrefab, new Vector3(i, j, 0), Quaternion.identity);
                    go.transform.parent = GameObject.Find("GroundTiles").transform;
                }
                else if (i >= 4 && i <= 8)
                {
                    GameObject go = (GameObject)Instantiate(asphaltTilePrefab, new Vector3(i, j, 0), Quaternion.identity);
                    go.transform.parent = GameObject.Find("GroundTiles").transform;
                }
                else
                {
                    GameObject go = (GameObject)Instantiate(groundTilePrefab, new Vector3 (i,j,0), Quaternion.identity);
                    go.transform.parent = GameObject.Find("GroundTiles").transform;
                }
                
            }
        }
    }

}
