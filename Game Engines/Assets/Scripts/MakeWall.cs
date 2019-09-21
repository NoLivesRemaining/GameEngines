using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWall : MonoBehaviour
{
    public GameObject brick;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(brick, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
