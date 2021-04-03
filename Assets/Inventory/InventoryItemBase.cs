using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemBase : MonoBehaviour
{
    public InventoryPanel inv;
    HealthBarScreenSpaceController health;
    
  public virtual string Name
    {
        get
        {
            return "_base item_";
        }
    }

    public Sprite _Image;

    public Sprite Image
    {
        get { return _Image; } 
    }

    [SerializeField]
    private int healthValue;
    public virtual void OnUse()
    {
        if (PlayerBehaviour.MyInstance.healthBar.currentHealth < PlayerBehaviour.MyInstance.healthBar.MaxHealth)
        {          
            PlayerBehaviour.MyInstance.healthBar.currentHealth += healthValue;
            /* transform.localPosition = PickPosition;
            transform.localEulerAngles = PickRotation;*/
        }
    }
    public InventorySlots Slot
    {

        get; set;

    }
    public void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
        }
    }

    public virtual void OnPickup()
    {
        Destroy(gameObject.GetComponent<Rigidbody>());
        gameObject.SetActive(false);

    }

    public Vector3 PickPosition;

    public Vector3 PickRotation;

    public Vector3 DropRotation;

    public bool UseItemAfterPickup = false;
}
