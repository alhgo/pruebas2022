using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{

    [SerializeField] GameObject bolo;

    //Separación de bolos
    float separate = 1f;

    // Start is called before the first frame update
    void Start()
    {

        BolosIniciales();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BolosIniciales()
    {
        if (GameManager.numFilas == 0)
            GameManager.numFilas = 3;

        float y = 10f;
        for (int n = 0; n < GameManager.numFilas; n++)
        {
            CrearFilas(y);
            y++;
        }
    }

    void CrearFilas(float z)
    {

        Vector3 instPos = new Vector3(-1.5f, 0.9f, z);

        for (int n = 0; n < 3; n++)
        {
            Instantiate(bolo, instPos, Quaternion.identity);
            instPos += new Vector3(separate, 0f, 0f);
        }



    }
}
