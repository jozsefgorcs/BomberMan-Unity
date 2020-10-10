using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BompDeployer : MonoBehaviour
{
    [SerializeField]
    private GameObject bomb;

    [SerializeField]
    private GameObject bombContainer;

    private bool isPlantable = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))//Press up arrow key to move forward on the Y AXIS
        {
            PlantBomb();
        }
    }

    private void PlantBomb()
    {
        if (!isPlantable) return;

        var newBomb = Instantiate(bomb, bombContainer.transform);
        newBomb.transform.position = gameObject.transform.position;
        isPlantable = false;
        Invoke("CooldownBomb", 1.0f);
    }

    private void CooldownBomb() {
        isPlantable = true;
    }
}
