using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float inputHor;
    float velocidad = 15;
    public GameObject foodProyectil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //No salirse del lado izquierdo 
        if(transform.position.x < -20) {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }else if (transform.position.x > 20){
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }

         if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProyectil, gameObject.transform.position, foodProyectil.transform.rotation);
        }
        //Variable que va huardar hori
        inputHor = Input.GetAxis("Horizontal");

        //Acceder a componente
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * inputHor);    
    }
}
