using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_KeyHolder : MonoBehaviour
{
   [SerializeField] private KeyHolder keyHolder;

   private Transform container;
   private Transform keyTemplate;

   private void Awake()
   {
    container = transform.Find("container");
    keyTemplate = container.Find("keyTemplate");
    keyTemplate.gameObject.SetActive(false);
   }

//     private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e)
//    {
//     UpdateVisual();
//    }

    private void UpdateVisual()
    {
        foreach (Transform child in container)
        {
            if (child == keyTemplate) continue;
            Destroy(child.gameObject);
        }
   }
}
