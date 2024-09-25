using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    // Start is called before the first frame update

    //Le decimos que es un arreglo de gameobjects y ese objeto se va llamar animales 
    public GameObject[] animales;

    void Start()
    {
        //Cada dos segundos se empiesa a crear los objetos y con un retraso de 0.5 entre cada creacion
        InvokeRepeating("SpawnAnimales", 5.0F, 0.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para que se especialize en crear los animales
    void SpawnAnimales()
    {
        //Generamos un indice para el animal
        //Con esto genera el game object o el animal en un rango de 20 a -20 
        int indice = Random.Range(0, animales.Length);
        int rango = Random.Range(-20, 20);
        //Spamear el gameObject en esa pocision simrpe
        Vector3 pos = new Vector3(rango, 0, 30);
        //creamos unainstancia que se define desde unity despues se coloca con pos su pocision de origen y se establece
        //que sea el animal 0 que es el primero en la lista y despues que tome su transform y su rotation que ya tiene
        Instantiate(animales[indice], pos,
            animales[0].transform.rotation);
    }
}
