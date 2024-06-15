using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsBusYellow : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 500f; // Ajusta este valor según sea necesario

    // Referencia al script Cars para obtener la velocidad
    public BusYellow carScript;

    void Update()
    {
        RotateWheel();
    }

    void RotateWheel()
    {
        // Calcula la cantidad de rotación basada en la velocidad del coche
        float rotationAmount = carScript.speed * rotationSpeed * Time.deltaTime;

        // Rota la rueda alrededor del eje X (supuesto eje de rotación de la rueda)
        transform.Rotate(Vector3.right, rotationAmount);
    }

}
