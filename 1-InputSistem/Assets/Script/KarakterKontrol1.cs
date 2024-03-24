using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KarakterKontrol1 : MonoBehaviour
{
    Vector3 inputDirection;
    Vector2 Rotasyon;
    public GameObject mermi;
    public GameObject firePoint;

    void Start()
    {
        if(Accelerometer.current != null)
        {
            InputSystem.EnableDevice(Accelerometer.current); //Sensor varsa aktiflestiriyoruz
        }
    }

    /*public void OnHareket(InputValue value)
    {
        //Ivme olcer icin 
        Vector2 gelenVector = Accelerometer.current.acceleration.ReadValue();
        //Accelerometer.current.samplingFrequency = 3;  //Bilgileri alma hizi
        inputDirection = new Vector3(gelenVector.x, 0, gelenVector.y);
    }*/

    public void OnNavigate(InputValue value)
    {
        Vector2 gelenVector = value.Get<Vector2>();
        inputDirection = new Vector3(gelenVector.x, 0, gelenVector.y);
    }

    public void OnHareket(InputValue value)
    {
        Vector2 gelenVector = value.Get<Vector2>();
        inputDirection = new Vector3(gelenVector.x, 0, gelenVector.y);
    }

    public void OnZiplama(InputValue value)
    {
        if (value.Get() != null)
        {
            GetComponent<Rigidbody>().AddForce(0, 20, 2f, ForceMode.Impulse);
        }
    }

    public void OnAtesEtme(InputValue value)
    {
        if (value.Get() != null)
        {
            GameObject olusanMermi = Instantiate(mermi, firePoint.transform.position, firePoint.transform.rotation);
            olusanMermi.GetComponent<Rigidbody>().AddForce(transform.forward * 50f, ForceMode.Impulse);
        }
    }

    public void OnDonus(InputValue value)
    {
        Rotasyon = value.Get<Vector2>();
    }

    void Update()
    {
        transform.Translate(inputDirection * Time.deltaTime * 20f);

        Vector2 r = new Vector2(0, Rotasyon.x) * 250f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }
}
