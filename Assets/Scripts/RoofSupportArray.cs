using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofSupportArray : MonoBehaviour
{
    public GameObject roofSupport;

    public int units_x = 1;
    public int units_y = 25;

    public Renderer rendererA;

    [SerializeField] private Vector3 size;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rendererA = roofSupport.GetComponent<Renderer>();

        size = rendererA.bounds.size;

        for(int i = 0; i <units_x; i++)
        {
            for(int j = 0; j <units_y; j++)
            {
                Instantiate(roofSupport, new Vector3(i * 1.3f , -.3f, j * 1.3f), Quaternion.identity);
            }
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
