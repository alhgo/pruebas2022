using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoSubito : MonoBehaviour
{

    //Numero de vidas
    [SerializeField] int lifes;
    [SerializeField] float shield;
    float damage;
    bool alive = true; //Si estoy vivo o no
    string message = "Hola mundo";


    // Start is called before the first frame update
    void Start()
    {
        //Pongo valores de inicio
        lifes = 3;
        shield = 100f;


        //Impacto();
    }

    // Update is called once per frame
    void Update()
    {
        //Compruebo si pulsan el espacio 
        //Y SI ESTOY VIVO
        if(Input.GetKeyDown(KeyCode.Space) && alive)
        {

                Impacto();
        }


    }

    void Impacto()
    {
       
        damage = Random.Range(1f,100f);
        shield -= damage;

        if(shield < 0)
        {
            lifes--;

            if (lifes == 0)
            {
                message = "HAS MUERTO";
                alive = false;

            }
            else
            {
                shield = 100f;
                message = "Has perdido una vida. Te quedan " + lifes;
                //Invoke("Impacto", 2f);
            }

        }
        else
        {
            //Invoke("Impacto", 2f);
            message = "Te han impactado con " + damage + ". Te queda " + shield + " de escudo";
        }

        print(message);


    }


}
