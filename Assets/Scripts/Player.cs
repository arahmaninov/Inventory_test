using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;

    [SerializeField] float speed;

    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector2(transform.position.x + (h * speed), transform.position.y + (v * speed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var item = collision.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(collision.gameObject);
        }
    }

    // for 3D:
    // public void OnTriggerEnter(Collider other)
    // {
    //     var item = other.GetComponent<Item>();
    //     if (item)
    //     {
    //         inventory.AddItem(item.item, 1);
    //         Destroy(other.gameObject);
    //     }
    // }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
