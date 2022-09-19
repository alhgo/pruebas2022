using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
 



    //Numero de vidas
    [SerializeField] int lifes;
    [SerializeField] float shield;
    float damage;
    bool alive = true; //Si estoy vivo o no
    [SerializeField] string message = "Hola mundo";

    //Variables de Unity
    [SerializeField] Vector3 myVector;
    [SerializeField] GameObject myObject;
    [SerializeField] Transform myTransform;

    int n = 0;

    bool msg0 = false;
    bool msg500 = false;
    bool msg1000 = false;


    private void Start()
    {
        lifes = 3;
        shield = 100f;
        message = "Hasta luego";
        //print(message);

        float powerUp = 50f;

        //shield += powerUp;








     
       


        

    }

    private void Update()
    {
        /*
        //print("Fotograma: " + n);
        n++;

        if(n <= 500)
        {
            if(msg0 == false)
            {
                print("No hemos llegado a 500");
                msg0 = true;
            }
            
        }
        else if(n <= 1000)
        {
            if (msg500 == false)
            {
                print("Hemos llegado a 500 pero no hemos llegado a 100");
                msg500 = true;
            }
           
        }
        else
        {
            if (msg1000 == false)
            {
                print("Hemos superado los 1000 fotogramas");
                msg1000 = true;
            }
        }

        


        */

    }





}
