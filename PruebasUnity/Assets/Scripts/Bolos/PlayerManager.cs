using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputSystem inputActions;

    //RigidBody
    Rigidbody rb;

    

    //Fuerzas
    [SerializeField] float fuerza;

    //Puntero
    [SerializeField] Transform puntero;
    Vector3 myPos;

    //Contador para la cuenta atrás
    int contador = 1;
    private void Awake()
    {
        inputActions = new InputSystem();

        inputActions.Player.Disparar.started += _ => Shoot();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CuentaAtras");

        rb = GetComponent<Rigidbody>();

        fuerza = 100;

        GameManager.cargado = false;
    }

    void Shoot()
    {

        if(GameManager.cargado == true)
        {
            //print("Disparo");
            myPos = transform.position;
            Vector3 shootDir = puntero.position - myPos;

            rb.AddForce(shootDir.normalized * fuerza, ForceMode.Impulse);
            GameManager.cargado = false;

            Invoke("Recargar", 4f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recargar()
    {
        transform.position = new Vector3(0f, 1f, 0f);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        contador = 2;
        StartCoroutine("CuentaAtras");
    }

    IEnumerator CuentaAtras()
    {

        while(true)
        {
            if (contador == 0)
            {
                StopCoroutine("CuentaAtras");
                cargada = true;
            }
            print(contador);
            contador--;

            

            yield return new WaitForSeconds(1f);
        }

    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
