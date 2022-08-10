using UnityEngine;

public class CamaraSigue : MonoBehaviour
{

    public Transform jugador;//El jugador

    public float velocidad = 0.125f;//Velocidad
    public Vector3 offset;//Distancia desde donde lo seguira

    void FixedUpdate()
    {
        Vector3 posicionDeseada = jugador.position + offset;//Posicion desde donde seguimos al jugador
        Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, velocidad);//Movemos la camara suavemente desde
        //la pos actual hasta la pos deseada utilizando la velocidad.
        transform.position = posicionSuavizada;

        transform.LookAt(jugador);//Mientras movemos la camara miramos al jugador.
    }

}