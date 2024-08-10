using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAction : MonoBehaviour
{
    // Start is called before the first frame update
    public Forge forge;
    public OreCollector collector;
    public anvil anvil;
    public Desk desk;

    private void Start()
    {
        forge = FindFirstObjectByType<Forge>();
        collector = FindFirstObjectByType<OreCollector>();
        anvil = FindFirstObjectByType<anvil>();
        desk= FindFirstObjectByType<Desk>();
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
        if (desk.deskActive)
        {
            desk.click();
        }
    }
}
