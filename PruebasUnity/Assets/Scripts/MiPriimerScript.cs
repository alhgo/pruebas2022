using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPriimerScript : MonoBehaviour
{
    [SerializeField] Vector3 initPos;
    float posY = 0f;
    float posX = 0f;
    float posZ = 0f;

    


    // Start is called before the first frame update
    void Start()
    {
        initPos = new Vector3(5f, 5f, 5f);

        transform.position = initPos;

        



    }

    // Update is called once per frame
    void Update()
    {
        posX += 0.1f;
        posY += 0.1f;
        posZ += 0.1f;

        initPos = new Vector3(posX, posY, posZ);

        if(posX <= 10)
        {
            transform.position = initPos;
        }
        


        
    }
}
