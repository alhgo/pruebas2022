using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoSubito : MonoBehaviour
{

    [SerializeField] GameObject[] vidasArray;


    //Numero de vidas
    [SerializeField] int lifes;
    [SerializeField] float shield;
    float damage;
    public bool alive = true; //Si estoy vivo o no
    string message = "Hola mundo";


    // Start is called before the first frame update
    void Start()
    {
        //Pongo valores de inicio
        lifes = 5;
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

    public void Impacto()
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
            //Me han quitado una vida pero no estoy muerto
            else
            {
                shield = 100f;
                message = "Has perdido una vida. Te quedan " + lifes;
                //Invoke("Impacto", 2f);
                for(int n = lifes; n > 0; n--)
                {
                    print("Parpadea la vida" + n);
                }

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
