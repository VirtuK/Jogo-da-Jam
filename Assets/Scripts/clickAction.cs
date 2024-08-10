using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAction : MonoBehaviour
{
    // Start is called before the first frame update
    public Forge forge;
    public OreCollector collector;
    public anvil anvil;

    private void Start()
    {
        forge = FindFirstObjectByType<Forge>();
        collector = FindFirstObjectByType<OreCollector>();
        anvil = FindFirstObjectByType<anvil>();
    }
    public void click()
    {
        if (forge.forge)
        {
            forge.click();
        }
        if (collector.oreActive)
        {
            collector.click();
        }
        if (anvil.anvilClick)
        {
            anvil.click();
        }
    }
}
