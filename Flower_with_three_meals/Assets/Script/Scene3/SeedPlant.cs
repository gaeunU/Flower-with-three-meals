using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlant : MonoBehaviour
{
    public GameObject lavender;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lavender()
    {
        Debug.Log("lavender click !");
        Vector3 mPosition = Input.mousePosition;
        Vector3 target = Camera.main.ScreenToViewportPoint(mPosition);
        transform.position = new Vector3(target.x, target.y, target.z + 1);
         Instantiate(lavender, target, Quaternion.identity);
        

    }

    public void Sunflower()
    {

    }

    public void Camellia()
    {

    }
    public void daisy()
    {

    }

}
