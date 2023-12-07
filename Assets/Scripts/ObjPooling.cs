using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPooling : Singleton<ObjPooling>
{
    Dictionary<GameObject, List<GameObject>> listObj = new Dictionary<GameObject, List<GameObject>>();
    public Object GetObject(GameObject defaultPrefab)
    {
        if (listObj.ContainsKey(defaultPrefab))
        {
            foreach (GameObject item in listObj[defaultPrefab])
            {
                if (item.activeSelf)
                {
                    continue;
                }
                return item;
                    
            }
            GameObject g = Instantiate(defaultPrefab, transform.position, Quaternion.identity);
            listObj[defaultPrefab].Add(g);
            g.SetActive(false);
            return g;
        }

        List<GameObject> newList = new List<GameObject>();
        GameObject g2 = Instantiate(defaultPrefab, transform.position, Quaternion.identity);
        newList.Add(g2);
        listObj.Add(defaultPrefab, newList);
        g2.SetActive(false);
        return g2;

    }
}