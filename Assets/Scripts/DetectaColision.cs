using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaColision : MonoBehaviour
{
    // Start is called before the first frame update
    //Cada ves que colisione el animal con la comida se va disparar la siguiente funcion y va a destruir 
    void OnTriggerEnter(Collider food)
    {
        Destroy(gameObject);
        Destroy(food.gameObject);
    }
}
