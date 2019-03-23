using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameAssignment 
{
    public static ResourceManager _resourcesManager;

    public static ResourceManager GetResourcesManager()
    {
        if(_resourcesManager == null)
        {
            _resourcesManager = Resources.Load("ResourcesManager") as ResourceManager;
        }

        return _resourcesManager;
    }
}
